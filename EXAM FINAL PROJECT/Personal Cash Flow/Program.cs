// See https://aka.ms/new-console-template for more information
using Personal_Cash_Flow.Model;
using Personal_Cash_Flow.Repositories;
using System;

namespace Personal_Cash_Flow;

public class Program
{
    static void Main(string[] args)
    {
        bool mainTes = true;
        while (mainTes)
        {
            Console.Clear();
            Console.WriteLine("========================");
            Console.WriteLine("== PERSONAL CASH FLOW ==");
            Console.WriteLine("========================");
            Console.WriteLine("1. Item Management");
            Console.WriteLine("2. Purchase Management");
            Console.WriteLine("3. Vendor Management");
            Console.WriteLine("4. Exit");
            Console.Write("Choice : ");
            int mainChoice = Convert.ToInt32(Console.ReadLine());

            switch (mainChoice)
            {
                case 1:
                    InterfaceItem.ItemOperation();
                    break;

                case 2:
                    InterfacePurchase.PurchaseOperation();
                    break;

                case 3:
                    InterfaceVendor.VendorOperation();
                    break;

                case 4:
                    mainTes = false;
                    break;
            }
        }
        
/*        Item baru = new Item(1, "Abata", 50000, 100000, "Makanan", 123, 1);
        Purchase baru1 = new Purchase(123, 50000, "Baju", 12, 1);

        Vendor baru2 = new Vendor(113, "Athariq", "Palembang", "Elektronik", 2);*/
/*
        Vendor2.getAll();*/
    }
}

