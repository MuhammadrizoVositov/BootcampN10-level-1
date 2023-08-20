namespace N24_HT1
{
    public class UserService : IUserServise
    {
        private readonly List<User> _users;

        public List<User> Get(int pageSize, int pageToken)
        {
            return _users.Skip((pageSize - 1) * pageToken).Take(pageSize).ToList();// shu pegination qaytarishlik
        }

        public List<User> Search(string searchKeyword, int pageSize, int pageToken)
        {
            var people = _users.Where(a => a.FirstName == searchKeyword || a.LastName == searchKeyword || a.EamilAdress == searchKeyword);

            return people.Skip((pageSize - 1) * pageToken).Take(pageSize).ToList();
        }
        public List<User> Filter(UserFilterModel userFilterModel)
        {
            var search = _users.Where(a => a.FirstName == userFilterModel.FirstName || a.LastName == userFilterModel.LastName).ToList();

            return search.Skip((userFilterModel.PageSize - 1) * userFilterModel.PageToken).Take(userFilterModel.PageSize).ToList();

        }
        
        public void Add(string firstName,string lastName,string emailAdress) 
        {
            if (_users.Exists(y => y.EamilAdress == emailAdress))
            {
                throw new Exception("This email Adress already exists");
            }
            User newUser = new User();
            newUser.FirstName = firstName;
            newUser.LastName = lastName;    /// bu ham izlash deyiladi
            newUser.EamilAdress = emailAdress;
            _users.Add(newUser);
            
        }

        public void Update(User user)
        {
            User user1=_users.Find(u=>u.Id == user.Id); // bu ham izlash
            if(user1 == null)
            {
                throw new Exception("User Id topilmadi");
            }
            User newUser = new User();
            newUser.FirstName = user.FirstName;
            newUser.LastName = user.LastName;   // bu qoshish
            newUser.EamilAdress = user.EamilAdress;
            _users.Add(newUser);
        }
        public void Delete(int id) 
        {
            var user = _users.Find(k => k.Id == id);// bu izlash deyiladi
            if (user == null);
            {
                throw new Exception("User not found");
            }
            _users.Remove(user); // bu ochirish deyiladi
            

        }
    }
}
