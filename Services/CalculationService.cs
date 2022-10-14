using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso8.Services
{
    class CalculationService
    {
        static public T Max<T>(List<T> list) where T : IComparable
        {
            return list.Max();
        }
    }
}
