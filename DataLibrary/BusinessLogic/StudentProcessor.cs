using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.BusinessLogic
{
    public static class StudentProcessor
    {
        public static int CreateStudent(string firstName, 
                                string secondName, string firstLastName, string secondLastName, string dni)
        {
            StudentModel data = new StudentModel
            {
                FirstName = firstName,
                SecondName = secondName,
                FirstLastName = firstLastName,
                SecondLastName = secondLastName,
                DNI = dni
            };

            string sql = @"INSERT INTO dbo.Student (FirstName, SecondName, FirstLastName, SecondLastName, DNI)
                            VALUES (@FirstName, @SecondName, @FirstLastName, @SecondLastName, @DNI)";

            return SqlDataAccess.SaveData(sql, data);

        }

        public static List<StudentModel> LoadStudents()
        {
            string sql = "SELECT * FROM dbo.Student";

            return SqlDataAccess.LoadData<StudentModel>(sql);
        }
    }
}
