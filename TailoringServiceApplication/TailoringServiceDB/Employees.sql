CREATE TABLE [dbo].[Employees]
(
	[EmployeeId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [EmployeeName] NVARCHAR(50) NOT NULL, 
    [RoleType] NVARCHAR(50) NOT NULL
)
