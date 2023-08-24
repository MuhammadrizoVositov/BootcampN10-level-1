using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AMALYOTp
{
    public  class Service
    {
      

        public List<TaskItem> _items= new List<TaskItem>();
        static string path = "D:\\AsyncData.json";
        public async void AddTaskAsync(TaskItem taskItem)
        {
            string text = await File.ReadAllTextAsync(path);
            var jsonData = JsonSerializer.Deserialize<List<TaskItem>>(text);
            jsonData.Add(taskItem);
            await SaveTaskAsync(jsonData);
        }

        public  void CompleteTask(TaskItem taskItem)
        {
            var result = _items.FirstOrDefault(a => a.Id == taskItem.Id);
            if (result != null) { result.IsCompleted = true; }
             SaveTaskAsync(jsonD)
        }

        public async Task SaveTaskAsync(List<TaskItem> taskItem)
        {
            
        }


    }
}
