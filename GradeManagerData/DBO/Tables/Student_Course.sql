CREATE TABLE [dbo].[Student_Course]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Id_Student] INT NOT NULL, 
    [Id_Course] INT NOT NULL, 
    CONSTRAINT [FK_Student] FOREIGN KEY (Id_Student) REFERENCES [Student]([id]), 
    CONSTRAINT [FK_Course] FOREIGN KEY (Id_Course) REFERENCES [Course]([id])
)
