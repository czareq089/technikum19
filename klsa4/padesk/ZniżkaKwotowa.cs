using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    internal class ZniżkaKwotowa : IZniżkaStrategia
    {
        public int obliczZniżke(int kwota, int x)
        {
            return kwota - x;
        }
    }
}
