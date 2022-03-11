using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFormOrnek
{
   public class TcVatandas
    {
        public TcVatandas()
        {
            SistemeKayitTarihi = DateTime.Now;
        }
        public long TcNo { get; set; }
        public string adSoyad { get; set; }
        public DateTime DogumTarihi { get; set; }
        public DateTime SistemeKayitTarihi { get; set; }

        public string Vizeal()
        {
            int yas = YasHesapla(DogumTarihi);
            if (yas >= 18)
            {
                return "başvurabilirsin";
            }
            else
            {
                return "veli izni gerekli";
            }
            
        }

        private int YasHesapla(DateTime dogumTarihi)
        {
            return DateTime.Today.Year - dogumTarihi.Year;
        }
    }
}
