namespace Task02.Models
{
    internal class Programmer : Employee
    {
        public Programmer(string firstName, string lastName, double experience, double workingHours)
            : base(firstName, lastName, title: "Programmer",  experience,  workingHours)
        {

        }

        public override string DisplayInfo()
        {
            return $"{Firstname} {Lastname} - Manager\n" +
                   $"Experience: {Experience}\n" +
                   $"Working hours: {WorkingHours}";
        }

        public override string CalculateSalary(double baseHourlyRate)
        {
            //double baseHourlyRate = 10000;
            double experienceRateYear = 1.5;
            double hourlyRate = baseHourlyRate + (Experience * experienceRateYear);
            double salary = hourlyRate * WorkingHours;

            return $"Salary for the programmer {Firstname} {Lastname} is {salary}";
        }
    }
}
