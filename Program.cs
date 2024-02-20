//Made by: Mohmed Sameer, Ansh Singla, Purav Sidhu
namespace Csharp_Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter patient's first name:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter patient's last name:");
            string lastName = Console.ReadLine();

            Console.WriteLine("Enter patient's weight in KG:");
            double weight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter patient's height in Centimeters:");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter patient's systolic blood pressure:");
            int systolic = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter patient's diastolic blood pressure:");
            int diastolic = Convert.ToInt32(Console.ReadLine());

            Patient patients = new Patient(firstName, lastName, weight, height);
            patients.DisplayPatientInformation(systolic, diastolic);
        }
    }
}
