using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqAdvanced
{

    public partial class Form1 : Form
    {
        private readonly List<Category> _categories = new List<Category>()
        {
            new Category() {Id=1,Name="Elektronik"},
            new Category() {Id=2,Name="Beyaz Eşya"},
            new Category() {Id=3,Name="Küçük Ev Aletleri"},
            new Category() {Id=4,Name="Oturma Grubu"},
            new Category() {Id=5,Name="Işıklandırma "},

        };

        private readonly List<Product> _products = new List<Product>()
        {
            new Product() {Id=1,CategoryId=1,Name="aPPLE iMac",Price=20000},
            new Product() {Id=2,CategoryId=1,Name="aPPLE iMac",Price=25000},
            new Product() {Id=3,CategoryId=2,Name="Vestel Buzdolabı",Price=12000},
            new Product() {Id=4,CategoryId=3,Name="Bosch Bulaşık",Price=9000},
            new Product() {Id=5,CategoryId=3,Name="Narenciye Sık",Price=500},
            new Product() {Id=6,CategoryId=4,Name="Arçelik Fırın",Price=1000},
            new Product() {Id=7,CategoryId=1,Name="Monster Notebook",Price=18000},
            new Product() {Id=8,CategoryId=null,Name="Köşe Koltuk Takımı",Price=13500},
            new Product() {Id=9,CategoryId=5,Name="Avize",Price=450},
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var result01 = (from cat in _categories
                           where cat.Id == 3
                           select cat).SingleOrDefault(); // normalde Inum gönderirken single ile category dönürdü

            // e harfi geçen kategorileri getir
            var result02 = (from cat in _categories
                            where cat.Name.Contains('e', StringComparison.OrdinalIgnoreCase)
                            select cat);


            // Id değerine göre 3 ve daha büyük olanların ismini dizi olarak getir 
            var result03 = (from cat in _categories
                           where cat.Id >= 3
                           select cat.Name).ToArray();

            // Adı 'a' ile biten kategorileri "Id - Name " şeklinde olan bir string ifadesi olarak döndür 
            // dönüş tpi liste olsun  örn: 2-beyaz eşya

            var result04 = (from cat in _categories
                            where cat.Name.EndsWith("a", StringComparison.OrdinalIgnoreCase)
                            select $"{cat.Id} - {cat.Name}").ToList();


            // Group By
            var result05 = (from prod in _products
                            group prod by prod.CategoryId into prodGrouped
                            select prodGrouped).ToList();

            // anlamı
            // result05'in her bir elemanı , neye göre grupladıysak o değeri anahtar değer olarak içeren
            // bir alt koleksiyondur
            IGrouping<int?, Product> productGrouping = result05[0];
            var categoryId = productGrouping.Key;
            foreach (var product in productGrouping)
            { }


            var result06 = from product in _products
                           group product by product.CategoryId into productGroup // gruplama işlemi 
                           select new ProductCountByCategory()
                           {
                               CategoryId = productGrouping.Key,
                               ProductCount = productGrouping.Count()

                           };


            /* 1 meyve
             * 2 asdad
             * 3 fasfasf 
             
             */

            // inner Joın
            var joinResut = from prod in _products
                            join cat in _categories  on prod.CategoryId equals cat.Id
                            select new  // anonim oluştuduk istersen sınıfda oluşturabilirdik sanal tablo ...
                            {
                                Id=prod.Id,
                                Name=prod.Name,
                                categoryId=prod.CategoryId,
                                CategoryName=cat.Name

                            };


            /*
             Id
            Name
            CategoryID
            CategoryName

             */

            //left join
            // productın category ıd sini nullable yaptık 
            // linqda ilk yukarda ne yazdıysan onun ıdsi ilk eşitlikte olucak 

            var leftJoinResult = from prod in _products
                                 join cat in _categories on prod.CategoryId equals cat.Id into  tempCategories

                                 from c in tempCategories.DefaultIfEmpty()
                                 select new
                                 {
                                     Id=prod.Id,
                                     Name=prod.Name,
                                     CategoryId=c !=null ?c.Id:default, // alttakinin uzun hali 
                                     CategoryName=c?.Name
                                 };

        }

        private void btnShow_Click(object sender, EventArgs e)
        {

            var result05 = (from prod in _products
                            group prod by prod.CategoryId /*(Key)*/ into prodGrouped
                            select prodGrouped).ToList();

            //(1) burası 
            lstShowList.DataSource = result05[1].ToList();// grup içindeki grpları aldığı için bida list yaptım

            MessageBox.Show($"Kategori Id: {result05[1].Key}");

        }

        private void btnShow2_Click(object sender, EventArgs e)
        {
            // tablo mantığı için class açtık 

            var result06 = from product in _products
                           group product by product.CategoryId into productGroup // gruplama işlemi 
                           select new ProductCountByCategory()
                           {
                               CategoryId = productGroup.Key,
                               ProductCount = productGroup.Count()
                           };

            lstShowList.DataSource = result06.ToList();
        }

        private void btnShow3_Click(object sender, EventArgs e)
        {
            var result07 = from product in _products
                           group product by product.CategoryId into productGroup // gruplama işlemi 
                           select new  // anonim tiple döndürme 
                           {
                               CategoryId = productGroup.Key,
                               ProductCount = productGroup.Count()
                           };

            lstShowList.DataSource = result07.ToList();



            var joinResut = from prod in _products
                            join cat in _categories on prod.CategoryId equals cat.Id
                            select new  // ananim oluştuduk istersen sınıfda oluşturabilirdik
                            {
                                Id = prod.Id,
                                Name = prod.Name,
                                categoryId = prod.CategoryId,
                                CategoryName = cat.Name

                            };

        }
    }
}
