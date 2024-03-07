using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForForeacFaster
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Context db = new Context();
            var orderList = db.orders.ToList();

            Stopwatch stopwatch1 = new Stopwatch();

            stopwatch1.Start();

            for (int i = 0; i < orderList.Count; i++)
            {
                Console.WriteLine("For => ShipName : {0} Freight: {1}", orderList[i].ShipName, orderList[i].Freight);
            }

            stopwatch1.Stop();
            TimeSpan ts1 = stopwatch1.Elapsed;
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Data Adedi: {0}", orderList.Count);
            Console.WriteLine("For Döngüsü Süresi: {0:00}:{1:00}:{2:00}:{3:00}", ts1.Hours, ts1.Minutes, ts1.Seconds, ts1.Milliseconds / 10);


            //Stopwatch stopwatch2 = new Stopwatch();
            //stopwatch2.Start();
            //foreach (var item in orderList)
            //{
            //    Console.WriteLine("Foreach => ShipName : {0} Freight: {1}", item.ShipName, item.Freight);
            //}

            //stopwatch2.Stop();
            //TimeSpan ts2 = stopwatch2.Elapsed;
            //Console.WriteLine("---------------------------------");
            //Console.WriteLine("Data Adedi: {0}", orderList.Count);

            //Console.WriteLine("Foreach Döngüsü Süresi: {0:00}:{1:00}:{2:00}:{3:00}", ts2.Hours, ts2.Minutes, ts2.Seconds, ts2.Milliseconds / 10);

            Console.Read();
        }
    }
}
