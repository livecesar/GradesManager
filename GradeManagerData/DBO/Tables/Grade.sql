﻿CREATE TABLE [dbo].[Grade]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [GradeValue] FLOAT NOT NULL, 
    [Id_Student] INT NOT NULL,
    CONSTRAINT [FK_STUDENT_GRADE] FOREIGN KEY (Id_Student) REFERENCES [STUDENT]([id])
)
