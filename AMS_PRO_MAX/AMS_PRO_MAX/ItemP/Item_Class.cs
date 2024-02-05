using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMS_PRO_MAX.ItemP
{
    public class Item_Class
    {
        public int ItemID { get; set; }
        public string Name { get; set; }
        public int QuantityAvailable { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public DateTime? ExpiryDate { get; set; }


        public void EditItem(int itemId, string name, int quantity, decimal price, DateTime expiryDate, string description)
        {
            using (var context = new DB_AMS_PROEntities5())
            {
                Item item = context.Items.Find(itemId);
                if (item != null)
                {
                    item.Name = name;
                    item.QuantityAvailable = quantity;
                    item.Price = price;
                    item.ExpiryDate = expiryDate;
                    item.Description = description;
                    
                    context.SaveChanges();
                }
            }
        }

        // استدعاء الدالة DeleteItem
        public void DeleteItem(int itemId)
        {
            using (var context = new DB_AMS_PROEntities5())
            {
                Item item = context.Items.Find(itemId);
                if (item != null)
                {
                    context.Items.Remove(item);
                    
                    context.SaveChanges();
                }
            }
        }

    }
   
}


