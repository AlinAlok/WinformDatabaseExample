using System;
using System.Data;
using System.Windows.Forms;

namespace StudentInformation
{
    public partial class StudentRegistration : Form
    {
        public int StudentId { get; set; }
        private StudentRegistrationRepo _studentRegistrationRepo;
        public StudentRegistration()
        {
            InitializeComponent();
            _studentRegistrationRepo = new StudentRegistrationRepo();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            string Gender = "";
            if (rbGenderFemale.Checked)
            {

                Gender = rbGenderFemale.Text;
            }
            else if (rbGenderMale.Checked)
            {
                Gender = rbGenderMale.Text;
            }

            string hobbies = "";
            if (cbPainting.Checked)
            {
                hobbies = cbPainting.Text;
            }

            if (CbDance.Checked)
            {
                if (string.IsNullOrEmpty(hobbies))
                {
                    hobbies = CbDance.Text;
                }
                else
                {
                    hobbies += "," + CbDance.Text;
                }
            }

            var inserted = 0;
            if (StudentId>0)
            {
                inserted = _studentRegistrationRepo.UpdateStudent(StudentId,tbFullName.Text, tbUserName.Text, tbPassword.Text,
                    tbEmail.Text,
                    tbPhoneNumber.Text, tbAddress.Text, mcDOB.SelectionRange.Start.Date, hobbies, Gender,
                    txtImagePath.Text);    
            }
            else
            {
                inserted = _studentRegistrationRepo.InsertStudent(tbFullName.Text, tbUserName.Text, tbPassword.Text,
                    tbEmail.Text,
                    tbPhoneNumber.Text, tbAddress.Text, mcDOB.SelectionRange.Start.Date, hobbies, Gender,
                    txtImagePath.Text);
            }
            

            if (inserted > 0)
            {
                MessageBox.Show("Saved Successfully");
            }
            else
            {
                MessageBox.Show("Some thing went wrong");
            }

        }

        private void tbFullName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbFullName.Text))
            {
                tbFullName.Focus();
                //MessageBox.Show("Full Name can not be empty");
                lblFullnameError.Text = "Full Name can not be empty";

            }
            else if (tbFullName.Text.Length < 3)
            {
                tbFullName.Focus();
                //MessageBox.Show("Full name should not be less than 3 charecter");
                lblFullnameError.Text = "Full name should not be less than 3 charecter";
                
            }
            else
            {
                lblFullnameError.Text = "";
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            var rs=new RegisteredStudents(this);
            rs.Show();
            this.Hide();
        }


        private void BrowesImage_Click(object sender, EventArgs e)
        {
            FileDialog fileDialog = new OpenFileDialog();
            fileDialog.ShowDialog();
            txtImagePath.Text = fileDialog.FileName;
            pbProfilePic.ImageLocation = fileDialog.FileName;
            pbProfilePic.SizeMode = PictureBoxSizeMode.StretchImage;
        }


        private void setRegistrationFormByStudentId(int studentId)
        {
            if (_studentRegistrationRepo.IsStudentExist(StudentId))
            {
                DataTable sDTable = _studentRegistrationRepo.GetStudentByID(StudentId);
                tbFullName.Text = sDTable.Rows[0].Field<string>(1).Trim();
                tbUserName.Text = sDTable.Rows[0].Field<string>(2).Trim();
                tbPassword.Text = sDTable.Rows[0].Field<string>(3).Trim();
                tbEmail.Text = sDTable.Rows[0].Field<string>(4).Trim();
                tbPhoneNumber.Text = sDTable.Rows[0].Field<string>(5).Trim();
                tbAddress.Text = sDTable.Rows[0].Field<string>(6).Trim();
                mcDOB.SetDate(sDTable.Rows[0].Field<DateTime>(7));
                var Gender = sDTable.Rows[0].Field<string>(8).Trim();
                var Hobbies = sDTable.Rows[0].Field<string>(9).Trim();
                pbProfilePic.ImageLocation = sDTable.Rows[0].Field<string>(10);
                pbProfilePic.SizeMode = PictureBoxSizeMode.StretchImage;
                if (!string.IsNullOrEmpty(sDTable.Rows[0].Field<string>(10)))
                {
                    txtImagePath.Text = pbProfilePic.ImageLocation = sDTable.Rows[0].Field<string>(10).Trim();
                }

                rbGenderFemale.Checked = rbGenderMale.Checked = cbPainting.Checked = CbDance.Checked = false;
                if (Gender == rbGenderFemale.Text.Trim())
                {
                    rbGenderFemale.Checked = true;
                }
                else if (Gender == rbGenderMale.Text.Trim())
                {
                    rbGenderMale.Checked = true;
                }

                if (!string.IsNullOrEmpty(Hobbies))
                {
                    var hobbyArray = Hobbies.Split(',');
                    foreach (var hobby in hobbyArray)
                    {
                        if (hobby.Trim() == cbPainting.Text)
                        {
                            cbPainting.Checked = true;
                        }

                        if (hobbyArray.Length >= 1 && hobby.Trim() == CbDance.Text)
                        {
                            CbDance.Checked = true;
                        }
                    }
                }
            }
        }



        private void StudentRegistration_VisibleChanged(object sender, EventArgs e)
        {
            if (StudentId > 0 && Visible==true)
            {
                setRegistrationFormByStudentId(StudentId);
            }
        }



    }
}
