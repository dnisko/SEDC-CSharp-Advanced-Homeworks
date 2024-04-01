namespace Task01.Models
{
    //Create a static class UserDatabase that will contain a list of Users (create a couple of users and add them to the list).
    public static class UserDatabase
    {
        public static List<User> Users = new List<User>();

        public static List<User> Search(int id)
        {
            return Users.Where(x => x.Id == id).ToList();
        }
        public static List<User> Search(string name)
        {
            return Users.Where(x => x.Name == name).ToList();
        }
        public static List<User> Search(double age)
        {
            return Users.Where(x => x.Age == age).ToList();
        }
    }
}
