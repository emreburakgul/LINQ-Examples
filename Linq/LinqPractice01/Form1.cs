using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqPractice01
{
    public partial class Form1 : Form
    {
        private readonly List<string> _names = new List<string>()
        {
            "Tsubasa Ozora",
            "Taro Misai",
            "Halide Edip Adıvar",
            "Emre Burka GÜL",
            "Necmettin Erbakan",
            "Naim Süleyanoğlu"
        };

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lstNames.DataSource = _names;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            var searchName = (from n in _names
                             where n.Contains(txtSearchText.Text)
                             orderby n
                             select n).ToList();
            lstNames.DataSource = searchName; // datasource list göndermek lazım o yed tolst yaptık 

        }

        // yazar yazmaz sorgulama ile yapım 
        private void txtSearchText_TextChanged(object sender, EventArgs e)
        {
          //  var searchText = txtSearchText.Text.ToLowerInvariant();

            var searchName = (from n in _names
                              // where n.ToLowerInvariant().Contains(searchText)
                              where n.Contains(txtSearchText.Text,StringComparison.InvariantCultureIgnoreCase)
                              // üstekinin manası ignorecase b-k harf  duyarsızlaştır 
                              select n).ToList();
            lstNames.DataSource = searchName;
        }
       

    }
}
