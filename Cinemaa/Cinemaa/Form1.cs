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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 myRegistr = new Form2();
            myRegistr.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var item in Registr.registrs)
            {
                if (username.Text == item.Name && userPass.Text == item.Pass && username.Text != null && userPass.Text != null) 
                {
                    Form3 selectFilm = new Form3();
                    selectFilm.Show();
                    this.Hide();
                }
                else
                {
                    label3.Text="*Incorrect Username or Password!";
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            userPass.PasswordChar='*';
        }
    }
}
