CREATE TABLE [dbo].[Measurements]
(
	[MeasurementId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Gender] NCHAR(10) NULL, 
    [Bust] FLOAT NULL, 
    [Neck] FLOAT NULL, 
    [Waist] FLOAT NULL, 
    [Hip] FLOAT NULL, 
    [Shoulder] FLOAT NULL, 
    [Arm] FLOAT NULL, 
    [Leg] FLOAT NULL, 
    [OrderId] INT NOT NULL,
    CONSTRAINT [FK_Measurements_Order] FOREIGN KEY ([OrderId]) REFERENCES [Orders]([OrderId]) ON DELETE CASCADE
     )
