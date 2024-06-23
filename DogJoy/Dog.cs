using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DogJoy
{
    public class Dog
    {
        public int ID { get; private set; } //Hundens ID, som skal være unik - f.eks. 101
        public string Name { get; private set; } //Hundens navn – f.eks. ”Pluto”
        public Race Race { get; private set; } //Hundens race – f.eks. ”Bulldog”
        public int YearOfBirth { get; private set; } //Hundens fødselsår – f.eks. 2017

        public Dog(int id, string name, Race race, int yearOfBirth) 
        { 
            ID= id;
            Name = name;
            Race = race;
            YearOfBirth = yearOfBirth;
        }

        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, Race {Race}, YOB: {YearOfBirth}";
        }

    }
}
