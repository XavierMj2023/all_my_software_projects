using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace OopsProgrammingProblems.OopsPrograms
{
    public class InventoryItem
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double PricePerItem { get; set; }

        public double CalculateValue()
        {
            return Quantity * PricePerItem;
        }
    }
    public class InventoryManager
    {
        private List<InventoryItem> inventory = new List<InventoryItem>();
        public void AddInventoryItem(InventoryItem item)
        {
            inventory.Add(item);
        }
        public double CalculateTotalInventoryValue()
        {
            double totalValue = 0;

            foreach (InventoryItem item in inventory)
            {
                totalValue += item.CalculateValue();
            }

            return totalValue;
        }
        public string toJSON()
        {
            return JsonConvert.SerializeObject(inventory, Formatting.Indented);
        }
    }
    public class InventoryManagement
    {
        public void ManageInventory()
        {
            InventoryManager inventoryManager = new InventoryManager();

            // Read JSON data from a file (you can replace this with actual JSON data)
            string jsonInput = System.IO.File.ReadAllText("D:\\RECYCLE BIN EXTRAS\\ONLY_DOCS\\NET\\AllTheBasicCSharp\\BridgeLabzPractise\\BridgeLabz_Practise\\OopsProgrammingProblems\\OopsPrograms\\InventoryTest.json");

            // Deserialize JSON data into a list of InventoryItem objects
            List<InventoryItem> inventoryItems = JsonConvert.DeserializeObject<List<InventoryItem>>(jsonInput);

            // Add inventory items to the inventory manager
            foreach(InventoryItem intem in inventoryItems)
            {
                inventoryManager.AddInventoryItem(intem);
            }
            Console.WriteLine("Inventory Report:");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("{0, -20} {1, -10} {2, -15} {3, -15}", "Item Name", "Quantity", "Price per Item", "Item Value");
            Console.WriteLine("--------------------------------------------------------");

            foreach (InventoryItem item in inventoryItems)
            {
                Console.WriteLine("{0, -20} {1, -10} {2, -15:C2} {3, -15:C2}", item.Name, item.Quantity, item.PricePerItem, item.CalculateValue());
            }

            Console.WriteLine("--------------------------------------------------------");

            double totalInventoryValue = inventoryManager.CalculateTotalInventoryValue();
            Console.WriteLine("Total Inventory Value: {0, -20:C2}", totalInventoryValue);

            Console.WriteLine("JSON Representation of Inventory:");
            Console.WriteLine(inventoryManager.toJSON());
        }
    }
    public class InventoryManagementExtend
    {
        public static void GetInventoryResult()
        {
            InventoryManagement invmanage = new InventoryManagement();
            invmanage.ManageInventory();
        }
    }
}