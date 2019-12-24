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
    public partial class Admin_Form : Form
    {
        public Admin_Form()
        {
            InitializeComponent();
        }

        private void Button_addPro_Click(object sender, EventArgs e)
        {
            Product __Pro = new Product();
            __Pro.Show();
        }

        private void Button_pro_Click(object sender, EventArgs e)
        {
            Product_List _proList = new Product_List();
            _proList.Show();
        }

        private void Button_req_Click(object sender, EventArgs e)
        {

            Request _req = new Request();
            _req.Show();
        }
    }
}
