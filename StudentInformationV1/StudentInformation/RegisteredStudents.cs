using System;
using System.Data;
using System.Windows.Forms;

namespace StudentInformation
{
    public partial class RegisteredStudents : Form
    {
        private StudentRegistration studentRegistrationForm { get; set; }
        private StudentRegistrationRepo _studentRegistrationRepo;

        public RegisteredStudents(StudentRegistration _studentRegistrationForm)
        {
            _studentRegistrationRepo = new StudentRegistrationRepo();
            InitializeComponent();
            studentRegistrationForm = _studentRegistrationForm;
        }

        private void RegisteredStudents_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable _dataTable = _studentRegistrationRepo.GetAllStudent();
                gvStudentList.DataSource = _dataTable;
                gvStudentList.Rows[0].Selected = true;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            var id = gvStudentList.SelectedRows[0].Cells[0].Value;
            studentRegistrationForm.StudentId = (int)id;
            studentRegistrationForm.Show();
            this.Close();
        }

        private void gvStudentList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            gvStudentList.Rows[e.RowIndex].Selected = true; 
            var id = gvStudentList.SelectedRows[0].Cells[0].Value;
            studentRegistrationForm.StudentId = (int) id;
        }
    }
}
