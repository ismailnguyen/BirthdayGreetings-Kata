using System;
using System.Linq;

namespace BirthdayGreetings_Kata
{
    public class BirthdayGreetings
    {
        private IEmployeeRepository employeeRepository;
        private IGreetingsSender greetingsSender;

        public BirthdayGreetings(IEmployeeRepository employeeRepository, IGreetingsSender greetingsSender)
        {
            this.employeeRepository = employeeRepository;
            this.greetingsSender = greetingsSender;
        }

        public void Greet()
        {
            var employees = employeeRepository.FindBornOn(new DateTime(2017, 11, 03));

            employees.ToList().ForEach(employee => greetingsSender.Send(employee));
        }
    }
}