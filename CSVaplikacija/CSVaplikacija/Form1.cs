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
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CSVaplikacija
{
    public partial class Form1 : Form
    {

        struct korisnik
        {
            public string ime;
            public string Prezime;
            public string Godinarodenja;
            public string Email;
        }


            private List<korisnik> dodaj = new List<korisnik>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ime = textBox1.Text;
            string Prezime = textBox2.Text;
            string Godinarodenja = textBox3.Text;
            string Email = textBox4.Text;


            if (!Dobroime(ime))
            {
                MessageBox.Show("Unesite valjano ime.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Dobroime(Prezime))
            {
                MessageBox.Show("Unesite valjano prezime.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Dobragodina(Godinarodenja))
            {
                MessageBox.Show("Unesite valjanu godinu rođenja", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(ime) || string.IsNullOrEmpty(Prezime) || string.IsNullOrEmpty(Godinarodenja) || string.IsNullOrEmpty(Email))
            {
                MessageBox.Show("Molimo popunite sva polja.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!DobarEmail(Email))
            {
                MessageBox.Show("Unesite valjanu e-mail adresu.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dodaj.Add(new korisnik()
            {
                ime = ime,
                Prezime = Prezime,
                Godinarodenja = Godinarodenja,
                Email = Email,
            });


        }
        private bool DobarEmail(string Email)
        {
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(Email, emailPattern);
        }

        private bool Dobroime(string ime)
        {
            return !string.IsNullOrEmpty(ime) && Regex.IsMatch(ime, @"^[a-zA-Z\s]+$");
        }

        private bool Dobragodina(string Godinarodenja)
        {
            int yearNum;
            return !string.IsNullOrEmpty(Godinarodenja) && int.TryParse(Godinarodenja, out yearNum) && Godinarodenja.Length == 4;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> datoteka = new List<string>();
                datoteka.Add("Ime,Prezime,Godina rodenja,E-mail");

                foreach (korisnik korisnici in dodaj)
                {
                    datoteka.Add($"{korisnici.ime},{korisnici.Prezime},{korisnici.Godinarodenja},{korisnici.Email}");
                }

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    
                    File.WriteAllLines(saveFileDialog.FileName, datoteka);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Došlo je do pogreške prilikom spremanja podataka: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
