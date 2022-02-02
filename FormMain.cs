using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormMain : Form
    {
        int chisl1;
        int chisl2;
        int znam1;
        int znam2;
        int count=5;
        int left;
        int right;        
        string znak;
        double result1;
        double result2;
        int a,b, c, d;
        public FormMain()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (count != 5)
                {
                    if (count == 1)
                    {
                        if (chisl1 == 0)
                            MessageBox.Show("Введите дробь полностью");
                        else if (chisl2 == 0)
                            MessageBox.Show("Введите дробь полностью");
                        else if (znam1 == 0)
                            MessageBox.Show("Введите дробь полностью");
                        else if (znam2 == 0)
                            MessageBox.Show("Введите дробь полностью");
                        
                        znak = ("+");
                        
                        try
                        {
                             a = int.Parse(textBox1.Text);
                             b = int.Parse(textBox2.Text);
                             c = int.Parse(textBox3.Text);
                             d = int.Parse(textBox4.Text);
                            Butterfly(a, b, c, d, "+");
                        }
                        catch (Exception qwe) { }

                    }
                    else
                    {
                        
                        znak = ("-");
                        
                        try
                        {
                             a = int.Parse(textBox1.Text);
                             b = int.Parse(textBox2.Text);
                             c = int.Parse(textBox3.Text);
                             d = int.Parse(textBox4.Text);
                            Butterfly(a, b, c, d, "-");
                        }
                        catch (Exception qwe) { }
                    }

                }
                else
                {
                    MessageBox.Show("выберите действие");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Заполните все поля");
                MessageBox.Show(ex.ToString());
            }
        }
        
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            chisl1 = Convert.ToInt32(textBox1.Text);
        }

        private void Result1_TextChanged(object sender, EventArgs e)
        {
            
        }



        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Minus_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton Minus = (RadioButton)sender;
            if (Minus.Checked)
            {
                count = 0;
            }
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton1 = (RadioButton)sender;
            if (radioButton1.Checked)
            {
                count = 1;
            }
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            chisl2= Convert.ToInt32(textBox3.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            znam1= Convert.ToInt32(textBox2.Text);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            znam2 = Convert.ToInt32(textBox4.Text);
        }

        private void Result2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            
            try
            {
                Image img = Bitmap.FromFile("D:\\babochka.jpg");
                Graphics g = Graphics.FromImage(img);
                g.DrawString(result1.ToString(), new Font("Verdana", (float)8),
                new SolidBrush(Color.Black), 149, 40);
                g.DrawString(result2.ToString(), new Font("Verdana", (float)8),
                new SolidBrush(Color.Black), 149, 55);
                g.DrawString(a.ToString(), new Font("Verdana", (float)8),
                new SolidBrush(Color.Black), 13, 37);
                g.DrawString(c.ToString(), new Font("Verdana", (float)8),
                new SolidBrush(Color.Black), 41, 37);
                g.DrawString(b.ToString(), new Font("Verdana", (float)8),
                new SolidBrush(Color.Black), 13, 56);
                g.DrawString(d.ToString(), new Font("Verdana", (float)8),
                new SolidBrush(Color.Black), 41, 56);
                g.DrawString(a.ToString(), new Font("Verdana", (float)8),
               new SolidBrush(Color.Black), 92, 37);
                g.DrawString(c.ToString(), new Font("Verdana", (float)8),
                new SolidBrush(Color.Black), 121, 37);
                g.DrawString(b.ToString(), new Font("Verdana", (float)8),
                new SolidBrush(Color.Black), 92, 56);
                g.DrawString(d.ToString(), new Font("Verdana", (float)8),
                new SolidBrush(Color.Black), 121, 56);
                g.DrawString(left.ToString(), new Font("Verdana", (float)8),
                new SolidBrush(Color.Black), 87, 10);
                g.DrawString(right.ToString(), new Font("Verdana", (float)8),
                new SolidBrush(Color.Black), 121, 10);
                g.DrawString(result2.ToString(), new Font("Verdana", (float)8),
                new SolidBrush(Color.Black), 103, 73);
                g.DrawString(znak, new Font("Verdana", (float)8),
                new SolidBrush(Color.Black), 29, 46);
                g.DrawString(znak, new Font("Verdana", (float)8),
                new SolidBrush(Color.Black), 108, 46);

                img.Save("D:\\i.new.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "1. Ввести дроби в выделенные окна ввода" +
                " 2. Выбрать нужную операцию (сложение или вычитание)" +
                " 3. Чтобы выполнить операцию и увидеть созданную бабочку нажать на кнопку выполнить" +
                " 4. Чтобы сохранить бабочку необходимо нажать кнопку сохранить",
                "Помощь"

                );
                
                
                
                
        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }
        public void Butterfly(int a, int b, int c, int d, string znak)
        {
            if (znak == "+")
            {
                left = a * d;
                right = b * c;
                result1 = (left + right);
                result2 = b * d;
                Result1.Text = result1.ToString();
                Result2.Text = result2.ToString();
                textBox5.Text = a.ToString();
                textBox6.Text = b.ToString();
                textBox7.Text = b.ToString();
                textBox8.Text = d.ToString();
                textBox9.Text = left.ToString();
                textBox10.Text = right.ToString();
                textBox11.Text = a.ToString();
                textBox12.Text = c.ToString();
                textBox13.Text = b.ToString();
                textBox14.Text = d.ToString();
                textBox15.Text = znak;
                textBox16.Text = znak;
                textBox17.Text = result2.ToString();


            }
            else if (znak == "-")
            {
                left = a * d;
                right = b * c;
                result1 = (left - right);
                result2 = b * d;
                Result1.Text = result1.ToString();
                Result2.Text = result2.ToString();
                textBox5.Text = a.ToString();
                textBox6.Text = b.ToString();
                textBox7.Text = b.ToString();
                textBox8.Text = d.ToString();
                textBox9.Text = left.ToString();
                textBox10.Text = right.ToString();
                textBox11.Text = a.ToString();
                textBox12.Text = c.ToString();
                textBox13.Text = b.ToString();
                textBox14.Text = d.ToString();
                textBox15.Text = znak;
                textBox16.Text = znak;
                textBox17.Text = result2.ToString();

            }
            else
                MessageBox.Show("Введите + или -");
        }
    }
}
