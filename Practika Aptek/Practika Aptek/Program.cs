using System;

namespace Practika_Aptek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            TypeDrug typeDrug = new TypeDrug();
            typeDrug.TypeName = "Agri kesici";
            TypeDrug typeDrug1 = new TypeDrug();
            typeDrug1.TypeName = "Viyamin";

            Console.WriteLine("TypeDrug:\n");
            Console.WriteLine(typeDrug);
            
            Drug drug = new Drug();
            
            drug.Name = "Nimecil";
            drug.Price = 0.75;
            drug.Count = 100;
            
            Console.WriteLine(drug);
            Console.WriteLine("_________________");

            Console.WriteLine("TypeDrug:\n");
            Console.WriteLine(typeDrug1);

            Drug drug1 = new Drug();
            drug1.Name = "Vitamin C";
            drug1.Price = 4.75;
            drug1.Count = 10;
            
            Console.WriteLine(drug1);
            Console.WriteLine("_________________");
            Console.WriteLine("DrugList:\n");

            Phramacy ph = new Phramacy();
            ph.AddDrug(drug);
            ph.AddDrug(drug1);
            ph.DrugList();
            Console.WriteLine("_________________");
            Console.WriteLine("Sealing drug:\n");
            ph.SealDrug("Nimecil", 5, 4.5);
            ph.SealDrug("Analgin", 3,10.12);
            


        }
    }
}
