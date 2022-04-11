using STUDENT_MANAGEMENT.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.OracleClient;
using System.Linq;
using System.Web;

namespace STUDENT_MANAGEMENT.Data
{
	// only db I/O
	public class DataAccess
	{
		public string ConnectionString { get; }
		

		public DataAccess()
		{
			ConnectionString = ConfigurationManager.ConnectionStrings["localDbString"].ToString();
		}

		//get students
		public List<Student> GetStudents()
		{
			try
			{
				var students = new List<Student>();
				using (OracleConnection con = new OracleConnection(ConnectionString))
				{
					con.Open();
					using (OracleCommand command = con.CreateCommand())
					{
						command.CommandText = "SELECT * FROM STUDENT_TABLE";
						var reader = command.ExecuteReader();
						while (reader.Read())
						{
							var student = new Student()
							{
								StudentId = reader["StudentId"].ToString(),
								FirstName = reader["FirstName"].ToString(),
								LastName = reader["LastName"].ToString(),
								Address = reader["Address"].ToString(),
								Gender = reader["Gender"].ToString(),
								NIC = reader["NIC"].ToString(),
								Email = reader["Email"].ToString(),
								Nationality = reader["Nationality"].ToString(),
								ContactNo = reader["ContactNo"].ToString()

							};

							students.Add(student);
						}
					}
				}
				return students;
			}
			catch (Exception ex)
			{

				throw;
			}
		}

		public string GetStudentContactNoById(string sid) 
		{
			try
			{
				
				using (OracleConnection con = new OracleConnection(ConnectionString))
				{
					con.Open();
					using (OracleCommand command = con.CreateCommand())
					{
						command.CommandText = $"SELECT ContactNo FROM STUDENT_TABLE WHERE StudentId = '{sid}' ";
						var reader = command.ExecuteReader();
						while (reader.Read())
						{
							return reader["ContactNo"].ToString();
						
						}
					}
				}

				throw new ArgumentException("Invalid student Id");
			}
			catch (Exception ex)
			{

				throw;
			}
		}

		public void AddStudent(Student student)
		{
			try
			{
				using (OracleConnection con = new OracleConnection(ConnectionString))
				{
					
					con.Open();
					using (OracleCommand cmd = con.CreateCommand())
					{
						
						cmd.CommandText = "Insert into Student_Table(StudentId,FirstName,LastName,Address,Gender,NIC,Email,Nationality,ContactNo)" +
							"Values(:StudentId,:FirstName,:LastName,:Address,:Gender,:NIC,:Email,:Nationality,:ContactNo)";


						cmd.Parameters.AddWithValue("StudentId", student.StudentId);
						cmd.Parameters.AddWithValue("FirstName", student.FirstName);
						cmd.Parameters.AddWithValue("LastName", student.LastName);
						cmd.Parameters.AddWithValue("Address", student.Address);
						cmd.Parameters.AddWithValue("Gender", student.Gender);
						cmd.Parameters.AddWithValue("NIC", student.NIC);
						cmd.Parameters.AddWithValue("Email", student.Email);
						cmd.Parameters.AddWithValue("Nationality", student.Nationality);
						cmd.Parameters.AddWithValue("ContactNo", student.ContactNo);

						cmd.ExecuteNonQuery();
					}
				}
			}
			catch (Exception ex)
			{
				throw;
			}

		}

		public void EditStudent(Student student)
		{
			try
			{
				using (OracleConnection con = new OracleConnection(ConnectionString))
				{
					con.Open();
					using (OracleCommand cmd = con.CreateCommand())
					{
						cmd.CommandText = "Update Student_Table " +
							"Set FirstName=:FirstName," +
							"LastName=:LastName," +
							"Address=:Address," +
							"Gender=:Gender," +
							"NIC=:NIC," +
							"Email=:Email," +
							"Nationality=:Nationality," +
							"ContactNo=:ContactNo WHERE StudentId=:StudentId";


						cmd.Parameters.AddWithValue("StudentId", student.StudentId);
						cmd.Parameters.AddWithValue("FirstName", student.FirstName);
						cmd.Parameters.AddWithValue("LastName", student.LastName);
						cmd.Parameters.AddWithValue("Address", student.Address);
						cmd.Parameters.AddWithValue("Gender", student.Gender);
						cmd.Parameters.AddWithValue("NIC", student.NIC);
						cmd.Parameters.AddWithValue("Email", student.Email);
						cmd.Parameters.AddWithValue("Nationality", student.Nationality);
						cmd.Parameters.AddWithValue("ContactNo", student.ContactNo);
						cmd.ExecuteNonQuery();
					}
				}
			}
			catch
			{
				throw;
			}
		}

		public void DeleteStudent(string studentId)
		{
			try
			{
				using (OracleConnection con = new OracleConnection(ConnectionString))
				{
					con.Open();
					using (OracleCommand cmd = con.CreateCommand())
					{
						cmd.CommandText = $"Delete from Student_Table where StudentId='{studentId}'";
						cmd.ExecuteNonQuery();
					}
				}
			}
			catch
			{
				throw;
			}
		}
	}
}