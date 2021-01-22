using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Program_Lista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            if (File.Exists("items.xml"))
            {

                // Otwórz plik i pobierz elementy child o podanej nazwie

                XDocument xdoc = XDocument.Load("Lista.xml");

                var result = from e in xdoc.Descendants("Magazyn").Elements()
                             select (string)e.Element("Nazwa");

                //Dla każdegp znalezionego elementu dodaj do listy
                foreach (string nazwa in result)
                {
                    listView1.Items.Add(nazwa);
                }


            }
            else
            {
              
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Zapisz listę jako nazwę podaną przez użytkownika

            XDocument xdoc = XDocument.Load("Lista.xml");

            SaveFileDialog fdlg = new SaveFileDialog();
            fdlg.Title = "C# Corner Open File Dialog";
            fdlg.InitialDirectory = @"c:\desktop\";
            fdlg.Filter = "PNG files (*.*png|*.*|All files (*.*)|*.*";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {

                var temp = fdlg.FileName;
                xdoc.Save(fdlg.FileName+".xml", SaveOptions.DisableFormatting); ;

            }
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

        

        private void Zamknij_Click(object sender, EventArgs e)
        {

            //Zamknij formularz

            Close();
        }

        private void Dodaj_Produkt_Click(object sender, EventArgs e)
        {
            //Przejdz do bazy produktów

            Form2 objUI = new Form2();
            objUI.ShowDialog();
        }

        private void Wczytaj_Click(object sender, EventArgs e)
        {
            //Wczytaj listę z pliku

            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "C# Corner Open File Dialog";
            fdlg.InitialDirectory = @"c:\desktop\";
            fdlg.Filter = "XML Files (*.xml)|*.*|All files (*.*)|*.*";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                listView1.Clear();

                textBox1.Text = Path.GetFileNameWithoutExtension(fdlg.FileName);

               XDocument xdoc2 = XDocument.Load(fdlg.FileName);

                var result = from z in xdoc2.Descendants("Magazyn").Elements()
                             select (string)z.Element("Nazwa");

                //Dla każdegp znalezionego elementu dodaj do listy
                foreach (string nazwa in result)
                {
                    listView1.Items.Add(nazwa);
                }

                //Podstaw pod aktualny bufor lista
               
                xdoc2.Save("Lista.xml", SaveOptions.DisableFormatting); ;


            }

            


        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Otwórz wybór produktów, po zamknięciu tego formularza odśwież główną listę

            Form3 objUI = new Form3();
            objUI.FormClosing += new FormClosingEventHandler(this.Form3_FormClosing);
            objUI.ShowDialog();

        }
        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Odświeżanie

            listView1.Clear();

            XDocument xdoc = XDocument.Load("Lista.xml");

            var result = from h in xdoc.Descendants("Magazyn").Elements()
                         select (string)h.Element("Nazwa");

            //Dla każdegp znalezionego elementu dodaj do listy
            foreach (string nazwa in result)
            {
                listView1.Items.Add(nazwa);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            //Czyszczenie całego xml Lista

            XDocument xdoc = XDocument.Load("Lista.xml");

            var result = from d in xdoc.Descendants("Magazyn").Elements()
                         select (string)d.Element("Nazwa");

            //Dla każdegp znalezionego elementu dodaj do listy
            foreach (string nazwa in result)
            {
                xdoc.Descendants().Where(d => d.Name.LocalName.Equals("Produkt")
                && d.Descendants().Any(dd => dd.Name.LocalName.Equals("Nazwa"))).Remove();
                        
               
            }
                     
            xdoc.Save("Lista.xml", SaveOptions.DisableFormatting); ;

            listView1.Clear();

            

            result = from hh in xdoc.Descendants("Magazyn").Elements()
                         select (string)hh.Element("Nazwa");

            //Dla każdegp znalezionego elementu dodaj do listy
            foreach (string nazwa in result)
            {
                listView1.Items.Add(nazwa);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            //Czyszczenie wybranego produktu

            XDocument xdoc = XDocument.Load("Lista.xml");

            var result = from d in xdoc.Descendants("Magazyn").Elements()
                         select (string)d.Element("Nazwa");

            //Dla każdegp znalezionego elementu dodaj do listy
            foreach (string nazwa in result)
            {
                xdoc.Descendants().Where(d => d.Name.LocalName.Equals("Produkt")
           && d.Descendants().Any(dd => dd.Name.LocalName.Equals("Nazwa") && dd.Value.Equals(nazwa))).Remove();


            }

            xdoc.Save("Lista.xml", SaveOptions.DisableFormatting); ;

            listView1.Clear();



            result = from hh in xdoc.Descendants("Magazyn").Elements()
                     select (string)hh.Element("Nazwa");

            //Dla każdegp znalezionego elementu dodaj do listy
            foreach (string nazwa in result)
            {
                listView1.Items.Add(nazwa);
            }

        }
    }
}
