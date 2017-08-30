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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 myUser = new Form1();
            myUser.Show();
            this.Hide();
            var userName = registrName.Text;
            var useremail = email.Text;
            var passWord = registrPass.Text;
            Registr myRegistr = new Registr(userName, useremail, passWord);
            
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            registrPass.PasswordChar = '*';     
        }
    }
    class Registr
    {
        public static List<Registr> registrs = new List<Registr>();
        public string Name;
        public string Email;
        public string Pass;

        public Registr(string _name, string _email, string _pass)
        {
            this.Name = _name;
            this.Email = _email;
            this.Pass = _pass;
            registrs.Add(this);
        }
    }
}
