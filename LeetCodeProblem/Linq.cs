using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public int Age { get; set; }
        public int departmentId { get; set; }

    }

    public class Department
    {

        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
    }
    public class Linq
    {
        public static void Main()
        {
            IList<Employee> employeeList = new List<Employee>() {
            new Employee() { EmployeeID = 1, EmployeeName = "John", Age = 22, departmentId = 1} ,
            new Employee() { EmployeeID = 2, EmployeeName = "Moin",  Age = 21, departmentId = 2} ,
            new Employee() { EmployeeID = 3, EmployeeName = "Bill",  Age = 30, departmentId = 1} ,
            new Employee() { EmployeeID = 4, EmployeeName = "Ram",   Age = 26, departmentId = 2} ,
            new Employee() { EmployeeID = 5, EmployeeName = "Ron",   Age = 45, departmentId = 1}
            };

            IList<Department> departmentList = new List<Department>() {
            new Department() { DepartmentId = 1, DepartmentName = "HR" },
            new Department() { DepartmentId = 2, DepartmentName = "IT" }
            };


            #region simple linq questions
            var b = employeeList.Where(w => w.Age >= 30 && w.Age <= 40).Select(s => s.EmployeeName).ToList();

            //var g = employeeList.GroupBy(g => g.departmentId).SelectMany(s => s.EmployeeName).ToList();

            //var g = employeeList.GroupBy(g => g.departmentId).ToList();

            //List<string> list = new List<string>(); 
            //foreach (var item in g)
            //{
            //    string name = item.Select(s => s.EmployeeName).ToString();  
            //    list.Add(name);
            //}

            var g = employeeList.GroupBy(emp => emp.departmentId).ToList();

            List<string> list = new List<string>();
            foreach (var group in g)
            {
                foreach (var emp in group)
                {
                    list.Add(emp.EmployeeName);
                }
            }

            /*  John, Bill, Ron
                 Moin, Ram
            */

            var groupedNames = employeeList
                .GroupBy(emp => emp.departmentId)
                .Select(g => string.Join(", ", g.Select(emp => emp.EmployeeName)))
                .ToList();


            /* 
             Department 1:
               John (Age: 22)
               Bill (Age: 30)
               Ron (Age: 45)

            Department 2:
               Moin (Age: 21)
               Ram (Age: 26)

             */
            var avgAgePerDept = employeeList
                                   .GroupBy(e => e.departmentId)
                                   .Select(g => new {
                                           DeptId = g.Key,
                                           AvgAge = g.Average(e => e.Age)
                                       });

            var groupedEmployees = employeeList
                                    .GroupBy(emp => emp.departmentId)
                                    .Select(g => new
                                        {
                                            DepartmentId = g.Key,
                                            Employees = g.ToList()
                                        });

            foreach (var group in groupedEmployees)
            {
                Console.WriteLine($"Department {group.DepartmentId}:");
                foreach (var emp in group.Employees)
                {
                    Console.WriteLine($"   {emp.EmployeeName} (Age: {emp.Age})");
                }
            }

            #endregion

            #region Advance Questions
            //1️ Inner Join: Employees with their Departments

            var empWithDept = employeeList
                 .Join(departmentList,
                  e => e.departmentId,
                  d => d.DepartmentId,
                  (e, d) => new { e.EmployeeName, d.DepartmentName });

            // 2. Group Join: Departments with their Employees
            var deptWithEmployees = departmentList
              .GroupJoin(employeeList,
               d => d.DepartmentId,
               e => e.departmentId,
               (d, employees) => new { d.DepartmentName, Employees = employees });

            //foreach (var dept in deptWithEmployees)
            //{
            //    Console.WriteLine($"{dept.DepartmentName}:");
            //    foreach (var emp in dept.Employees)
            //    {
            //        Console.WriteLine($"   {emp.EmployeeName}");
            //    }
            //}

            //3. SelectMany: Flattening collections

            var skills = new List<(int EmpId, string Skill)> {
                (1, "C#"), (1, "SQL"),
                (2, "Java"), (3, "React"),
                (4, "Azure"), (5, "Leadership"), (5, "C#")
            };

            var empSkills = employeeList
                .SelectMany(e => skills.Where(s => s.EmpId == e.EmployeeID),
                            (e, s) => new { e.EmployeeName, s.Skill });

            foreach (var es in empSkills)
            {
                Console.WriteLine($"{es.EmployeeName} - {es.Skill}");
            }

            //4.Aggregate: Get total sum of ages
            int totalAge = employeeList.Aggregate(0, (sum, e) => sum + e.Age);
            Console.WriteLine($"Total Age = {totalAge}");

            //5. Distinct: Get distinct department IDs
            var deptIds = employeeList
            .Select(e => e.departmentId)
            .Distinct();

            Console.WriteLine(string.Join(", ", deptIds));


            //6. Skip & Take: Pagination Example
            var page2 = employeeList
            .OrderBy(e => e.EmployeeID)
            .Skip(2)
            .Take(2);

            foreach (var emp in page2)
            {
                Console.WriteLine(emp.EmployeeName);
            }

            // 7. GroupBy with Aggregates: Average age per department

            //var avgAgePerDept = employeeList
            //.GroupBy(e => e.departmentId)
            //.Select(g => new {
            //    DeptId = g.Key,
            //    AvgAge = g.Average(e => e.Age)
            //});

            foreach (var dept in avgAgePerDept)
            {
                Console.WriteLine($"Dept {dept.DeptId} - Avg Age: {dept.AvgAge}");
            }


            #endregion
        }
    }

    
}
