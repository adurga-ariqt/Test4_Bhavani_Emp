// See https://aka.ms/new-console-template for more information
using Test4_Bhavani_Emp;

Console.WriteLine("Hello, World!");

DB_Connection_Employee objDBConnection = new DB_Connection_Employee();
objDBConnection.DBconnection();





EditEmployee objEditEmployee = new EditEmployee();
objEditEmployee.UpdateEmployeeData();
objEditEmployee.DeleteEmployeeData();