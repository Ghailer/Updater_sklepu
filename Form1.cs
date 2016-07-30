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
using System.Threading;
using System.Globalization;

namespace Sklep_internetowy_wersja_graf
{
    public partial class Form1 : Form
    {
        List<Produkt> produkty = new List<Produkt>();
        List<Produkt> produktynew = new List<Produkt>();
        int last=0;
        BindingList<Produkt> source;
              

        public Form1()
        {            
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
            InitializeComponent();
            Updater.OldDataCheck(ref produkty, ref produktynew, FileGenerator, updateGroupBox);  //Jesli plik istnieje, to wczytuje stara baze;  
            source = new BindingList<Produkt>(produkty);
            dataGridView1.DataSource = source;
            //if (produkty.Count()>0) { last = produkty[produkty.Count - 1].id;} 
            if ((!File.Exists(@"data.txt") || (File.ReadLines(@"data.txt").Count() == 0))) 
            {
                Produkt.CompareProduktLists(ref produkty, produktynew, NazwaCheckbox, CenaCheckbox, IloscCheckbox);
                source.ResetBindings();
            }
            else
                last = produkty[produkty.Count - 1].id;
                
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Updater.Zapisz(produkty, CenaCheckbox, IloscCheckbox, NazwaCheckbox, last);
                Updater.Savedata(produkty);
        }

        private void NazwaCheckbox_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void CenaCheckbox_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void IloscCheckbox_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {            
            if(Produkt.CompareProduktLists(ref produkty, produktynew, NazwaCheckbox, CenaCheckbox, IloscCheckbox))
            {
                produkty.Sort((x, y) => x.id.CompareTo(y.id));               
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = source;
               
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {            
        dataGridView1.DataSource = new BindingList<Produkt>(source.Where(n => n.name.ToLower().Contains(SearchTextBox.Text.ToLower())).ToList());            
        }

        private void SearchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchButton_Click(this, e);
            }
        }
       
    }
    
}
