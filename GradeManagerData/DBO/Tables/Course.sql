﻿CREATE TABLE [dbo].[Course]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [CourseCode] NVARCHAR(10) NOT NULL, 
    [CourseName] NVARCHAR(50) NOT NULL
)
