using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Hex
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private bool ConvertToBINCheckbox(char val)
        {
            bool result = false;
            if (val == '1') result = true;
            return result;
        }

        private void chbox_Click(object sender, EventArgs e)
        {
            checkBoxLogic();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < 16; i++)
            {
                if (((CheckBox)Controls["chbox" + (i).ToString()]).Checked == true)
                    ((CheckBox)Controls["chbox" + (i).ToString()]).Checked = false;
                else
                    ((CheckBox)Controls["chbox" + (i).ToString()]).Checked = true;
            }
            checkBoxLogic();
        }

        private void checkBoxLogic()
        {
            List<int> list = new List<int>();
            CheckBox[] checkBoxes = new CheckBox[] { chbox0, chbox1, chbox2, chbox3, chbox4, chbox5, chbox6, chbox7, chbox8, chbox9, chbox10, chbox11, chbox12, chbox13, chbox14, chbox15 };

            for (int i = 0; i < checkBoxes.Length; i++)
            {
                if (checkBoxes[i].Checked)
                    list.Add(1);
                else
                    list.Add(0);
            }
            list.Reverse(); // Переворачиваем строку, чтобы она была справа налево.

            // Обрезаем нули в начале строки
            string auxStr1 = string.Join("", list.ToArray());
            string auxStr2 = "";
            if (auxStr1.IndexOf('1') != -1)
            {
                int indexOfOne = auxStr1.IndexOf('1'); // поиск первой единицы в строке (поиск идет слева на право)
                auxStr2 = auxStr1.Substring(indexOfOne);

            } else auxStr2 = "0";
            // 

            tbBin.Text = auxStr2;
            tbDec.Text = Convert.ToInt32(tbBin.Text, 2).ToString();
            tbHex.Text = Convert.ToString(int.Parse(tbDec.Text), 16);   // DEC -> HEX
        }

        private void tbDec_KeyUp(object sender, KeyEventArgs e)
        {
            string decText = tbDec.Text;
            if (decText != String.Empty)
            {
                int i = Convert.ToInt32(decText);
                if (i <= 65535)
                {
                    tbBin.Text = Convert.ToString(i, 2);    // DEC -> BIN
                    tbHex.Text = Convert.ToString(i, 16);   // DEC -> HEX

                    // Сброс всех чекбоксов
                    foreach (CheckBox cb in this.Controls.OfType<CheckBox>())
                    {
                        cb.Checked = false;
                    }

                    // Выделение чекбоксов в соответствии с двоичной строкой
                    int k = 0;
                    for (int j = tbBin.Text.Length - 1; j >= 0; j--)
                    {
                        if (ConvertToBINCheckbox(tbBin.Text[j])) ((CheckBox)Controls["chbox" + (k).ToString()]).Checked = true;
                        k++;
                    }

                }
                else
                {
                    tbDec.Text = "65535";
                }
            }
        }

        private void tbHex_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                TextBoxCopy(sender);
            }
        }

        // Копирование текста ТекстБокса при нажатии мышкой
        private void TextBoxCopy(object sender)
        {
            Clipboard.Clear();
            
            string source = ((Control)sender).Name;
            switch (source)
            {
                case "tbHex":
                    Clipboard.SetText(tbHex.Text);
                    tbHex.SelectionStart = 0;
                    tbHex.SelectionLength = tbHex.Text.Length;
                    tbHex.Focus();
                    break;
                case "tbBin":
                    Clipboard.SetText(tbBin.Text);
                    tbBin.SelectionStart = 0;
                    tbBin.SelectionLength = tbBin.Text.Length;
                    tbBin.Focus();
                    break;
                case "tbDec":
                    Clipboard.SetText(tbDec.Text);
                    tbDec.SelectionStart = 0;
                    tbDec.SelectionLength = tbDec.Text.Length;
                    tbDec.Focus();
                    break;
                default:
                    break;
            }

            TextBox TB = (TextBox)sender;
            int VisibleTime = 1000;  //in milliseconds
            ToolTip tt = new ToolTip();
            tt.Show("Скопировано", TB, 30, 20, VisibleTime);
        }

        private void tbBin_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                TextBoxCopy(sender);
            }
        }

        private void tbDec_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                TextBoxCopy(sender);
            }
        }

        private void tbHex_KeyUp(object sender, KeyEventArgs e)
        {
            string hexText = tbHex.Text;
            if (hexText != String.Empty)
            {
                int i = Convert.ToInt32(hexText, 16); // HEX -> DEC
                if (i <= 65535)
                {
                    tbDec.Text = Convert.ToInt32(hexText, 16).ToString();
                    tbBin.Text = Convert.ToString(i, 2);    // DEC -> BIN

                    // Сброс всех чекбоксов
                    foreach (CheckBox cb in this.Controls.OfType<CheckBox>())
                    {
                        cb.Checked = false;
                    }

                    // Выделение чекбоксов в соответствии с двоичной строкой
                    int k = 0;
                    for (int j = tbBin.Text.Length - 1; j >= 0; j--)
                    {
                        if (ConvertToBINCheckbox(tbBin.Text[j])) ((CheckBox)Controls["chbox" + (k).ToString()]).Checked = true;
                        k++;
                    }

                }
            }
        }

        private void tbDec_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 48 - это 0
            // 49 - это 1
            // 50 - это 2
            // 51 - это 3
            // 52 - это 4
            // 53 - это 5
            // 54 - это 6
            // 55 - это 7
            // 56 - это 8
            // 57 - это 9

            char number = e.KeyChar;
            if ((number <= 7 || number >= 9) && (number <= 47 || number >= 58)) //цифры
            {
                e.Handled = true;

            }
        }

        private void tbBin_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 48 - это 0
            // 49 - это 1
            char number = e.KeyChar;
            if ((number <= 7 || number >= 9) && (number <= 47 || number >= 50)) //цифры
            {
                e.Handled = true;
            }
        }

        private void tbHex_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 8 - это кнопка Backspace
            //
            // 48 - это 0
            // 49 - это 1
            // 50 - это 2
            // 51 - это 3
            // 52 - это 4
            // 53 - это 5
            // 54 - это 6
            // 55 - это 7
            // 56 - это 8
            // 57 - это 9
            // 
            // 65 - A
            // 66 - B
            // 67 - C
            // 68 - D
            // 69 - E
            // 70 - F
            // 
            // 97 - a
            // 98 - b
            // 99 - c
            // 100 - d
            // 101 - e
            // 102 - f

            char number = e.KeyChar;
            if ((number <= 7 || number >= 9) && (number <= 47 || number >= 58) && (number <= 64 || number >= 71) && (number <= 96 || number >= 103)) //цифры
            {
                e.Handled = true;
            }
        }

        private void lblReset_Click(object sender, EventArgs e)
        {
            // Сброс всех чекбоксов
            foreach (CheckBox cb in this.Controls.OfType<CheckBox>())
            {
                cb.Checked = false;
            }
            // Сброс всех текстовых полей
            tbDec.Text = "0";
            tbHex.Text = "0";
            tbBin.Text = "0";
        }

        private void tbBin_KeyUp(object sender, KeyEventArgs e)
        {
            string binText = tbBin.Text;
            if (binText != String.Empty)
            {
                int i = Convert.ToInt32(binText, 2); // BIN -> DEC
                if (i <= 65535)
                {
                    tbDec.Text = i.ToString();
                    tbHex.Text = Convert.ToString(int.Parse(i.ToString()), 16);   // DEC -> HEX

                    // Сброс всех чекбоксов
                    foreach (CheckBox cb in this.Controls.OfType<CheckBox>())
                    {
                        cb.Checked = false;
                    }

                    // Выделение чекбоксов в соответствии с двоичной строкой
                    int k = 0;
                    for (int j = tbBin.Text.Length - 1; j >= 0; j--)
                    {
                        if (ConvertToBINCheckbox(tbBin.Text[j])) ((CheckBox)Controls["chbox" + (k).ToString()]).Checked = true;
                        k++;
                    }

                }
            }
        }

        private void lblOnTop_Click(object sender, EventArgs e)
        {
            TopMost = !TopMost;
            if(TopMost) lblOnTop.BackColor = Color.LightSeaGreen;
            if(!TopMost) lblOnTop.BackColor = Color.DarkGray;
        }
    }
}
