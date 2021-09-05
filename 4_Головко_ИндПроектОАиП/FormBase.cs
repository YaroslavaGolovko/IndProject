using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_Головко_ИндПроектОАиП
{
    public partial class FormBase : Form
    {
        public FormBase()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            FormOrder order = new FormOrder();
            order.Show();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            FormStock stocks = new FormStock();
            stocks.Show();
        }

        private void btnAboutUs_Click(object sender, EventArgs e)
        {
            FormAboutApp app = new FormAboutApp();
            app.Show();
        }
    }
}
