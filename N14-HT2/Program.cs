using N14_HT2;

var students = new UltimateClassroomAttendance();
students.Mark("John Jones", true);
students.Mark("John Wik", true);
students.Mark("Harry Poter", false, "uyida to'y bor");
students.Mark("Jamy Vardy", false);
students.Mark("What is this", false);
students.Display();



class UltimateClassroomAttendance : ClassroomAttendance
{
    public void Mark(string fullname, bool isPresent, string cause = "Sababsiz")
    {
        students[fullname] = isPresent ? "present" : string.Join(" ", "absent", cause);
    }
    public override void Display()
    {
        base.Display();
        Console.WriteLine($"\nAttendance percantage: {GetStats()}");
    }
}