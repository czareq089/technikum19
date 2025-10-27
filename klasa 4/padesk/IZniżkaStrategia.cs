using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklep
{
    internal interface IZniżkaStrategia
    {
        int obliczZniżkę(int k, int x);
    }
}
