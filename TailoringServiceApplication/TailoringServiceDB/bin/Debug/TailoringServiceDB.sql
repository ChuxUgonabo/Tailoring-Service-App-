﻿/*
Deployment script for TailoringService

This code was generated by a tool.
Changes to this file may cause incorrect behavior and will be lost if
the code is regenerated.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "TailoringService"
:setvar DefaultFilePrefix "TailoringService"
:setvar DefaultDataPath "C:\Users\ormas\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\"
:setvar DefaultLogPath "C:\Users\ormas\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\"

GO
:on error exit
GO
/*
Detect SQLCMD mode and disable script execution if SQLCMD mode is not supported.
To re-enable the script after enabling SQLCMD mode, execute the following:
SET NOEXEC OFF; 
*/
:setvar __IsSqlCmdEnabled "True"
GO
IF N'$(__IsSqlCmdEnabled)' NOT LIKE N'True'
    BEGIN
        PRINT N'SQLCMD mode must be enabled to successfully execute this script.';
        SET NOEXEC ON;
    END


GO
USE [$(DatabaseName)];


GO
/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
SET IDENTITY_INSERT [dbo].[Employees] ON
INSERT INTO [dbo].[Employees] ([EmployeeId], [EmployeeName], [RoleType]) VALUES (1, N'Jing', N'manager')
INSERT INTO [dbo].[Employees] ([EmployeeId], [EmployeeName], [RoleType]) VALUES (2, N'Carrie', N'tailor')
INSERT INTO [dbo].[Employees] ([EmployeeId], [EmployeeName], [RoleType]) VALUES (3, N'Gerard', N'tailor')
INSERT INTO [dbo].[Employees] ([EmployeeId], [EmployeeName], [RoleType]) VALUES (4, N'John', N'reciptionist')
SET IDENTITY_INSERT [dbo].[Employees] OFF
GO

SET IDENTITY_INSERT [dbo].[Orders] ON
INSERT INTO [dbo].[Orders] ([OrderId], [CustomerName], [CustomerNumber], [Article], [Service], [Satus], [Comment], [EmployeeId], [PickUpDate], [CreateDate]) VALUES (1, N'John', N'77677876', N'Tshirt', N'repair', N'new', N'no comments',2,  N'Tshirt',  N'Tshirt')
INSERT INTO [dbo].[Orders] ([OrderId], [CustomerName], [CustomerNumber], [Article], [Service], [Satus], [Comment], [EmployeeId], [PickUpDate], [CreateDate]) VALUES (2, N'Gerard', N'776755', N'pant', N'alteration', N'new', N'no comments',3,  N'Tshirt', N'Tshirt')
INSERT INTO [dbo].[Orders] ([OrderId], [CustomerName], [CustomerNumber], [Article], [Service], [Satus], [Comment], [EmployeeId], [PickUpDate], [CreateDate]) VALUES (3, N'Carrie', N'7767666', N'hoodie', N'newClothing', N'new', N'no comments',3,  N'Tshirt',  N'Tshirt')
SET IDENTITY_INSERT [dbo].[Orders] OFF
GO



SET IDENTITY_INSERT [dbo].[Bills] ON
INSERT INTO [dbo].[Bills] ([BillId], [Amount], [Payment], [Status], [OrderId]) VALUES (1, 20, N'Cash', 0, 1)
INSERT INTO [dbo].[Bills] ([BillId], [Amount], [Payment], [Status], [OrderId]) VALUES (2, 50, N'Credit', 0, 2)
INSERT INTO [dbo].[Bills] ([BillId], [Amount], [Payment], [Status], [OrderId]) VALUES (3, 200, N'ApplePay', 0, 3)

SET IDENTITY_INSERT [dbo].[Bills] OFF
GO

SET IDENTITY_INSERT [dbo].[Measurements] ON
INSERT INTO [dbo].[Measurements] ([MeasurementId], [Gender], [Bust], [Neck], [Waist], [Hip], [Shoulder], [Arm], [Leg], [OrderId]) VALUES (1, 'female',  18.5, 18.5, 18.5, 18.5, 18.5, 18.5, 18.5, 1)
INSERT INTO [dbo].[Measurements] ([MeasurementId], [Gender], [Bust], [Neck], [Waist], [Hip], [Shoulder], [Arm], [Leg], [OrderId]) VALUES (2, 'female',  28.5, 28.5, 18.5, 28.5, 28.5, 28.5, 28.5, 2)
INSERT INTO [dbo].[Measurements] ([MeasurementId], [Gender], [Bust], [Neck], [Waist], [Hip], [Shoulder], [Arm], [Leg], [OrderId]) VALUES (3, 'female',  38.5, 38.5, 38.5, 38.5, 38.5, 38.5, 38.5, 3)

SET IDENTITY_INSERT [dbo].[Measurements] OFF
GO

GO

GO
PRINT N'Update complete.';


GO
