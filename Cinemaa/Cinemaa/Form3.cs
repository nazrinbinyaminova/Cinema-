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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Film sherlock = new Film("Sherlock Holmes");
            Film batman = new Film("Batman");
            Film interstellar = new Film("Interstellar");

            foreach (var item in Film.myFilm)
            {
                comboBox1.Items.Add(item.FilmName);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Form4 myPlace = new Form4();
            myPlace.Show();
            this.Hide();
        }
    }

    class Film
    {
        public static List<Film> myFilm = new List<Film>();
        public string FilmName;

        public Film(string _filmname)
        {
            this.FilmName = _filmname;
            myFilm.Add(this);
        }
    }
}
