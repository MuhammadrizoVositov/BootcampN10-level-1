using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;

var document = new Document
{
    Content = "Lorem ipsum dolor sit amet consectetursdfsdfsdfsdfsdfsdfsdfsdfsd adipisicing elit." +
    " quaerat est quas commodi quibusdam labore, nihil doloribus quam temporibus inventore optio expedita consectetur " +
    "voluptatem QUIDEM nulla soluta earum. Numquam rem alias minima culpa iste distinctio." +
    " Eum similique est consequuntur minus, odio nisi recusandae iure asperiores facere, reiciendis voluptate maiores! " +
    "Repellat, dolorum!"
};

var analyzer = new DocumentAnalayzer();
analyzer.Analayz(document);
Console.WriteLine(document.Score);

// Document modelini yaratish
public class Document
{
    public string Content;
    public int Score=100;
}

// Documentanalayzer servisini yaratish
public class DocumentAnalayzer
{
    public int Analyze(Document document)
    {
        CalcalateIfLessThan500(document);
        CalculateIfHasExtremeDoubleWords(document);
        CalculateIfFirstWordCapital(document);
        CalculateIfOtherWordsIsLower(document);
        CalculateIfAllWordsLessThan20Chars(document);

        return document.Score;
    }

}
public void CalcalateIfLessThan500(Document document)
{
    var words = document.Content.Split(',','.','!','?');
        if(words.Length > 500 )
            document.Score-=5;
}

public void CalculateIfHasExtremeDoubleWords(Document document)
{
    var words = document.Content.Split(',' '.' '!' '?');
    var distinictWords=words.Distinct().ToList();
    foreach (var distinictWord in distinictWords)
    {
        var cnt = 0;
        foreach (var word in words) 
            if(distinictWord==word)
            {
                cnt++;
                if (word.Length/5<cnt)
                {
                    document.Score -= 5;
                }
            }
    }

}

