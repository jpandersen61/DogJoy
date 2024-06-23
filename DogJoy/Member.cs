using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DogJoy
{
    public class Member
    {
        List<Dog> dogs = new List<Dog>();
        public int ID { get; private set; } //Medlems ID, som skal være unik
        public string Name { get; private set; } //Fornavn og efternavn
        public string Address { get; private set; } //Hele adressen
        public DateTime BirthDate { get; private set; } //Fødselsdato
        public string Phone { get; private set; } //Telefon nummer med landekode
        public string Email { get; private set; } //E-Mail

        public Member(int id, string name, string address, DateTime bDate, string phone, string email)
        {
            ID = id;
            Name = name;
            Address = address;
            BirthDate = bDate;
            Phone = phone;
            Email = email;
        }

        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, Address: {Address} BirthDate: {BirthDate}, Phone: {Phone}, E-Mail: {Email}";
        }

        public void RegisterDog(Dog dog) 
        {
            dogs.Add(dog);  
        }
        public void PrintDogs()
        {
            foreach (Dog dog in dogs) 
            { 
                Console.WriteLine(dog);
            }
        }

        public void RemoveDog(Dog dog)
        {
            dogs.Remove(dog);
        }

        public int Age
        {
            get
            {    
                //Get current time
                DateTime Now = DateTime.Now;

                //Will result is the age the member will turn this year (Now.Year)
                int result = Now.Year - BirthDate.Year;

                //Month NOT reached yet -> member has NOT turned age yet   
                if (BirthDate.Month > Now.Month)
                {
                    //Subtract 1 year from result/age BEFORE returning it 
                    return --result;
                }

                //Match on Month, but Day NOT yet -> member has NOT turned age yet
                if ((BirthDate.Month == Now.Month) && (BirthDate.Day > Now.Day))
                {
                    //Subtract 1 year from result/age BEFORE returning it
                    return --result;
                }

                //Return result/age
                return result;
            }
        }

        public double MemberFee(double baseFee)
        {
            //Assume that memeber is 0
            double result = 0.0;

            //Had member got any dogs?
            if (dogs.Count == 0)
            {
                //NO
                return result;
            }

            //If reaching here member has at least one dog -> Must the pay baseFee 
            result = baseFee;
            
            //Member has turned 65?
            if (Age >= 65)
            {
                //YES -> First dog for half the price
                result = result / 2;
            }

            //Calculate fee for rest of the dogs -> Half fee for dog 2,3,...
            result = result + (dogs.Count-1) * (baseFee / 2);

            return result;
        }

        public bool Validate()
        {
            if (Age < 18)
            {
                //Opgave 7:
                //Console.WriteLine("Age must 18 or above");
                //return false;

                throw new Exception("Age must 18 or above");
            }

            if (   string.IsNullOrEmpty(Name)
                || string.IsNullOrEmpty(Address)
                || string.IsNullOrEmpty(Phone) 
                || string.IsNullOrEmpty(Email) ) 
            {
                //Opgave 7:
                //Console.WriteLine("Field NOT allowed to be empty");
                //return false;

                throw new Exception("Field NOT allowed to be empty");
            }

            return true;
        }
    }
}
