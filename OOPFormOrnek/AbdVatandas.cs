using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFormOrnek
{
   public class AbdVatandas
    {
        public string adSoyad { get; set; }
        public DateTime dogumTarihi { get; set; }
        public string dil { get; set; }


        public int yas()
        {
            return DateTime.Today.Year - dogumTarihi.Year;
        }
    }
}
