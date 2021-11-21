CREATE TABLE [dbo].[Bills]
(
	[BillId] INT NOT NULL  IDENTITY, 
    [Amount] INT NOT NULL, 
    [Payment] NVARCHAR(50) NOT NULL, 
    [Status] INT NOT NULL, 
    [OrderId] INT NOT NULL, 
    PRIMARY KEY ([BillId]), 
    CONSTRAINT [FK_Bills_Orders] FOREIGN KEY ([OrderId]) REFERENCES [Orders]([OrderId]) ON DELETE CASCADE
)
