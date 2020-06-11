using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Interface
{
    public class Olahraga : IJadwalPelajaran
    {
        public void Hari()
        {
            Console.WriteLine("Olahraga mempelajari tentang kebugaran jasmani ");
            Console.WriteLine("Dengan melakukan push up, sit up, jogging, senam");
        }
    }
}
