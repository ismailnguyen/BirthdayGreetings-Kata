using System;

namespace BirthdayGreetings_Kata
{
    public class Employee
    {
        private string lastname;
        private string firstname;
        private string email;
        private DateTime dateTime;

        public Employee(string lastname, string firstname, string email, DateTime dateTime)
        {
            this.lastname = lastname;
            this.firstname = firstname;
            this.email = email;
            this.dateTime = dateTime;
        }
    }
}