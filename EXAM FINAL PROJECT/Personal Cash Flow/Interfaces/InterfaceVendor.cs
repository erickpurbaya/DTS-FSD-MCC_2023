using Personal_Cash_Flow.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Cash_Flow.Repositories
{
    public class InterfaceVendor
    {
        public static void VendorOperation()
        {
            bool tes = true;
            while (tes) 
            {
                Console.Clear();
                Console.WriteLine("=======================");
                Console.WriteLine("== VENDOR MANAGEMENT ==");
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
                        Console.Write("Name : ");
                        tempAdd[1] = Console.ReadLine();
                        Console.Write("Origin : ");
                        tempAdd[2] = Console.ReadLine();
                        Console.Write("Type : ");
                        tempAdd[3] = Console.ReadLine();
                        Console.Write("Verified : ");
                        tempAdd[4] = Console.ReadLine();
                        Vendor tempo = new Vendor(Convert.ToInt32(tempAdd[0]), tempAdd[1], tempAdd[2], tempAdd[3], Convert.ToInt32(tempAdd[4]));
                        tempo.add();
                        break;

                    case 2:
                        Console.Clear();
                        Vendor2.getAll();
                        Console.Write("Input ID : ");
                        int vid = Convert.ToInt32(Console.ReadLine());
                        vid = Vendor2.checkID(vid);
                        if (vid > 0)
                        {
                            string[] tempUpdate = new string[5];
                            Console.Write("ID : ");
                            tempUpdate[0] = Console.ReadLine();
                            Console.Write("Name : ");
                            tempUpdate[1] = Console.ReadLine();
                            Console.Write("Origin : ");
                            tempUpdate[2] = Console.ReadLine();
                            Console.Write("Type : ");
                            tempUpdate[3] = Console.ReadLine();
                            Console.Write("Verified : ");
                            tempUpdate[4] = Console.ReadLine();
                            Vendor tempo2 = new Vendor(Convert.ToInt32(tempUpdate[0]), tempUpdate[1], tempUpdate[2], tempUpdate[3], Convert.ToInt32(tempUpdate[4]));
                            tempo2.update(vid);
                        }
                        break;

                    case 3:
                        Console.Write("Input ID : ");
                        int vidsearch = Convert.ToInt32(Console.ReadLine());
                        Vendor2.getById(vidsearch);
                        break;

                    case 4:
                        Vendor2.getAll();
                        Console.Write("Input ID : ");
                        int vidDelete = Convert.ToInt32(Console.ReadLine());
                        Vendor2.delete(vidDelete);
                        break;

                    case 5:
                        Vendor2.getAll();
                        break;

                    case 6:
                        tes = false;
                        break;
                }
            }
        }
    }
}
