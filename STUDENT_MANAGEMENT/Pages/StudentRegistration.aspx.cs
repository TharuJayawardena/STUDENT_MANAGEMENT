using STUDENT_MANAGEMENT.Data;
using STUDENT_MANAGEMENT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace STUDENT_MANAGEMENT.Pages
{
	public partial class StudentRegistration : System.Web.UI.Page
	{

		private DataAccess _dataAccess;
		private object student;

		public StudentRegistration()
		{
			_dataAccess = new DataAccess();
		}
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void AddStudentBtn_Click(object sender, EventArgs e)
		{
			try
			{
				// get user entered data
				var student = new Student
				{
					StudentId = TxtStudentId.Text,
					FirstName = TxtFirstName.Text,
					LastName = TxtLastName.Text,
					Address = TxtAddress.Text,
					Gender = DropDownGender.Text,
					NIC = TxtNic.Text,
					Email = TxtEmail.Text,
					Nationality = TxtNationality.Text,
					ContactNo = TxtContactNo.Text,
					
				};


				_dataAccess.AddStudent(student);
			}
			catch (Exception)
			{

				throw;
			}
		}
	}
}