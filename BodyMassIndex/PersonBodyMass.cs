using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BodyMassIndex
{
    internal class PersonBodyMass
    {
        double size;
        double weight;
        double bmi;
        string gender;

        public PersonBodyMass(double size, double weight, string gender)
        {
            // Constructor to initialize size and weight
            this.size = size;
            this.weight = weight;
            this.gender = gender;
        }

        public string GetGender()
        {
            return gender;
        }
        public double calculateBmi()
        {
            // Convert size from cm to m
            size = size / 100;
            // Calculate BMI
            bmi = weight / Math.Pow(size, 2);
            return bmi;
        }
    }
}
