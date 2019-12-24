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
    public partial class Product : Form
    {
        internal object proID;
        internal object proName;
        internal object proPrice;
        internal object proQT;

        public Product()
        {
            InitializeComponent();
        }

        Pro _pro = new Pro();
        Data_Access _data = new Data_Access();


        private void Button_addPro_Click(object sender, EventArgs e)
        {
            Pro _pro = new Pro();
            Data_Access _data = new Data_Access();

            _pro.proID = textBox_proID.Text;
            _pro.proName = textBox_proName.Text;
            _pro.proPrice = textBox_proPrice.Text;
            _pro.proQT = textBox_proQT.Text;


            bool success = _data.Insert(_pro);
            if (success == true)
            {
                MessageBox.Show("Successfully Added!!");
                clear();

            }
            else { MessageBox.Show("Faild to Add Product!!"); }
            DataTable dt = _data.Select();
            dataGridViewPro.DataSource = dt;
        }
        private void Product_Load(object sender, EventArgs e)
        {
            DataTable dt = _data.Select();
            dataGridViewPro.DataSource = dt;
        }
        private void clear()
        {
            textBox_proID.Text="";
            textBox_proName.Text = "";
            textBox_proPrice.Text = "";
            textBox_proQT.Text = "";
        }

        private void Button_altPro_Click(object sender, EventArgs e)
        {
            _pro.proID = textBox_proID.Text;
            _pro.proName = textBox_proName.Text;
            _pro.proPrice = textBox_proPrice.Text;
            _pro.proQT = textBox_proQT.Text;

            bool success = _data.Update(_pro);
            if (success == true)
            {
                MessageBox.Show("Update successfull");
                clear();
            }
            else
            {
                MessageBox.Show("Failed to update");
            }
            
        }
    }
}
