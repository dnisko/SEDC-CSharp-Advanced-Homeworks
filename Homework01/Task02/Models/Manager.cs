namespace Task02.Models
{
    public class Manager : Employee
    {

        public Manager(string firstName, string lastName, double experience, double workingHours)
            : base(firstName, lastName, title: "Manager",  experience,  workingHours)
        {
            //Experience = experience;
            //WorkingHours = workingHours;
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

            return $"Salary for the manager {Firstname} {Lastname} is {salary}";
        }
    }
}
