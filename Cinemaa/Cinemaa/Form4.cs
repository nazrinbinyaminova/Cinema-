using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinemaa
{
    public partial class Form4 : Form
    {
        public int price = 0;
        public List<Button> btns = new List<Button>();

        public Form4()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button myBtn = sender as Button;
            if (myBtn.BackColor == Color.LightGray)
            {
                MessageBox.Show("This place has already booked");
                myBtn.BackColor = Color.LightGray;
            }
            else
            {
                myBtn.BackColor = Color.DarkGray;
                btns.Add(myBtn);
                price += 5;
            }
        }

        int left = 90;
        int top = 100;
        int count = 1;

        private void Form4_Load(object sender, EventArgs e)
        {
            button1.Click += new System.EventHandler(this.button1_Click_1);

            for (int i = 0; i < 24; i++)
            {
                if (i == 6)
                {
                    left = 90;
                    top = 150;
                }
                else if (i == 12)
                {
                    left = 90;
                    top = 200;
                }
                else if (i == 18)
                {
                    left = 90;
                    top = 250;
                }
                else if (i == 24)
                {
                    left = 90;
                    top = 300;
                }

                Button btn = new Button();
                btn.Width = 60;
                btn.Height = 30;
                btn.Left = left;
                btn.Top = top;
                btn.BackColor = Color.Gray;
                btn.Text = count.ToString();
                Controls.Add(btn);
                left += 70;
                count++;


                btn.Click += new System.EventHandler(this.btn_Click);

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            button1.BackColor = Color.Gray;
            price = 0;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form3 my = new Form3();
            my.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            button2.BackColor = Color.DarkRed;
            label1.Text = ($"You have to pay: {price} $");
            foreach (var item in btns)
            {
                item.BackColor = Color.LightGray;
            }
        }
    }
}
