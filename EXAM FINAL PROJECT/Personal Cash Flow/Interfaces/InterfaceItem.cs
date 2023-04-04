using Personal_Cash_Flow.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Cash_Flow.Repositories
{
    public class InterfaceItem
    {
        public static void ItemOperation()
        {
            bool tes = true;
            while (tes)
            {
                Console.Clear();
                Console.WriteLine("=======================");
                Console.WriteLine("== ITEM MANAGEMENT ==");
                Console.WriteLine("=======================");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Update");
                Console.WriteLine("3. Search by ID");
                Console.WriteLine("4. Delete");
                Console.WriteLine("5. Show All");
                Console.WriteLine("6. Back");
                Console.Write("Choice : ");
                int vchoice = Convert.ToInt32(Console.ReadLine());

                switch (vchoice)
                {
                    case 1:
                        string[] tempAdd = new string[7];
                        Console.Write("ID : ");
                        tempAdd[0] = Console.ReadLine();

                        Console.Write("Name : ");
                        tempAdd[1] = Console.ReadLine();

                        Console.Write("Price : ");
                        tempAdd[2] = Console.ReadLine();

                        Console.Write("Total : ");
                        tempAdd[3] = Console.ReadLine();

                        Console.Write("Type : ");
                        tempAdd[4] = Console.ReadLine();

                        Vendor2.getAll();

                        Console.Write("Vendor : ");
                        tempAdd[5] = Console.ReadLine();

                        Console.Write("Halal (1/0): ");
                        tempAdd[6] = Console.ReadLine();

                        Item tempo = new Item(Convert.ToInt32(tempAdd[0]), tempAdd[1], Convert.ToInt32(tempAdd[2]), Convert.ToInt32(tempAdd[3]), tempAdd[4], Convert.ToInt32(tempAdd[5]), Convert.ToInt32(tempAdd[6]));
                        tempo.add();
                        break;

                    case 2:
                        Item2.getAll();
                        Console.Write("Input ID : ");
                        int vid = Convert.ToInt32(Console.ReadLine());
                        vid = Item2.checkID(vid);
                        if (vid > 0)
                        {
                            string[] tempUpdate = new string[7];
                            Console.Write("ID : ");
                            tempUpdate[0] = Console.ReadLine();

                            Console.Write("Name : ");
                            tempUpdate[1] = Console.ReadLine();

                            Console.Write("Price : ");
                            tempUpdate[2] = Console.ReadLine();

                            Console.Write("Total : ");
                            tempUpdate[3] = Console.ReadLine();

                            Console.Write("Type : ");
                            tempUpdate[4] = Console.ReadLine();

                            Vendor2.getAll();

                            Console.Write("Vendor : ");
                            tempUpdate[5] = Console.ReadLine();

                            Console.Write("Halal (1/0): ");
                            tempUpdate[6] = Console.ReadLine();

                            Item tempo2 = new Item(Convert.ToInt32(tempUpdate[0]), tempUpdate[1], Convert.ToInt32(tempUpdate[2]), Convert.ToInt32(tempUpdate[3]), tempUpdate[4], Convert.ToInt32(tempUpdate[5]), Convert.ToInt32(tempUpdate[6]));
                            tempo2.update(vid);
                        }
                        break;

                    case 3:
                        Console.Write("Input ID : ");
                        int vidsearch = Convert.ToInt32(Console.ReadLine());
                        Item2.getById(vidsearch);
                        break;

                    case 4:
                        Item2.getAll();
                        Console.Write("Input ID : ");
                        int vidDelete = Convert.ToInt32(Console.ReadLine());
                        Item2.delete(vidDelete);
                        break;

                    case 5:
                        Item2.getAll();
                        break;

                    case 6:
                        tes = false;
                        break;
                }
            }
        }
    }
}
