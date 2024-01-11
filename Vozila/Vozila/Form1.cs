using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vozila
{
    public partial class Form1 : Form
    {

        private List<Kola> vozila = new List<Kola>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string model = txtModel.Text;
            int godinaProizvodnje;
            int brojKotaca;

            if (!int.TryParse(txtGodina.Text, out godinaProizvodnje) || !int.TryParse(txtKotaci.Text, out brojKotaca) || brojKotaca / 2 == 0 || brojKotaca  == 3)
            {
                MessageBox.Show("Neispravan unos. Provjerite podatke.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string kategorija = IzracunajKategoriju(brojKotaca);
            Kola novoVozilo = new Kola(model, godinaProizvodnje, brojKotaca, kategorija);

            vozila.Add(novoVozilo);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtIspis.Clear();

            txtIspis.Clear();

            foreach (var vozilo in vozila)
            {
                txtIspis.AppendText($"Model: {vozilo.Model}, Godina proizvodnje: {vozilo.GodinaProizvodnje}, Broj kotača: {vozilo.BrojKotaca}, Kategorija: {vozilo.Kategorija}\n");
            }

            txtIspis.AppendText($"\nUkupno vozila:\n");
            foreach (var kategorija in vozila.GroupBy(v => v.Kategorija))
            {
                txtIspis.AppendText($"Kategorija: {kategorija.Key}, Ukupno vozila: {kategorija.Count()}\n");
            }
        }

        string IzracunajKategoriju(int brojKotaca)
            {
            if (brojKotaca == 2)
            {
                return "Motocikl";
            }
            else if (brojKotaca == 4)
            {
                return "Automobil";
            }
            else if (brojKotaca > 4)
            {
                return "Kamion";
            }
            else
            {
                return "Neispravno";
            }

        }
        
     }
  }

public class Kola
{
    public string Model { get; set; }
    public int GodinaProizvodnje { get; set; }
    public int BrojKotaca { get; set; }
    public string Kategorija { get; set; }

    public Kola(string model, int godinaProizvodnje, int brojKotaca, string kategorija)
    {
        Model = model;
        GodinaProizvodnje = godinaProizvodnje;
        BrojKotaca = brojKotaca;
        Kategorija = kategorija;
    }
}


