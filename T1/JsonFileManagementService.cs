using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace T1
{
    public class JsonFileManagementService : FileManagementServiceBase
    {
        public override Task<string> ReadAsync(string filePath)
        {
            return filePath.EndsWith(".json")
                ? File.ReadAllTextAsync(filePath)
                : throw new InvalidOperationException("File json bolishi kerak");
        }

        public override Task WriteAsync(string filePath, object Data)
        {
            return filePath.EndsWith(".json")
                ? File.WriteAllTextAsync(filePath, JsonSerializer.Serialize(Data))
                : throw new InvalidOperationException("file json bolishi kreak");
        }

        public async Task<T> ReadAsync<T>(string filePath)
        {
            var fileData = await ReadAsync(filePath);
           return JsonSerializer.Deserialize<T>(fileData);
        }
    }
}
