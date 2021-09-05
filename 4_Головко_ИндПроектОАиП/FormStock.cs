using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using LibraryMethods;

namespace _4_Головко_ИндПроектОАиП
{
    public partial class FormStock : Form
    {
        public FormStock()
        {
            InitializeComponent();
        }
        

        private void btnPromoCode_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int choice = rnd.Next(1, 3);
            if (tbReview.Text != "")
            {
                Methods.SaveFile("Отзыв.txt", $"\n{tbReview.Text}");
                Methods.SetPromoCode(choice);
                this.Close();
            }
            else
            {
                MessageBox.Show("Поле отзыва не заполнено!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
