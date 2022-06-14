using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqIntro
{
    // Linq
    // Language INtegrated Query : Dil ile bütünleştirilmiş sorgulama 

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var names = new List<string>()
            {
                "Tsubasa",
                "Misaki",
                "Hyuga",
                "Misigu",
                "Wakashimazu"

            };

            // Linq Syntax 
            // linq sentaksı, SQL sorgularına benzer bir söz dizimiyle koleksiyonları (Ienumarable)
            // sorgulamaya yarayan bir kodlama biçimidir. 
            //(IEnumarable döndürür)
            var tsubasaNames = from n in names
                               where n == "Tsubasa"
                               select n;


            // Yukarıdaki LINQ sorgusu aşağıdaki işlemi yapıyor diyebiliriz

            //var SearchedNames = new List<string>();
            //foreach (var n in names)
            //{
            //    if (n=="Tsubasa")
            //    {
            //        SearchedNames.Add(n);
            //    }
            //}



            // Linq ile dönen soru sonucu asla null olmaz 
            // Eğerki sonuç dönmüyorsa bu içerdiği eleman sayısı 0 olan koleksiyn anlamına gelir. 

            //(strng döndürdü  alttakiler )
            var tsubasa = tsubasaNames.Single();// bu koleksiyonda tek eleman var onu getir demek 

            var tsubasa2 = tsubasaNames.FirstOrDefault();// ilk bi tane getir yoksa null gönder 

            var queryResult = (from n in names
                               where n == "Tsubasa"
                               select n).FirstOrDefault();

            var tsubasaNamesCount = (from n in names
                                     where n == "Tsubasa"
                                     select n).Count();// kaç tusubasa var say 

            // order by belirtilmediğinde sıralamayı artan (asc)olarak yapar
            // ascending => artan a-z
            // descending => azalan z-a 
            var orderNames = from n in names
                             orderby n descending // sıralama 
                             select n; // select ile n ifadesine bağlı , koleksiyon döndürür 

            // true/ false döndürür 
            var filteredAndOrderNames = from n in names
                                        where n.Contains("a") // içinde a içeren var mı ?
                                        orderby n
                                        select n;

            var queryResult02 = from n in names
                                where n.StartsWith("M")
                                // selectin yanına ne yazarsam o döner  int yazsam queryresult int koleksiyonu olur
                                select n; // selectin yanına n yazdığım için string kolksiyonu döndürür resulta 












        }
    }
}
