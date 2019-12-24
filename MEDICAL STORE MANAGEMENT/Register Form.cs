using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEDICAL_STORE_MANAGEMENT
{
    public partial class Registration : Form
    {
        
        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void Button_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button_Register_Click(object sender, EventArgs e)
        {
            Reg _Reg = new Reg();
            Data_Access _data = new Data_Access();
            
            _Reg.firstName = textBox_fname.Text;
            _Reg.lastName = textBox_lName.Text;
            _Reg.mail = textBox_mail.Text;
            _Reg.password = textBox_password.Text;
            _Reg.contact = textBox_contact.Text;
            _Reg.address = textBox_address.Text;
            
            bool success = _data.Insert(_Reg);
            if (success == true)
            {
                MessageBox.Show("Registration Successfull!!");

            }
            else { MessageBox.Show("Faild to Register!!"); }
        }
    }
}
