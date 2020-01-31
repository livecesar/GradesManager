CREATE TABLE [dbo].[Student]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [DNI] VARCHAR(50) NULL, 
    [FirstName] VARCHAR(50) NULL, 
    [SecondName] VARCHAR(50) NOT NULL, 
    [FirstLastName] VARCHAR(50) NULL, 
    [SecondLastName] VARCHAR(50) NOT NULL
)
