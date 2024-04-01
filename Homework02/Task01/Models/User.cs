namespace Task01.Models
{
    //Create a class User that will have 3 properties Id, Name, Age.
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Age { get; set; }

        public User(int id, string name, double age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

    }
}
