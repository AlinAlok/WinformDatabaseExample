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
    public partial class Customer_Form : Form
    {
        public Customer_Form()
        {
            InitializeComponent();
        }

        private void Button_shopPro_Click(object sender, EventArgs e)
        {
            Product_List _List = new Product_List();
            _List.Show();
        }

        private void Button_proCart_Click(object sender, EventArgs e)
        {
            Shoping_Cart __cart = new Shoping_Cart();
            __cart.Show();
        }
    }
}
