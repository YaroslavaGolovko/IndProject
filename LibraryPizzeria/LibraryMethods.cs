using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace LibraryMethods
{
    public class Methods
    {
        static public void SetComboBox(string input, ComboBox comboBox)
        {
            using (StreamReader reader = new StreamReader(input, System.Text.Encoding.GetEncoding(1251)))
            {
                string str;
                while ((str = reader.ReadLine()) != null)
                {
                    comboBox.Items.Add(str + Environment.NewLine);
                }
            }
        }
        static public void SaveFile(string name, string input)
        {
            File.AppendAllText(name, input);
        }
        static public void SetPromoCode(int choice)
        {
            if (choice == 3)
            {
                MessageBox.Show("Ваш уникальный промокод: 840167 !", "Подарочный набор №3!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (choice == 2)
            {
                MessageBox.Show("Ваш уникальный промокод: 162004 !", "Подарочный набор №2!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ваш уникальный промокод: 124576 !", "Подарочный набор №1!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        static public void GetPromoCode(string input)
        {
            if (input == "124576")
            {
                MessageBox.Show("К вашему заказу добавлена бесплатная пицца Маргарита (20 см)!", "Подарочный набор №1!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (input == "162004")
            {
                MessageBox.Show("К вашему заказу добавлена бесплатная пицца 4 Сыра (20 см)!", "Подарочный набор №2!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (input == "840167")
            {
                MessageBox.Show("К вашему заказу добавлена бесплатная Мясная пицца (20 см)!", "Подарочный набор №3!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (input == "")
            {
                MessageBox.Show("Сначала заполните поле!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Промокод недействителен!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        static public bool ValidFound(string str,string input)
        {
            bool valid = true;
            foreach (char c in str)
            {
                string bfr = c.ToString();
                if (Regex.IsMatch(bfr, @input))
                {
                    valid = true;
                }
                else
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
        static public double CountSum(double sum,CheckBox checkBox1, double cost1, CheckBox checkBox2, double cost2, CheckBox checkBox3,double cost3)
        {
            if (checkBox1.Checked)
            {
                sum += cost1;
            }
            if (checkBox2.Checked)
            {
                sum += cost2;
            }
            if (checkBox3.Checked)
            {
                sum += cost3;
            }
            return sum;
        }
    }
}
