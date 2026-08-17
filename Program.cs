//using System;
//using System.Collections.Generic;
//namespace FirstProject
//{
//    class Program
//    {
//        static Dictionary<string, int> inventory = new Dictionary<string, int>();
//        static void Main(string[] args)
//        {
//            // Inventory Management System 
//            while(true)
//            {
//                Console.WriteLine("---------Inventory Management System---------");
//                Console.WriteLine("1- Add Item");
//                Console.WriteLine("2- View Item");
//                Console.WriteLine("3- Sell Item");
//                Console.WriteLine("4- Restock Item");
//                Console.WriteLine("5- Low Stock Alert");
//                Console.WriteLine("6- Exit");
//                Console.Write("Enter the Choice: ");
//                string choice=Console.ReadLine();
//                switch(choice)
//                {
//                    case "1":
//                        AddItem();
//                        break;
//                    case "2":
//                        ViewItem();
//                        break;
//                    case "3":
//                        SellItem();
//                        break;
//                    case "4":
//                        Restockitem();
//                        break;
//                    case "5":
//                        LowStockAlert();
//                        break;
//                    case "6":
//                        Console.WriteLine("Exit The System!"); 
//                        return;
                    
//                }

//            }
//        }
//        static void AddItem()
//        {
//            Console.Write("Enter the name of Item: ");
//            string name = Console.ReadLine();
//            Console.WriteLine("Enter the Quantity");
//            int quantity = Convert.ToInt32(Console.ReadLine());
//            if(inventory.ContainsKey(name))
//            {
//                Console.WriteLine("Name Already Existed");
//                return;
//            }
//            else
//            {
//                inventory.Add(name, quantity);
//            }
//        }
//            static void ViewItem()
//          {
//            if (inventory.Count == 0)
//            {
//                Console.WriteLine("No items in inventory");
//                return;
//            }
//            foreach (var item in inventory)
//            {
//                Console.WriteLine($"name: {item.Key}, quantity: {item.Value} ");
//            }
//          }
//        static void SellItem()
//        {
//            Console.WriteLine("what item do you want to sell?");
//            string itemname = Console.ReadLine();
//            if(inventory.ContainsKey(itemname))
//            {
//                Console.WriteLine("Item found");
//            }
//            else
//            {
//                Console.WriteLine("Item not Found");
//                return;
//            }
//            Console.WriteLine("How much quantity to sell");
//            int quantity=Convert.ToInt32(Console.ReadLine());
//            if (inventory[itemname] >= quantity)
//            {
//                Console.WriteLine("Sale completed successfully");
//                inventory[itemname] = inventory[itemname] - quantity;
//            }
//            else
//            {
                
//                Console.WriteLine("Insufficient quantity in stock");
//            }
            
//        }
//        static void Restockitem()
//        {
//            Console.Write ("What item do you want to restock?: ");
//            string restocked=Console.ReadLine();
            
//            if (!inventory.ContainsKey(restocked))
//            {
//                Console.WriteLine("Item not found. Add it first!");
//            }
//            Console.Write("Enter the quantity to restock: ");
//            int quantity = Convert.ToInt32(Console.ReadLine());
//            inventory[restocked] = inventory[restocked] + quantity;
//            Console.WriteLine("Item restocked successfully.");
            
//        }
//        static void LowStockAlert()
//        {
//            Console.WriteLine("Low stock Items.");
//            foreach(var item in inventory)
//            {//                if (item.Value < 5)
//                {
//                    Console.WriteLine($"name: {item.Key}, quantity: {item.Value}");
//                }
//            }
//        }
//    }
//}
