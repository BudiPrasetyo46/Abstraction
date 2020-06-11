using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Abstraction.AbstractClass;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Jadwalpelajaran jadwalpelajaran;
            jadwalpelajaran = new Olahraga();
            jadwalpelajaran.Hari();

            Console.WriteLine();
            jadwalpelajaran = new BahasaJawa();
            jadwalpelajaran.Hari();
			
			console.WriteLine();
			jadwalpelajaran = new BahasaIndonesia();
			jadwalpelajaran.Hari();*/

            IJadwalPelajaran jadwalpelajaran;
            jadwalpelajaran = new Olahraga();
            jadwalpelajaran.Hari();

            Console.WriteLine();
            jadwalpelajaran = new BahasaJawa();
            jadwalpelajaran.Hari();
			
			Console.WriteLine();
            jadwalpelajaran = new BahasaIndonesia();
            jadwalpelajaran.Hari();
            Console.ReadKey();
        }
    }
}
