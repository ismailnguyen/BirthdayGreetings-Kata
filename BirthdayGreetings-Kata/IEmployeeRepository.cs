using System;
using System.Collections.Generic;

namespace BirthdayGreetings_Kata
{
    public interface IEmployeeRepository
    {
        IList<Employee> FindBornOn(DateTime anniversaryDate);
    }
}