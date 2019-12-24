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
    public partial class Log_IN : Form
    {
        public Log_IN()
        {
            InitializeComponent();
        }

        private void Button_Register_Click(object sender, EventArgs e)
        {
            Registration reg = new Registration();
            reg.Show();
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Log_IN_Load(object sender, EventArgs e)
        {

        }

        private void Lbl_guestLOGIN_Click(object sender, EventArgs e)
        {
            Product_List __List = new Product_List();
            __List.Show();
        }
    }
}
