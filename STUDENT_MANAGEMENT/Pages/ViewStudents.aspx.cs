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
	public partial class ViewStudents : System.Web.UI.Page
	{
		private DataAccess _dataAccess;
		public ViewStudents()
		{
			_dataAccess = new DataAccess();
		}

		protected void Page_Load(object sender, EventArgs e)
		{
			if (!IsPostBack)
			{
				StudentGridView.DataSource = _dataAccess.GetStudents();
				StudentGridView.DataBind();
			}
			
		}

		protected void StudentGridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
		{
			StudentGridView.PageIndex = e.NewPageIndex;
			StudentGridView.DataSource = _dataAccess.GetStudents();
			StudentGridView.DataBind();
		}

		

		protected void StudentGridView_RowDeleting(object sender, GridViewDeleteEventArgs e)
		{
			GridViewRow row = (GridViewRow)StudentGridView.Rows[e.RowIndex];
			var studentId = row.Cells[0].Text;
			_dataAccess.DeleteStudent(studentId);
			StudentGridView.DataSource = _dataAccess.GetStudents();
			StudentGridView.DataBind();
		}

		protected void StudentGridView_RowEditing(object sender, GridViewEditEventArgs e)
		{
			StudentGridView.EditIndex = e.NewEditIndex;
			StudentGridView.DataSource = _dataAccess.GetStudents();
			StudentGridView.DataBind();
		}

		protected void StudentGridView_Rowview(object sender, GridViewCancelEditEventArgs e)
		{
			StudentGridView.EditIndex = -1;
			StudentGridView.DataSource = _dataAccess.GetStudents();
			StudentGridView.DataBind();
		}
		protected void StudentGridView_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
		{
			StudentGridView.EditIndex = -1;
			StudentGridView.DataSource = _dataAccess.GetStudents();
			StudentGridView.DataBind();
		}
		protected void StudentGridView_RowUpdating(object sender, GridViewUpdateEventArgs e)
		{
			// var studentId = StudentGridView.DataKeys[e.RowIndex].Value.ToString();
			GridViewRow row = StudentGridView.Rows[e.RowIndex];

			TextBox studentId = (TextBox)row.Cells[0].Controls[0];
			TextBox firstName = (TextBox)row.Cells[1].Controls[0];
			TextBox lastName = (TextBox)row.Cells[2].Controls[0];
			TextBox address = (TextBox)row.Cells[3].Controls[0];
			TextBox gender = (TextBox)row.Cells[4].Controls[0];
			TextBox nic = (TextBox)row.Cells[5].Controls[0];
			TextBox email = (TextBox)row.Cells[6].Controls[0];
			TextBox nationality = (TextBox)row.Cells[7].Controls[0];
			TextBox contactNo = (TextBox)row.Cells[8].Controls[0];







			var student = new Student
			{
				StudentId = studentId.Text,
				FirstName = firstName.Text,
				LastName = lastName.Text,
				Address = address.Text,
				Gender = gender.Text,
				NIC = nic.Text,
				Email = email.Text,
				Nationality = nationality.Text,
				ContactNo = contactNo.Text,
			};

			_dataAccess.EditStudent(student);

			

			StudentGridView.EditIndex = -1;
			StudentGridView.DataSource = _dataAccess.GetStudents();
			StudentGridView.DataBind();

		}

		
        protected void BtnOpenContactNoModel_Click(object sender, EventArgs e)
        {
			LinkButton linkbutton = (LinkButton)sender;
			GridViewRow row = (GridViewRow)linkbutton.NamingContainer;
		
			var contactNo = _dataAccess.GetStudentContactNoById(row.Cells[0].Text);
			var contactNoArr = contactNo.ToString().Split(',');

            for (int i = 0; i < contactNoArr.Length; i++)
            {
				this.CreateLabel(i);
				this.CreateTextBox(i, contactNoArr[i]);
			}
           
			ScriptManager.RegisterStartupScript(this, this.GetType(), "LaunchServerSide", "$(function() { openModal(); });", true);
		}


		private void CreateTextBox(int index, string no)
		{
			TextBox txt = new TextBox();
			txt.ID = "txtContactNoDynamic"+ index;
			txt.Text = no;
			txt.Attributes.Add("class", "form-control");
			ContactPanel.Controls.Add(txt);
	
			ContactPanel.Controls.Add(new LiteralControl("<hr/>"));

		}
		private void CreateLabel(int index)
		{
			Label ltxt = new Label();
			ltxt.ID = "labeltxt"+ index;
			ltxt.Text = "Contact No "+ index+1;
			ContactPanel.Controls.Add(ltxt); 
			ContactPanel.Controls.Add(new LiteralControl("<br/>"));

		}
	}
}