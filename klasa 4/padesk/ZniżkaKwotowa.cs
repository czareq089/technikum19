using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklep
{
    internal class ZniżkaKwotowa : IZniżkaStrategia
    {
        public int obliczZniżkę(int k, int x)
        {
            return k - x;
        }
    }
}
