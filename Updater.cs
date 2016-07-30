using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Sklep_internetowy_wersja_graf
{
    class Updater
    {

        public static void Updatable(GroupBox updateGroupbox )
        {
            updateGroupbox.Visible = true;
        }

        public static void Odczyt(ref List<Produkt> produkty, Button FileGenerator) //Wczytuje nowa baze z pliku 
        {

            Encoding enc = Encoding.GetEncoding("Windows-1250");
            if (File.Exists(@"baza.txt"))
            {
                StreamReader reader = new StreamReader(@"baza.txt", enc);
                string line;
                string line2;
                string[] substring;
                int id = 0;
                string nazwa = "";
                int model = 0;
                float quantity = 0f;
                decimal price = 0m;
                decimal upc = 0m;
                int count = File.ReadLines(@"baza.txt").Count();

                line = reader.ReadLine();


                for (int i = 0; i <= count - 2; i++)
                {
                    line = reader.ReadLine();
                    substring = line.Split('\t');
                    while (substring.Length < 40)
                    {
                        line2 = reader.ReadLine();
                        line = string.Concat(line, line2);
                        substring = line.Split('\t');
                        count -= 1;
                    }
                    for (int pozycja = 0; pozycja <= (substring.Length - 1); pozycja++)
                    {

                        switch (pozycja)
                        {
                            case 0:
                                {
                                    nazwa = substring[0];
                                    break;
                                }
                            case 2:
                                {
                                    id = int.Parse(substring[2]);
                                    model = id;
                                    break;
                                }
                            case 12:
                                {
                                    quantity = float.Parse(substring[12]);
                                    break;
                                }
                            case 16:
                                {
                                    price = decimal.Parse(substring[16]);
                                    break;
                                }
                            case 17:
                                {
                                    upc = decimal.Parse(substring[17]);
                                    break;
                                }
                            default:
                                { break; }

                        }
                    }
                    produkty.Add(new Produkt(id, nazwa, model, quantity, price, price, upc));
                }
                reader.Close();
                produkty.Sort((x, y) => x.id.CompareTo(y.id));
                FileGenerator.Visible = true;
            }
            else
                MessageBox.Show("Brak nowej bazy lub nieprawidłowa nazwa");
        }

        public static void Zapisz( List<Produkt> produkty, CheckBox price, CheckBox quantity, CheckBox name, int last)  //Zapisuje przygotowaną do wysyłki bazę danych
        {            
            StreamWriter writer = new StreamWriter(@"oc_product.txt", false);
            StreamWriter writer2 = new StreamWriter(@"oc_product_description.txt", false);
            DateTime now = new System.DateTime();
            now = System.DateTime.Now;
            int index = produkty.FindIndex(r => r.id.Equals(last));
            for (int i = 0; i <= index; i++)
            {
                writer.Write("UPDATE oc_product SET model='{0}'", produkty[i].model);
                if (name.Checked)
                { writer2.Write("UPDATE oc_product_description SET name='{0} WHERE product_id={1};\r\n", produkty[i].name, produkty[i].id); }
                writer.Write(", sku='{0}'", produkty[i].sku);
                writer.Write(", upc='{0}'", produkty[i].upc); 
                if (quantity.Checked)
                { writer.Write(", quantity='{0}'", produkty[i].quantity); }
                if (price.Checked)
                { writer.Write(", price='{0}'", produkty[i].price); }
                writer.WriteLine(" WHERE product_id={0};", produkty[i].id);
            }
            writer.Write("INSERT INTO oc_product (product_id, model, sku, upc, quantity, stock_status_id, manufacturer_id, price, date_available, date_added, date_modified) VALUES ");
            writer2.Write("INSERT INTO oc_product_description (product_id, language_id, name) VALUES ");
            for (int i = index + 1; i <= produkty.Count - 1; i++)
            {
                writer2.Write("\r\n('{0}','1','{1}'),", produkty[i].id, produkty[i].name);
                if (i < produkty.Count - 1)
                {
                    writer.WriteLine("('{0}','{1}','{2}','{3}','{4}','5','0','{5}','{6}','{7}','{8}'),", produkty[i].id, produkty[i].model, produkty[i].sku, produkty[i].upc, produkty[i].quantity, produkty[i].price, produkty[i].date_available, produkty[i].date_added, now.ToString("yyyy-MM-dd HH:mm:ss"));
                    writer2.Write("\r\n('{0}','2','{1}'),", produkty[i].id, produkty[i].name);
                }
                else
                {
                    writer.WriteLine("('{0}','{1}','{2}','{3}','{4}','5','0','{5}','{6}','{7}','{8}');", produkty[i].id, produkty[i].model, produkty[i].sku, produkty[i].upc, produkty[i].quantity, produkty[i].price, produkty[i].date_available, produkty[i].date_added, now.ToString("yyyy-MM-dd HH:mm:ss"));
                    writer2.Write("\r\n('{0}','2','{1}');", produkty[i].id, produkty[i].name);
                    writer2.Write("\r\nINSERT INTO oc_product_to_store (product_id, store_id) VALUES ");
                }
            }
            for (int i = index + 1; i <= produkty.Count - 1; i++)
            {
                if (i < produkty.Count - 1)
                { writer2.Write("\r\n('{0}','0'),", produkty[i].id); }
                else
                { writer2.Write("\r\n('{0}','0');", produkty[i].id); }
            }

            writer.Close();
            writer2.Close();
        }

        public static void OldDataCheck(ref List<Produkt> produkty, ref List<Produkt> produktyNew, Button FileGenerator, GroupBox updateGroupBox)  // Szuka starej bazy danych
        {
            Encoding enc = Encoding.GetEncoding("Windows-1250");
            if(File.Exists(@"data.txt"))
            {

                StreamReader dataCopy = new StreamReader(@"data.txt");
                int id;
                string nazwa;
                float ilosc;
                decimal cena;
                decimal cenavat;
                bool status;
                string line;
                string[] substring;

                for (int i = 0; i < File.ReadLines(@"data.txt").Count(); i++)
                {
                    line = dataCopy.ReadLine();
                    substring = line.Split(';');
                    id = int.Parse(substring[0]);
                    nazwa = substring[1];
                    ilosc = float.Parse(substring[2]);
                    cena = decimal.Parse(substring[3]);
                    cenavat = decimal.Parse(substring[4]);
                    status = bool.Parse(substring[5]);
                    produkty.Add(new Produkt(id, nazwa, id, ilosc, cena, cena, cenavat));

                }
                Updatable(updateGroupBox);
                dataCopy.Close();
                produkty.Sort((x, y) => x.id.CompareTo(y.id));
                FileGenerator.Visible = true;
                Odczyt(ref produktyNew, FileGenerator); //Wczytuje nowa baze z pliku 
            }
            else
            {
                MessageBox.Show("Brak starej bazy");
                Odczyt(ref produktyNew, FileGenerator); //Wczytuje nowa baze z pliku                    
            }
            
        }

        public static void Savedata(List<Produkt> produkty) //Zapisuje produkty do pliku "data" - używany jako stara baza
        {
            StreamWriter writer = new StreamWriter(@"data.txt", false);
            for (int i = 0; i < produkty.Count; i++)
            {
                writer.WriteLine("{0};{1};{2};{3};{4};{5}", produkty[i].id, produkty[i].name, produkty[i].quantity, produkty[i].price, produkty[i].upc, produkty[i].status);
            }
            writer.Close();

        }

    }
}
