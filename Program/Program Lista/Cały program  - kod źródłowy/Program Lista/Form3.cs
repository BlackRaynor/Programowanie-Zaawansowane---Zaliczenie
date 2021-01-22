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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            //Sprawdz czy istnieje lista, jesli nie to utwórz

            if (File.Exists("Lista.xml"))
            {
            }
            else
            {
                XElement root = new XElement("Magazyn");
                XDocument document = new XDocument();



                document.Add(root);
                document.Save("Lista.xml", SaveOptions.DisableFormatting);
            }


            if (File.Exists("items.xml"))
            {

                // Otwórz plik i pobierz elementy child o podanej nazwie

                XDocument xdoc = XDocument.Load("items.xml");

                var result = from e in xdoc.Descendants("Magazyn").Elements()
                             select (string)e.Element("Nazwa");

                //Dla każdegp znalezionego elementu dodaj do listy
                foreach (string nazwa in result)
                {
                    listView1.Items.Add(nazwa);

                }


            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                //Podstaw pod bufor lista. Miałem problem z przekazywaniem danych pomiędzy formularzami
                // więc zdecydowałem się na takie "obejście"

                String Obiekt = listView1.SelectedItems[0].Text;

                

                    // Otwórz plik i pobierz elementy child o podanej nazwie (wybór listy)

                    XDocument xdoc = XDocument.Load("Lista.xml");

                    XElement element = new XElement("Produkt",
                         new XElement("Nazwa", Obiekt));

                    
                // Zapisz

                    xdoc.Root.Add(element);
                    xdoc.Save("Lista.xml", SaveOptions.DisableFormatting); ;


                
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
