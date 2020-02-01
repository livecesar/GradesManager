CREATE TABLE [dbo].[Student]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [DNI] VARCHAR(50) NULL, 
    [FirstName] VARCHAR(50) NOT NULL, 
    [SecondName] VARCHAR(50) NULL, 
    [FirstLastName] VARCHAR(50) NOT NULL, 
    [SecondLastName] VARCHAR(50) NULL
)
