using Direction_and_File_classworkTask.Pruduct;
using Newtonsoft.Json;
using System;
using System.IO;

namespace Direction_and_File_classworkTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region File and Direction
            ////Folder yaratma ve icinde file yaratmaq. 
            //string path = Path.Combine(@"C:\Users\resid\Desktop\MyFolder");
            //string filePath = Path.Combine(@"C:\Users\resid\Desktop\MyFolder", "newTxt.txt");
            //string filePath1 = Path.Combine(@"C:\Users\resid\Desktop\MyFolder", "OldTxt.txt");
            //string path1 = Path.Combine(@"C:\Users\resid\Desktop\MyFolder", "Rashid");
            //string filePath2 = Path.Combine(@"C:\Users\resid\Desktop\MyFolder", "Rashid", "Private.txt");
            //string Datas = Path.Combine(@"C:\Users\resid\Desktop\MyFolder", "Rashid", "Data.txt");

            ////Directory.CreateDirectory(path);
            ////Directory.CreateDirectory(path1);

            ////File.Create(filePath);
            ////File.Create(filePath2);
            ////File.Create(Datas);


            //Console.WriteLine("File exists den istifade:\n");
            //if (File.Exists(filePath1))
            //{
            //    File.Delete(filePath);
            //}
            //else
            //{
            //    Console.WriteLine("Bele file yoxdur");
            //}
            //Console.WriteLine("______________________\n");
            //Console.WriteLine("Directory.GetFiles() dan istifade ederek folderde olan file lari gostersin:\n");
            //foreach (var item in Directory.GetFiles(path1))
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("______________________\n");
            ////Fileye nese elave etmek.
            ////StreamWriter streamWriter = new StreamWriter(Datas, true);

            ////streamWriter.WriteLine("Hello Rashid Mammadov!");
            ////streamWriter.WriteLine("Hello Rashid Mammadov!!");
            ////streamWriter.WriteLine("Hello Rashid Mammadov!!!");
            ////streamWriter.WriteLine("Hello Rashid Mammadov!!!!");
            ////streamWriter.WriteLine("Hello Rashid Mammadov!!!!!");
            ////streamWriter.WriteLine("Hello Rashid Mammadov!!!!!!");
            ////streamWriter.Close();

            ////Consol penceresine file de olan melumati yazdirmaq ucun.
            ////Console.WriteLine("Datas filesinde olan datalar:\n");
            ////StreamReader streamReader = new StreamReader(Datas);
            ////string Myprivate = streamReader.ReadToEnd();
            ////Console.WriteLine(Myprivate);
            ////Console.WriteLine("______________________\n");

            ////Using den istifade.
            //using (StreamReader streamReader = new StreamReader(Datas))
            //{
            //    Console.WriteLine("Datas filesinde olan datalar:\n");

            //    string Myprivate = streamReader.ReadToEnd();
            //    Console.WriteLine(Myprivate);
            //    Console.WriteLine("______________________\n");
            //}

            #endregion
            #region Jaison
            Pruducts pruduct = new Pruducts { Id=1,Name="Tea",Price=4.5};
            Pruducts pruduct1 = new Pruducts { Id=2,Name="Milk",Price=6};
            Pruducts pruduct2 = new Pruducts { Id=3,Name="Coffe",Price=3.5};
            Pruducts pruduct3 = new Pruducts { Id=4,Name="Wather",Price=1.2};

            OrderItems orderItems = new OrderItems {Id=1,Pruduct=pruduct,Price=pruduct.Price };
            OrderItems orderItems1 = new OrderItems {Id=2,Pruduct=pruduct1,Price=pruduct1.Price };
            OrderItems orderItems2 = new OrderItems {Id=3,Pruduct=pruduct2,Price=pruduct2.Price };
            OrderItems orderItems3 = new OrderItems {Id=4,Pruduct=pruduct3,Price=pruduct3.Price };

            Order order = new Order
            {
                Id = 1,
                OrderItems = new System.Collections.Generic.List<OrderItems>
            {
                orderItems,
                orderItems1,
                orderItems2,
                orderItems3
            },
                TotalPrice = 15.20
            };
           // Console.WriteLine($"Mehsulun id si: {order.OrderItems[0].Id}, Mehsulun qiymeti: {order.OrderItems[0].Price}");

            var orderStr =  JsonConvert.SerializeObject(order);
            //Console.WriteLine(orderStr);

            using (StreamWriter strm=new StreamWriter(@"C:\Users\resid\Desktop\Direction and File classworkTask\Direction and File classworkTask\Datas\js.json"))
            {
                strm.Write(orderStr);
            }


            string result;
            using (StreamReader sr = new StreamReader(@"C:\Users\resid\Desktop\Direction and File classworkTask\Direction and File classworkTask\Datas\js.json"))
            {
                result = sr.ReadLine();
            }

            Order orderDes = JsonConvert.DeserializeObject<Order>(result);
            // Console.WriteLine(orderDes.TotalPrice);
            foreach (var item in orderDes.OrderItems)
            {
                Console.WriteLine(item.Pruduct.Name);
            }
            #endregion

        }
    }
}
