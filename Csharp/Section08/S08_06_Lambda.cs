using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Section08
{

    enum ItemType
    {
        Weapon,
        Armor,
        Amulet,
        Ring
    }

    enum Rarity
    {
        Normal,
        Uncommon,
        Rare
    }
    class Item
    {
        public ItemType ItemType;
        public Rarity Rarity;
    }
    internal class S08_06_Lambda
    {


        static List<Item> _items = new List<Item>();

        delegate Return ItemSelector<T, Return>(T item);

        static bool IsWeapon(Item item)
        {
            return item.ItemType == ItemType.Weapon;
        }

        static Item FindItem(ItemSelector selector)
        {
            foreach (Item item in _items)
            {
                if (selector(item))
                    return item;

            }
            return null;
        }

        //static Item FindRareItem()
        //{
        //    foreach (Item item in _items)
        //    {
        //        if (item.Rarity == Rarity.Rare)
        //            return item;

        //    }
        //    return null;
        //}



        static void Main(string[] args)
        {
            _items.Add(new Item() { ItemType = ItemType.Weapon, Rarity = Rarity.Normal });
            _items.Add(new Item() { ItemType = ItemType.Armor, Rarity = Rarity.Uncommon });
            _items.Add(new Item() { ItemType = ItemType.Ring, Rarity = Rarity.Rare });


            ItemSelector selector = new ItemSelector((Item item) => { return item.ItemType == ItemType.Ring; });

            Item item = FindItem(selector);
            //Lambda : 일회용 함수를 만드는데 사용하는 문법

            //Item item = FindItem(delegate (Item item) { return item.ItemType == ItemType.Weapon; });

            //Item item = FindItem((Item item) => { return item.ItemType == ItemType.Weapon; });


        }

    }
}
