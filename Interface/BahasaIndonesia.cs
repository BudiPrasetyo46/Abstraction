using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Interface
{
    public class BahasaIndonesia : IJadwalPelajaran
    {
        public void Hari()
        {
            Console.WriteLine("Bahasa Indonesia mempelajari tentang berbahasa indonesia yang baik");
            Console.WriteLine("Mempelajari bagaimana berbahasa indonesia yang baik dan benar");
        }
    }
}
