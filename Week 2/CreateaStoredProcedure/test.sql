USE EmployeeDB;
GO

EXEC sp_InsertEmployee 
    @FirstName = 'Alice',
    @LastName = 'Brown',
    @DepartmentID = 3,
    @Salary = 6200.00,
    @JoinDate = '2022-05-01';
GO

EXEC sp_GetEmployeesByDepartment @DepartmentID = 3;
GO

SELECT * FROM Employees;
