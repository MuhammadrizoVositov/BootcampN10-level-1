
using sql;

var dbContext=new EFCoreContext();

Person person = new Person()
{
    Login = "Admin",
    Age = 18,
    Email = "Admin@gmail.com"
};
dbContext.People.Add(person);
dbContext.SaveChanges();
