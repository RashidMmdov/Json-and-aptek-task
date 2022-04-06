using System;
using System.Collections.Generic;
using System.Text;

namespace Practika_Aptek
{
    internal class TypeDrug
    {
        public static int Id = 0;
        public string TypeName { get; set; } 
        
       

        public override string ToString()
        {
            Id++;
            return $"Type name: {TypeName}, Unical Id: {Id}";
        }
    }
}
