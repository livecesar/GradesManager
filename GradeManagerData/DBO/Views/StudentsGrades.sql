CREATE VIEW [dbo].[StudentsGrades]
	AS 
	SELECT S.*, G.GradeValue 
	FROM Student S
	inner join Grade G
	ON S.Id = G.Id_Student
