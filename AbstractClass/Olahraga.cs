using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.AbstractClass
{
    public class Olahraga : JadwalPelajaran
    {
        public override void Hari()
        {
            Console.WriteLine("Olahraga mempelajari tentang kebugaran jasmani");
            Console.WriteLine("Contoh seperti push up, sit up, jogging");
        }
    }
}
