using System;
using System.Collections.Generic;
using System.Text;

namespace Class_constructor_inheritance_tasks
{
    internal class Employee:Human
    {
    //Human class:
    // - FullName
    // - Age


    //Employee:Human - Salary
    // - Position

    //Layihə run olduqda bizdən say daxil etməyimizi istəyir
    //Həmin say uzunluqda bir Employee array yaradirsınız
    //Həmin sayda employee datasının dəyərlərini console-dan götürüb, employee obyektləri yaradıb array-ə yerləşdirin

        public int Salary;
        public string Position;

        public void EmployeeData()
        {
            Console.WriteLine("Iscilerin sayini daxil edin: ");
            var employeeStr = Console.ReadLine();
            var employeeQuantity = Convert.ToInt32(employeeStr);
            Employee[] employees = new Employee[employeeQuantity];

            do
            {
                Console.WriteLine("Adinizi daxil edin: ");
                var employee1 = Console.ReadLine();
            } while (employees.Length == employeeQuantity);
        }
    }


}
