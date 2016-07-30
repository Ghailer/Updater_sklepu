using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sklep_internetowy_wersja_graf
{
    class Produkt
    {
        public bool status { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public int model { get; set; }
        public float quantity { get; set; }
        public decimal price { get; set; }
        public decimal sku { get; set; }            //sku - cena bez podatku
        public decimal upc { get; set; }            //upc - cena z podatkiem
        public string date_available { get; set; }
        public string date_added { get; set; }
        public string date_modified { get; set; }


        public Produkt(int id, string name, int model, float quantity, decimal price, decimal sku, decimal upc)
        {
            status = true;
            this.id = id;
            this.name = name;
            this.model = model;
            this.quantity = quantity;
            this.price = price;
            this.sku = sku;
            this.upc = upc;
            this.date_available = "0000-00-00 00:00:00";
            this.date_added = "0000-00-00 00:00:00";
        }

        private void UpdateProdukt(Produkt produkt2,  CheckBox nameBox, CheckBox priceBox, CheckBox quantityBox)    //aktualizuje istniejący produkt
        {
            
                if (id.Equals(produkt2.id))
                {
                    if (nameBox.Checked == true)
                    { this.name = produkt2.name; }
                    if (priceBox.Checked == true)
                    {
                        this.price = produkt2.price;
                        this.sku = produkt2.sku;
                        this.upc = produkt2.upc;
                    }
                    if (quantityBox.Checked == true)
                        this.quantity = produkt2.quantity;
                }
            

        }

        public static bool CompareProduktLists(ref List<Produkt> produkty, List<Produkt> produkt2, CheckBox nameBox, CheckBox priceBox, CheckBox quantityBox) //porównuje dwie listy i dodaje nowe produkty
        {
            int count = produkty.Count;           
            for (int i=0; i<count;i++)
                try
                {
                    {
                        produkty[i].UpdateProdukt(produkt2[i], nameBox, priceBox, quantityBox);
                    }
                }
                catch 
                {
                    MessageBox.Show("Nie znaleziono bazy. Sprawdź bazy danych lub skontaktuj się z pomocą techniczną!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
            if (count < produkt2.Count)                 //Jeśli nowa lista jest dłuższa niż stara, to dodaje zakres wykraczający poza starą listę.
            {
                    produkty.AddRange(produkt2.GetRange(count, (produkt2.Count - produkty.Count)));                
                return true;
            }
            else return false;                       
        }

    }
}
