CREATE TABLE [dbo].[Orders]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [WorkType] VARCHAR(50) NOT NULL, 
    [From] VARCHAR(50) NULL, 
    [To] VARCHAR(50) NOT NULL, 
    [Date] DATETIME NOT NULL, 
    [PersonId] INT NOT NULL, 
    [Note] VARCHAR(50) NULL, 
    CONSTRAINT [FK_Orders_ToTable] FOREIGN KEY ([PersonId]) REFERENCES [dbo].[Person]([Id])
)
