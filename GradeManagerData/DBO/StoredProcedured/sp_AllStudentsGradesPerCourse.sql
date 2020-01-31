CREATE PROCEDURE [dbo].[sp_AllStudentsGradesPerCourse]
	@COURSE int
AS
BEGIN
	SELECT S.*, G.*
	FROM Student S INNER JOIN Grade G
	ON S.Id = G.Id_Student INNER JOIN Student_Course SC
	ON S.Id = SC.Id_Student
	WHERE SC.Id_Course = @COURSE
END
