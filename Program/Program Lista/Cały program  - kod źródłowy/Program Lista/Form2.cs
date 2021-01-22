using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Program_Lista
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            // Sprawdź czy istnieje plik xml, jeżeli nie stwórz go, jeżeli tak wczytaj i uzupełnij listę

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
            else
            {
                XElement root = new XElement("Magazyn");
                XDocument document = new XDocument();



                document.Add(root);
                document.Save("items.xml", SaveOptions.DisableFormatting);
            }


            
        }

        private void DodajPRr_Click(object sender, EventArgs e)
        {
            //Dodawanie obiektu Nazwa/Opis/Zdjecie

            string[] row1 = { NazwaIt.Text };
            string[] row2 = { OpisIt.Text };
            var listViewItem = new ListViewItem(row1);
            listView1.Items.Add(listViewItem);

            // Zapisz obraz 
            if (pictureBox1.Image != null)
            { 
                    pictureBox1.Image.Save(@"" + NazwaIt.Text + ".png", ImageFormat.Jpeg);
            }
            

            // Dodaj to listbox następnie zapisz do XML



            XElement element = new XElement("Produkt",
                new XElement("Nazwa", row1), 
                new XElement("Opis", row2));
                
            

            if (File.Exists("items.xml"))
            {
                XDocument document = XDocument.Load("items.xml");

                document.Root.Add(element);
                document.Save("items.xml", SaveOptions.DisableFormatting);
            }
            else
            {

            }




        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UsunPR_Click(object sender, EventArgs e)
        {

            //Usuwanie produktu z bazy

            XDocument xdoc = XDocument.Load("items.xml");

           xdoc.Descendants().Where(d => d.Name.LocalName.Equals("Produkt")
           && d.Descendants().Any(dd => dd.Name.LocalName.Equals("Nazwa") && dd.Value.Equals(NazwaIt.Text))).Remove();

            pictureBox1.Image = null;
            

            xdoc.Save("items.xml", SaveOptions.DisableFormatting);

            listView1.Clear();

            var result = from g in xdoc.Descendants("Magazyn").Elements()
                         select (string)g.Element("Nazwa");

            

            //Dla każdegp znalezionego elementu dodaj do listy
            foreach (string nazwa in result)
            {
                listView1.Items.Add(nazwa);
            }

            /*
            XDocument xdoc = XDocument.Load("items.xml");

            xdoc.Root.Element("Magazyn").Elements("Produkt").Where
            (x => x.Elements("Nazwa").Any(t => t.Value == NazwaIt.Text)).Remove();

            */

            File.Delete(@"" + NazwaIt.Text + ".png");
        }

        private void DodajOBZ_Click(object sender, EventArgs e)
        {
            // Okno dialogowe do wybrania obrazu z lokalnej maszyny a następnie podstawienie pod picturebox
            
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "C# Corner Open File Dialog";
            fdlg.InitialDirectory = @"c:\desktop\";
            fdlg.Filter = "PNG files (*.*png|*.*|All files (*.*)|*.*";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                
                var temp = fdlg.FileName;
                pictureBox1.Image = Image.FromFile(temp);
                
            }


        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {

                

                // Nazwa produktu to ta wybrana z listy po prawej

                String text = listView1.SelectedItems[0].Text;
                NazwaIt.Text = text;

                // Pobierz picturebox jeśli istnieje dla tej pozycji

                if (File.Exists(NazwaIt.Text + ".png"))
                {
                    pictureBox1.Image = Image.FromFile(@"" + NazwaIt.Text + ".png");
                }
                else
                {
                    pictureBox1.Image = null;
                }

                // Odszukaj element nazwa który odpowiada wybranej pozycji i umieść element opis w texbox.
                // Zrobione nieco dziwną metodą żeby pozbyć się elementu "Nazwa" z opisu (nie udało mi się 
                // obejść tego w inny sposób)

                XDocument xdoc = XDocument.Load("items.xml");

                var result = XDocument.Load("items.xml")
                      .Descendants("Produkt")
                      .Where(f => f.Element("Nazwa").Value == text)
                      .FirstOrDefault()?.Value;

                    string opis = result.ToString();
                    opis = opis.Replace(text, "");

                    OpisIt.Text = opis;
                




            }
            
            
        }

        private void OpisIt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
