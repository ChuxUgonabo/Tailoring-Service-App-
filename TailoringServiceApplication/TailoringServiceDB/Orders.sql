CREATE TABLE [dbo].[Orders] (
    [OrderId]        INT           IDENTITY (1, 1) NOT NULL,
    [CustomerName]   NVARCHAR (50) NOT NULL,
    [CustomerNumber] NVARCHAR (50) NOT NULL,
    [Article]        NVARCHAR (50) NOT NULL,
    [Service]        NVARCHAR (50) NOT NULL,
    [Satus]          NVARCHAR (50) NOT NULL,
    [Comment]        NVARCHAR (50) NOT NULL,
    [EmployeeId]     INT           NOT NULL,
    [PickUpDate]     NVARCHAR (50) NOT NULL,
    [CreateDate]     NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([OrderId] ASC),
    CONSTRAINT [FK_Orders_Employees] FOREIGN KEY ([EmployeeId]) REFERENCES [dbo].[Employees] ([EmployeeId]) ON UPDATE CASCADE
);

