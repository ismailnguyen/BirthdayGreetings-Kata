using NSubstitute;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace BirthdayGreetings_Kata.Tests
{
    public class BirthdayGreetingsTest
    {
        [Test]
        public void Should_Send_Greetings_To_All_Employee()
        {
            // GIVEN
            var anniversaryDate = new DateTime(2017, 11, 03);

            var dateTimeService = Substitute.For<IDateTimeService>();
            dateTimeService.GetToday().Returns(new DateTime(2017, 11, 03));

            var employee = new Employee("DUPONT", "Jean", "jean@dupont.fr", new DateTime(1959, 11, 03));
            var employeeRepository = Substitute.For<IEmployeeRepository>();
            employeeRepository.FindBornOn(anniversaryDate).Returns(new List<Employee>() { employee });

            var greetingsSender = Substitute.For<IGreetingsSender>();

            var birthdayGreetings = new BirthdayGreetings(employeeRepository, greetingsSender, dateTimeService);

            // WHEN
            birthdayGreetings.Greet();

            // THEN
            employeeRepository.Received().FindBornOn(anniversaryDate);
            greetingsSender.Received().Send(employee);
        }
    }
}
