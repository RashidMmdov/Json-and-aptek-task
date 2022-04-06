using System;
using System.Collections.Generic;
using System.Text;

namespace Direction_and_File_classworkTask.Pruduct
{
    internal class Order
    {
        public int Id { get; set; }
        public List<OrderItems> OrderItems{ get; set; }
        public double TotalPrice { get; set; }
    }
}
