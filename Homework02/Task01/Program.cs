using Task01.Models;

namespace Task01
{
    internal class Program
    {
        #region Task01

        /*
         Task 1
           Create a class User that will have 3 properties Id, Name, Age.
        Create a static class UserDatabase that will contain a list of Users (create a couple of users and add them to the list).
        Create a method (or methods) Search() that will search the UserDatabase by Id, Name and Age and will return users as a result.
         */

        #endregion
        static void Main(string[] args)
        {
            var user1 = new User(1, "Bob", 25.5);
            var user2 = new User(2, "Wayne", 30.5);
            var user3 = new User(3, "Jack", 30.5);

            UserDatabase.Users.AddRange(new[]
            {
                user1, user2, user3
            });

            List<User> searchById = UserDatabase.Search(1);
            List<User> searchByName = UserDatabase.Search("Wayne");
            List<User> searchByAge = UserDatabase.Search(30.5);

            Console.WriteLine(PrintList(searchById));
            Console.WriteLine(PrintList(searchByName));
            Console.WriteLine(PrintList(searchByAge));
        }

        public static string PrintList(List<User> users)
        {
            string result = "Search results:\n";
            foreach (var user in users)
            {
                result += $"{user.Id}. {user.Name} - {user.Age}\n";
            }
            return result;
        }
    }
}
