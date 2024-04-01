namespace Task02.Models
{
    public abstract class Employee
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Title { get; set; }
        public double Experience { get; set; }
        public double WorkingHours { get; set; }
        protected Employee(string firstName, string lastName, string title, double experience, double workingHours)
        {
            Firstname = firstName;
            Lastname = lastName;
            Title = title;
            Experience = experience;
            WorkingHours = workingHours;
        }

        public abstract string DisplayInfo();

        //had to change the signature for calculating purposes :)
        public abstract string CalculateSalary(double baseHourlyRate);
    }
}
