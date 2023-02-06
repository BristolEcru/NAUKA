using ConsoleApp1;


Employee emp1 = new Employee(" Michał ", " Adamski ", 40);
Employee emp2 = new Employee(" Ewa ", " Myśliwiec ", 30);
Employee emp3 = new Employee(" Radek ", " Duski ", 33);

List<Employee> employeesList = new List<Employee>();

employeesList.Add(emp1);
employeesList.Add(emp2);  
employeesList.Add(emp3);

int maxResult = 0;
int minResult = 1000;
Employee EmployeeWithMAXScore = new Employee(null, null, 0);
Employee EmployeeWithMINScore = new Employee(null, null, 0);
float totalOfPoints = 0;

foreach (Employee emp in employeesList)
{
    emp.AddRandomPointsToEmployee();
    emp.AddRandomPointsToEmployee();
    emp.AddRandomPointsToEmployee();

}

foreach (Employee emp in employeesList)
{
    Console.WriteLine($"{emp.Name.ToString()}:");
    emp.ShowThePointsOfEmp();

}
foreach (Employee emp in employeesList)
{
    var sumofpoints = emp.SumOfPointsOfEmployee();
    totalOfPoints += sumofpoints;

    if (sumofpoints > maxResult)
    {
        EmployeeWithMAXScore = emp;
        maxResult= sumofpoints;
    }
    if (sumofpoints < minResult)

    {
        EmployeeWithMINScore = emp;
        minResult= sumofpoints;
    }

}



Console.Write("The winner of max is: "); Console.WriteLine(EmployeeWithMAXScore.Name.ToString());
Console.Write("The winner of min is: "); Console.WriteLine(EmployeeWithMINScore.Name.ToString());
Console.WriteLine($"The average score is : {totalOfPoints/employeesList.Count:N2}");




Console.WriteLine();
