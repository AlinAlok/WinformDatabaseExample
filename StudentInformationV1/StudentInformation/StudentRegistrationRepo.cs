using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformation
{
    public class StudentRegistrationRepo
    {
        public static DataAccess DataAccess;
        public StudentRegistrationRepo()
        {
            if (DataAccess==null)
            {
                DataAccess = new DataAccess();
            }
        }

        public int InsertStudent(string FullName, string UserName, string Password, string Email, string PhoneNumber,string Address,DateTime DateOfBirth,string hobbies,string gender,string imagePath)
        {
            String _insertQuery =
                "INSERT INTO StudentInfo (FullName,Username,Password,Email,Phone,Address,DateOfBirth,Gender,Hobbies,imageLocation) " +
                "VALUES (@FullName,@Username,@Password,@Email,@Phone,@Address,@DateOfBirth,@Gender,@Hobbies,@imageLocation)";

            SqlCommand cmd = DataAccess.GetCommand(_insertQuery);

            cmd.Parameters.Add("@FullName", FullName);
            cmd.Parameters.Add("@Username", UserName);
            cmd.Parameters.Add("@Password", Password);
            cmd.Parameters.Add("@Email", Email);
            cmd.Parameters.Add("@Phone", PhoneNumber);
            cmd.Parameters.Add("@Address", Address);
            cmd.Parameters.Add("@DateOfBirth", DateOfBirth);
            cmd.Parameters.Add("@imageLocation", imagePath);
            cmd.Parameters.Add("@Hobbies", hobbies);
            cmd.Parameters.Add("@Gender", gender);
            return DataAccess.ExecuteNonQuery(cmd);
        }

        public int UpdateStudent(int id, string FullName, string UserName, string Password, string Email, string PhoneNumber, string Address, DateTime DateOfBirth, string hobbies, string gender, string imagePath)
        {
            String _insertQuery =
                "UPDATE StudentInfo SET FullName=@FullName,Username=@Username,Password=@Password,Email=@Email,Phone=@Phone,Address=@Address,DateOfBirth=@DateOfBirth,Gender=@Gender,Hobbies=@Hobbies,imageLocation=@imageLocation where id=@id";
            
            SqlCommand cmd = DataAccess.GetCommand(_insertQuery);

            cmd.Parameters.Add("@id", id);
            cmd.Parameters.Add("@FullName", FullName);
            cmd.Parameters.Add("@Username", UserName);
            cmd.Parameters.Add("@Password", Password);
            cmd.Parameters.Add("@Email", Email);
            cmd.Parameters.Add("@Phone", PhoneNumber);
            cmd.Parameters.Add("@Address", Address);
            cmd.Parameters.Add("@DateOfBirth", DateOfBirth);
            cmd.Parameters.Add("@imageLocation", imagePath);
            cmd.Parameters.Add("@Hobbies", hobbies);
            cmd.Parameters.Add("@Gender", gender);
            return DataAccess.ExecuteNonQuery(cmd);
        }

        public DataTable GetStudentByID(int StudentId)
        {
            String query = "select * from StudentInfo where id=@id";
            
            SqlCommand cmd = DataAccess.GetCommand(query);
            cmd.Parameters.Add("@id", StudentId);
            return DataAccess.Execute(cmd);
        }

        public bool IsStudentExist(int StudentId)
        {
            String query = "select * from StudentInfo where id=@id";
            
            SqlCommand cmd = DataAccess.GetCommand(query);
            cmd.Parameters.Add("@id", StudentId);
            DataTable dt = DataAccess.Execute(cmd);
            if (dt.Rows.Count>0)
            {
                return true;
            }
            return false;
        }
        public DataTable GetAllStudent()
        {
            String query = "select * from StudentInfo";
            
            return DataAccess.Execute(query);
        }

    }
}
