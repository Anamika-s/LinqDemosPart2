using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemos
{
    class Program2
    {
        static void Main()
        {
            List<Employee> employeeList = new List<Employee>()
            {
                new Employee() { Id=1,Name="Deepak", Dept = "HR", Manager="Manager3", Salary=19000},

                new Employee() { Id=2,Name="Sagar", Dept = "Accts", Manager="Manager3", Salary=39000},
                new Employee() { Id=3,Name="Farooq", Dept = "HR", Manager="Manager5", Salary=12000},
                new Employee() { Id=4,Name="Neena", Dept = "HR", Manager="Manager1", Salary=18500},
                new Employee() { Id=5,Name="Deepti", Dept = "Accts", Manager="Manager1", Salary=21000},
                new Employee() { Id=6,Name="Anu", Dept = "Sales", Manager="Manager4", Salary=17000},
                new Employee() { Id=7,Name="Kalpana", Dept = "HR", Manager="Manager4", Salary=19000},
                new Employee() { Id=8,Name="Ritu", Dept = "Sales", Manager="Manager4", Salary=19000}
            };
            var list = (from temp in employeeList
                        select temp).ToList();

            list = employeeList.ToList();
            list = employeeList.Select(x => x).ToList();
            foreach (Employee emp in list)
                Console.WriteLine(emp.Id + " " + emp.Name);
            list = (from temp in employeeList
                    where temp.Salary > 20000
                    select temp).ToList();

            list = employeeList.Where(x => x.Salary > 20000).ToList();
            int maxSalary = employeeList.Select(x => x.Salary).Max();
            Console.WriteLine("Max Salary " + maxSalary);

            var result = (from temp in employeeList
                          where temp.Name.Contains("Deepak")
                          select temp).First();
            Console.WriteLine(result.Name);

            result = (from temp in employeeList
                      where temp.Name.Contains("sdsdsdf")
                      select temp).FirstOrDefault();
            if(result!=null)
            Console.WriteLine(result.Name);

            result = employeeList.First(x => x.Name.Contains("Deepak"));
            Console.WriteLine(result.Id);
            Console.WriteLine(result.Name);

            var result1 = employeeList.FirstOrDefault (x => x.Name.Contains("sdasdsd"));
            if (result1 != null)
            {
                Console.WriteLine(result1.Id);
                Console.WriteLine(result1.Name);
            }

            var result2 = (from temp in employeeList
                      where temp.Dept.Contains("HR")
                      select temp.Name).ToList();
            Console.WriteLine("Emp of HR Dept");
            foreach(var temp in result2)
            {
                Console.WriteLine(temp);
            }

             var result3 =  employeeList.Where(x => x.Dept.Contains("HR")).ToList();
            //var num = 1;
            //num = "aaa";
        }
    }
}
