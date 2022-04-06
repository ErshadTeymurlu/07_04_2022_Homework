using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_04_2022_Homework.Utilies
{
    internal class NotFoundException : Exception
    {
        public NotFoundException(string message): base(message)
        { }
    }
}
