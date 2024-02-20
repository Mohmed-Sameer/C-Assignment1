//Made by: Mohmed Sameer, Ansh Singla, Purav Sidhu
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Assignment_1
{
    internal class Patient
    {
        // Properties of Pascal Case4
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Weight { get; set; } // in KG
        public double Height { get; set; } // in Centimeters

        // Constructor
        public Patient(string firstName, string lastName, double weight, double height)
        {
            FirstName = firstName;
            LastName = lastName;
            Weight = weight;
            Height = height;
        }

        // Method to calculate blood pressure
        public string CalculateBloodPressureOfPatient(int systolic, int diastolic)
        {
            if (systolic < 90 || systolic > 200 || diastolic < 60 || diastolic > 120)
            {
                return "Invalid blood pressure values. Please consult your doctor, Something is wrong.";
            }
            else if (systolic < 120 && diastolic < 80)
            {
                return "NORMAL"; 
            }
            else if (systolic >= 120 && systolic <= 129 && diastolic < 80)
            {
                return "ELEVATED";
            }
            else if ((systolic >= 130 && systolic <= 139) || (diastolic >= 80 && diastolic <= 89))
            {
                return "HIGH BLOOD PRESSURE (HYPERTENSION) STAGE 1";
            }
            else if ((systolic >= 140 && systolic <= 180) || (diastolic >= 90 && diastolic <= 120))
            {
                return "HIGH BLOOD PRESSURE (HYPERTENSION) STAGE 2";
            }
            else // systolic > 180 or diastolic > 120
            {
                return "HYPERTENSIVE CRISIS (Consult your doctor immediately because condition is serious)";
            }
        }

        // Method to calculate BMI
        public double CalculateBMIOfPatient()
        {
            double heightInMeters = Height / 100; // converting height to meters
            return Weight / (heightInMeters * heightInMeters);
        }

        // Method to print patient information
        public void DisplayPatientInformation(int systolic, int diastolic)
        {
            Console.WriteLine("Full Name:" + FirstName+" "+ LastName);
            Console.WriteLine("Weight:" + Weight +" "+ "KG");
            Console.WriteLine("Height:" + Height +" "+ "Centimeters");
            Console.WriteLine("Blood Pressure:" + CalculateBloodPressureOfPatient(systolic, diastolic));
            double bmi = CalculateBMIOfPatient();
            Console.WriteLine("BMI:"+ bmi);
            if (bmi >= 25.0)
            {
                Console.WriteLine("BMI Status: Overweight");
            }
            else if (bmi >= 18.5 && bmi <= 24.9)
            {
                Console.WriteLine("BMI Status: Normal (Is in the healthy range)");
            }
            else
            {
                Console.WriteLine("BMI Status: Underweight");
            }
        }

    }
}
