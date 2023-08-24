using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace N30_HT1

{
    public class DocumentAnalyzerService
    {
        public int Score = 100;

        public Task<int> Analyze(string document)
        {
            var read = Task.Run(async()=> { return await File.ReadAllTextAsync(document); });
            CalcalateIfLessThan500( read);
            CalculateIfHasExtremeDoubleWords(read);
            CalculateIfFirstWordCapital(read);
            CalculateIfOtherWordsIsLower(read);
            CalculateIfAllWordsLessThan20Chars(read);
            return Task.FromResult(Score);


        }

        public void CalcalateIfLessThan500(Task<string> document)
        {
            Task.Run(async() =>
            {
                var words = (await document).Split(',', '.', '!', '?');
                if (words.Length < 500)
                    Score -= 5;
            });
        }

        public async void CalculateIfHasExtremeDoubleWords(Task<string> document)
        {

            var words =(await  document).Split(',', '.', '!', '?', ' ');
            var distinctWords = words.Distinct().ToList();
            foreach (var distinctWord in distinctWords)
                Task.Run(() =>
                {
                    var count = 0;

                    foreach (var word in words)
                        if (distinctWord == word)
                            count++;

                    if (words.Length / 5 < count)
                        Score -= 5;
                });

        }

        public async void CalculateIfFirstWordCapital(Task<string> document)
        {
            var sentences = ( await document).Split('.', '!', '?');
            foreach (var sentence in sentences)
                Task.Run(async() =>
                {
                    var words = sentence.Trim().Split(',', ' ');
                    if (!string.IsNullOrWhiteSpace(words[0])
                        && words[0] != words[0].Substring(0, 1).ToUpper() +
                        words[0].Substring(1).ToLower())
                        Score -= 5;
                });
        }

        public async void CalculateIfOtherWordsIsLower(Task<string> document)
        {
            Task.Run(async() =>
            {
                var sentences = (await document).Split('.', '!', '?');
                foreach (var sentence in sentences)
                {
                    var words = sentence.Trim().Split(',', ' ');
                    for (var index = 1; index < words.Length; index++)
                    {
                        if (!string.IsNullOrWhiteSpace(words[index])
                            && words[index] != words[index].ToLower())
                            Score -= 5;
                    }
                }
            });


        }

        public async void CalculateIfAllWordsLessThan20Chars(Task<string> document)
        {
            var words = (await document).Split(',', '.', '!', '?', ' ');
            Task.Run(async() =>
            {
                foreach (var word in words)
                    if (word.Trim().Length > 20)
                        Score -= 5;
            });
        }
    }
}
