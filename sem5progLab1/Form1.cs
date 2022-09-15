using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sem5progLab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((number <= 47 || number >= 58) && number != 8 && number != 44)// с 47 по 58 = цифры с 0 по 9 && 8 = backspace && 44 = ,
            {
                e.Handled = true;
            }
        }

        private void textBox1_2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((number <= 47 || number >= 58) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        private void textBox1_3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((number <= 47 || number >= 58) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        private void textBox1_4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((number <= 47 || number >= 58) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        private void textBox1_5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((number <= 47 || number >= 58) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        private void textBox2_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((number <= 47 || number >= 58) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        private void textBox2_2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((number <= 47 || number >= 58) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        private void textBox2_3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((number <= 47 || number >= 58) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        private void textBox2_4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((number <= 47 || number >= 58) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        private void textBox2_5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((number <= 47 || number >= 58) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        private void textBox3_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((number <= 47 || number >= 58) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        private void textBox3_2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((number <= 47 || number >= 58) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        private void textBox3_3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((number <= 47 || number >= 58) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        private void textBox3_4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((number <= 47 || number >= 58) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        private void textBox3_5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((number <= 47 || number >= 58) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        private void textBox4_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((number <= 47 || number >= 58) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        private void textBox4_2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((number <= 47 || number >= 58) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        private void textBox4_3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((number <= 47 || number >= 58) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        private void textBox4_4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((number <= 47 || number >= 58) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        private void textBox4_5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((number <= 47 || number >= 58) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        Matrix matrix = new Matrix();
        
        private void textBox1_1_TextChanged(object sender, EventArgs e)
        {
            matrix.array[0, 0] = Convert.ToDouble(textBox1_1.Text);
        }

        private void textBox1_2_TextChanged(object sender, EventArgs e)
        {
            matrix.array[0, 1] = Convert.ToDouble(textBox1_2.Text);
        }

        private void textBox1_3_TextChanged(object sender, EventArgs e)
        {
            matrix.array[0, 2] = Convert.ToDouble(textBox1_3.Text);
        }

        private void textBox1_4_TextChanged(object sender, EventArgs e)
        {
            matrix.array[0, 3] = Convert.ToDouble(textBox1_4.Text);
        }

        private void textBox1_5_TextChanged(object sender, EventArgs e)
        {
            matrix.array[0, 4] = Convert.ToDouble(textBox1_5.Text);
        }

        private void textBox2_1_TextChanged(object sender, EventArgs e)
        {
            matrix.array[1, 0] = Convert.ToDouble(textBox2_1.Text);
        }

        private void textBox2_2_TextChanged(object sender, EventArgs e)
        {
            matrix.array[1, 1] = Convert.ToDouble(textBox2_2.Text);
        }

        private void textBox2_3_TextChanged(object sender, EventArgs e)
        {
            matrix.array[1, 2] = Convert.ToDouble(textBox2_3.Text);
        }

        private void textBox2_4_TextChanged(object sender, EventArgs e)
        {
            matrix.array[1, 3] = Convert.ToDouble(textBox2_4.Text);
        }

        private void textBox2_5_TextChanged(object sender, EventArgs e)
        {
            matrix.array[1, 4] = Convert.ToDouble(textBox2_5.Text);
        }

        private void textBox3_1_TextChanged(object sender, EventArgs e)
        {
            matrix.array[2, 0] = Convert.ToDouble(textBox3_1.Text);
        }

        private void textBox3_2_TextChanged(object sender, EventArgs e)
        {
            matrix.array[2, 1] = Convert.ToDouble(textBox3_2.Text);
        }

        private void textBox3_3_TextChanged(object sender, EventArgs e)
        {
            matrix.array[2, 2] = Convert.ToDouble(textBox3_3.Text);
        }

        private void textBox3_4_TextChanged(object sender, EventArgs e)
        {
            matrix.array[2, 3] = Convert.ToDouble(textBox3_4.Text);
        }

        private void textBox3_5_TextChanged(object sender, EventArgs e)
        {
            matrix.array[2, 4] = Convert.ToDouble(textBox3_5.Text);
        }

        private void textBox4_1_TextChanged(object sender, EventArgs e)
        {
            matrix.array[3, 0] = Convert.ToDouble(textBox4_1.Text);
        }

        private void textBox4_2_TextChanged(object sender, EventArgs e)
        {
            matrix.array[3, 1] = Convert.ToDouble(textBox4_2.Text);
        }

        private void textBox4_3_TextChanged(object sender, EventArgs e)
        {
            matrix.array[3, 2] = Convert.ToDouble(textBox4_3.Text);
        }

        private void textBox4_4_TextChanged(object sender, EventArgs e)
        {
            matrix.array[3, 3] = Convert.ToDouble(textBox4_4.Text);
        }

        private void textBox4_5_TextChanged(object sender, EventArgs e)
        {
            matrix.array[3, 4] = Convert.ToDouble(textBox4_5.Text);
        }

        private void textBoxInsert()
        {
            textBox1_1.Text = Convert.ToString(matrix.array[0, 0]);
            textBox1_2.Text = Convert.ToString(matrix.array[0, 1]);
            textBox1_3.Text = Convert.ToString(matrix.array[0, 2]);
            textBox1_4.Text = Convert.ToString(matrix.array[0, 3]);
            textBox1_5.Text = Convert.ToString(matrix.array[0, 4]);

            textBox2_1.Text = Convert.ToString(matrix.array[1, 0]);
            textBox2_2.Text = Convert.ToString(matrix.array[1, 1]);
            textBox2_3.Text = Convert.ToString(matrix.array[1, 2]);
            textBox2_4.Text = Convert.ToString(matrix.array[1, 3]);
            textBox2_5.Text = Convert.ToString(matrix.array[1, 4]);

            textBox3_1.Text = Convert.ToString(matrix.array[2, 0]);
            textBox3_2.Text = Convert.ToString(matrix.array[2, 1]);
            textBox3_3.Text = Convert.ToString(matrix.array[2, 2]);
            textBox3_4.Text = Convert.ToString(matrix.array[2, 3]);
            textBox3_5.Text = Convert.ToString(matrix.array[2, 4]);

            textBox4_1.Text = Convert.ToString(matrix.array[3, 0]);
            textBox4_2.Text = Convert.ToString(matrix.array[3, 1]);
            textBox4_3.Text = Convert.ToString(matrix.array[3, 2]);
            textBox4_4.Text = Convert.ToString(matrix.array[3, 3]);
            textBox4_5.Text = Convert.ToString(matrix.array[3, 4]);
        }
        private void button_calculation_Click(object sender, EventArgs e)
        {
            matrix.SearchMax();
            label1.Text = "Максимальное число = " + matrix.maxNum;
        }

        private void button_random_Click(object sender, EventArgs e)
        {
            label1.Text = "Максимальное число = ";
            matrix.RandomArray();
            textBoxInsert();
        }

        private void button_reverse_Click(object sender, EventArgs e)
        {
            label1.Text = "Максимальное число = ";
            matrix.SearchMax();
            matrix.Reverse();
            textBoxInsert();
        }
    }
}
