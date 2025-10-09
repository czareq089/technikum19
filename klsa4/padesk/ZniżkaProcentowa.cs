using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    internal class ZniżkaProcentowa : IZniżkaStrategia
    {
        public int obliczZniżke(int kwota, int x)
        {
            return (kwota * (100 - x)) / 100;
        }
    }
}
