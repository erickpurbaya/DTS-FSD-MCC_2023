using Personal_Cash_Flow.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Cash_Flow.Repositories
{
    public class InterfacePurchase
    {
        public static void PurchaseOperation()
        {
            bool tes = true;
            while (tes)
            {
                Console.Clear();
                Console.WriteLine("=======================");
                Console.WriteLine("== PURCHASE MANAGEMENT ==");
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
                        string[] tempAdd = new string[5];
                        Console.Write("ID : ");
                        tempAdd[0] = Console.ReadLine();

                        Console.Write("Total : ");
                        tempAdd[1] = Console.ReadLine();

                        Console.Write("Item : ");
                        tempAdd[2] = Console.ReadLine();

                        Vendor2.getAll();

                        Console.Write("Vendor ID : ");
                        tempAdd[3] = Console.ReadLine();

                        Console.Write("Paid (1/0): ");
                        tempAdd[4] = Console.ReadLine();

                        Purchase tempo = new Purchase(Convert.ToInt32(tempAdd[0]), Convert.ToInt32(tempAdd[1]), tempAdd[2], Convert.ToInt32(tempAdd[3]), Convert.ToInt32(tempAdd[4]));
                        tempo.add();
                        break;

                    case 2:
                        Purchase2.getAll();
                        Console.Write("Input ID : ");
                        int vid = Convert.ToInt32(Console.ReadLine());
                        vid = Purchase2.checkID(vid);
                        if (vid > 0)
                        {
                            string[] tempUpdate = new string[5];
                            Console.Write("ID : ");
                            tempUpdate[0] = Console.ReadLine();

                            Console.Write("Total : ");
                            tempUpdate[1] = Console.ReadLine();

                            Console.Write("Item : ");
                            tempUpdate[2] = Console.ReadLine();

                            Vendor2.getAll();

                            Console.Write("Vendor ID : ");
                            tempUpdate[3] = Console.ReadLine();

                            Console.Write("Paid (1/0): ");
                            tempUpdate[4] = Console.ReadLine();

                            Purchase tempo2 = new Purchase(Convert.ToInt32(tempUpdate[0]), Convert.ToInt32(tempUpdate[1]), tempUpdate[2], Convert.ToInt32(tempUpdate[3]), Convert.ToInt32(tempUpdate[4]));
                            tempo2.update(vid);
                        }
                        break;

                    case 3:
                        Console.Write("Input ID : ");
                        int vidsearch = Convert.ToInt32(Console.ReadLine());
                        Purchase2.getById(vidsearch);
                        break;

                    case 4:
                        Purchase2.getAll();
                        Console.Write("Input ID : ");
                        int vidDelete = Convert.ToInt32(Console.ReadLine());
                        Purchase2.delete(vidDelete);
                        break;

                    case 5:
                        Purchase2.getAll();
                        break;

                    case 6:
                        tes = false;
                        break;
                }
            }
        }
    }
}
