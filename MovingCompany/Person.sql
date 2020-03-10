CREATE TABLE [dbo].[Person]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Mail] VARCHAR(50) NOT NULL UNIQUE, 
    [PhoneNumber] VARCHAR(50) NULL, 
    [Name] VARCHAR(50) NULL
)
