﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureDemo
{
    internal class Class1
    {
        struct Orderdetails
        {
            public int orderid;
            public string productname;
            public float price;
        }
        Orderdetails ord;

        public void GetDetails()
        {
            Console.WriteLine("Enter orderid");
            ord.orderid = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter ProductName");
            ord.productname = Console.ReadLine();

            Console.WriteLine("Enter ProductPrice");
            ord.price = Convert.ToSingle(Console.ReadLine());
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"OrderId : {ord.orderid}");
            Console.WriteLine($"ProductName: {ord.productname}");
            Console.WriteLine($"Price : {ord.price}");
        }
    }
}

    

