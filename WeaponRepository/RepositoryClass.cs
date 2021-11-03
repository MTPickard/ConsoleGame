using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class Character
    {
        public Character() { }

        public Character(int lives)
        {
            Lives = lives;
        }

        public int Lives { get; set; }
        
        public List<Item> InventoryContents = new List<Item>();
    }


   public class Item
    {
        public Item() { }
        public Item(int id, string name, ItemType itemType) 
        {
            Id = id;
            Name = name;
            ItemType = itemType;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public ItemType ItemType { get; set; }
    }


    public enum ItemType
    {
        Knife,
        Revolver,
        Hammer
    }

}

