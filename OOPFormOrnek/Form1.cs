using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPFormOrnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            insan insan1 = new insan();
            insan1.adSoyad = "ahmet tutku";
            insan1.canliMi = false;

            insan insan2 = new insan();
            insan2.adSoyad = "Abdulkadir Ağan";

            insan insan3 = new insan("Mesut komiser");
            insan insan4 = new insan("Oğuzhan şentürk");
            insan insan5 = new insan()
            {
                adSoyad = "mesut özil",
                canliMi = true
            };
            MessageBox.Show(insan2.adiniSoyle());
            MessageBox.Show(insan.SelamVer());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TcVatandas vatandas1 = new TcVatandas();
            vatandas1.DogumTarihi = Convert.ToDateTime("1990-05-05");
            MessageBox.Show(vatandas1.Vizeal());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbdVatandas abdVatandas1 = new AbdVatandas();
            abdVatandas1.adSoyad = "Michael James";
            abdVatandas1.dil = "ingilizce";
            abdVatandas1.dogumTarihi = Convert.ToDateTime("1997-01-01");
            MessageBox.Show(abdVatandas1.yas().ToString());
        }
    }
}
