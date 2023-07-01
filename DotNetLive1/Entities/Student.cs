using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLive1.Entities
{
    public class Student
    {
        public string FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public decimal? Score { get; set; }
        public Address? Address { get; set; }
        public StudentStatus StudentStatus { get; set; }

        public Student()
        {
            StudentStatus = StudentStatus.Active;
        }

        public Student(string firstName, string? lastName, DateTime? dateOfBirth, decimal? score, Address? address, StudentStatus studentStatus)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Score = score;
            Address = address;
            StudentStatus = studentStatus;
        }

        public void Update((decimal? Score, Address? Address) info)
        {
            Score = info.Score;
            Address = info.Address;
        }

        public (string Name, decimal Score, string Address) GetInfo()
        {
            return ($"{FirstName} {LastName}", Score ?? 0, Address?.GetFullAddress() ?? "N/A");
        }

        public (string, decimal, string) GetInfoNonNamed()
        {
            return ($"{FirstName} {LastName}", Score ?? 0, Address?.GetFullAddress() ?? "N/A");
        }

        public void PrintInfo()
        {
            var fullName = $"Name: {FirstName} {LastName}";
            var score = $"Score: {Score?.ToString("0.00") ?? "N/A"}";
            var address = Address?.GetFullAddress() ?? "N/A";

            Console.WriteLine(fullName);
            Console.WriteLine(score);
            Console.WriteLine(address);
        }
    }
}
