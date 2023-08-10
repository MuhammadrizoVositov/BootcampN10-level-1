




using System.ComponentModel.DataAnnotations;

class ToDo
{
    public string TaskName { get; set; }    
    public bool isCompleted { get; set; }
}

class ToDoListServise

{
    private List<ToDo> tasks;
    
    public ListSevise()
    {
        tasks= new List<ToDo>();
    }
    public  void Add(string taskName)
    {
        tasks.Add(new ToDo { TaskName = taskName, isCompleted = false };

    }

    public string MarkDone()
    {

    }

    public bool Display()
    {


    }

}


