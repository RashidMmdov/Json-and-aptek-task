using System;
using System.Collections.Generic;
using System.Text;

namespace Practika_Aptek
{
    internal class Drug
    {
        public string Name;
        public static int Id = 0;
        public double Price;
        public  int Count;
        public override string ToString()
        {
            Id++;
            return $"Drug name: {Name}, Price: {Price}$, Count: {Count}";
        }
    }
}
