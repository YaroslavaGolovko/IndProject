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
using System.Text.RegularExpressions;
using LibraryMethods;

namespace _4_Головко_ИндПроектОАиП
{
    public partial class FormOrder : Form
    {
        public FormOrder()
        {
            InitializeComponent();
            Methods.SetComboBox("DeliveryMethod.txt", cboDeliveryMethod);
            Methods.SetComboBox("Station.txt", cboStation);
            Methods.SetComboBox("Street.txt", cboStreet);
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            double sum = 0;
            double sum1 = 0;
            sum = Methods.CountSum(sum, cbPizzaCheese, 600, cbPizzaMargarita, 378, cbPizzaMeat, 640);
            sum = Methods.CountSum(sum, cbPizzaHawaiian, 420, cbPizzaVegetarian, 415, cbPizzaSeafood, 615);
            sum = Methods.CountSum(sum, cbCocaCola, 89, cbSprite, 75, cbLipton, 79);
            sum = Methods.CountSum(sum, cbDonut,100, cbCheesecake,130, cbRaspberryCheesecake, 148);
            if (lSum.Text == "")
            {
                sum1 = sum;
                lSum.Text = Convert.ToString(Math.Round(sum, 2)) + " руб." + lSum.Text;
            }
            if (sum!=sum1)
            {
                lSum.Text = "";
                lSum.Text = Convert.ToString(Math.Round(sum, 2)) + " руб.";
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (lSum.Text == "" || lSum.Text == "0 руб.")
            { MessageBox.Show("Не выбраны позиции для заказа или не подсчитана сумма заказа!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else
            {
                if (tbName.Text == "" || tbPhone.Text == "" || cboDeliveryMethod.Text == "")
                { MessageBox.Show("Введены не все данные для оформления заказа!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                else
                {
                    if ((cboStreet.Text == "" || tbHome.Text == "") && cboStation.Text == "")
                    { MessageBox.Show("Введены не все данные для оформления получения заказа!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    else
                    {
                        if (Methods.ValidFound(tbName.Text, @"[а-яА-я]") && Methods.ValidFound(tbPhone.Text, @"[0-9]"))
                        {
                            MessageBox.Show("Заказ успешно оформлен!", "Готово!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Methods.SaveFile("Чек.txt", $"\nКем заказан: {tbName.Text}.\nНомер телефона: {tbPhone.Text}.\nСпособ получения: {cboDeliveryMethod.Text}Заказ на сумму: {lSum.Text}");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Проверьте правильность введенных данных!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void btnPromoCode_Click(object sender, EventArgs e)
        {
            string input = tbPromoCode.Text;
            Methods.GetPromoCode(input);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
