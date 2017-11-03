using System.Linq;

namespace BirthdayGreetings_Kata
{
    public class BirthdayGreetings
    {
        private readonly IEmployeeRepository employeeRepository;
        private readonly IGreetingsSender greetingsSender;
        private readonly IDateTimeService dateTimeService;

        public BirthdayGreetings(IEmployeeRepository employeeRepository, IGreetingsSender greetingsSender, IDateTimeService dateTimeService)
        {
            this.employeeRepository = employeeRepository;
            this.greetingsSender = greetingsSender;
            this.dateTimeService = dateTimeService;
        }

        public void Greet()
        {
            var anniversaryDate = dateTimeService.GetToday();
            var employees = employeeRepository.FindBornOn(anniversaryDate);

            employees.ToList().ForEach(employee => greetingsSender.Send(employee));
        }
    }
}