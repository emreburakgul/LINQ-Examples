using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAdvanced
{
    public class Product
    {
        public int Id { get; set; }
        public int? CategoryId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        // (1) datasorucesi anlamsız geldiği için overirde ettik istersek displaymemberde yapabilirdik
        public override string ToString()
        {
            return $"Id: {Id} - Kategori: {CategoryId} - Ürün: {Name}";
        }
    }
}
