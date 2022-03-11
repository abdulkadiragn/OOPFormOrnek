using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFormOrnek
{
   public class insan
    {
        public insan()
        {
            canliMi = true;
        }
        public insan(string adSoyad)
        {
            this.adSoyad = adSoyad;
            canliMi = true;
        }
        public string adSoyad { get; set; }
        public bool canliMi { get; set; }

        public static string SelamVer()
        {
            return "Merhaba";
        }
        public string adiniSoyle()
        {
            return $"benim adim {adSoyad}";
        }

    }
}
