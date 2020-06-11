using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.AbstractClass
{
    public class BahasaJawa : JadwalPelajaran
    {
        public override void Hari()
        {
            Console.WriteLine("Bahasa Jawa mempelajari tentang berbahasa jawa yang baik");
            Console.WriteLine("Contoh seperti bahasa jawa alus, aksara jawa");
        }
    }
}
