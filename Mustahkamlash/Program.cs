



using Mustahkamlash;

Student<Guid,string> student1=new Student<Guid,string>(Guid.NewGuid),"Akbar","Middle");

Course course1=new Course("Dotnet BootCamp");

Universtiy<Student<Guid,string> Guid,string> universtiy=new Universtiy<Student<Guid, string> Guid, string>();
universtiy.EnrollStudent(student1 , course1);

