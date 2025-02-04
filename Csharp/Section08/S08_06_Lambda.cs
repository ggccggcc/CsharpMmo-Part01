//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Csharp.Section08
//{

//    enum ItemType
//    {
//        Weapon,
//        Armor,
//        Amulet,
//        Ring
//    }

//    enum Rarity
//    {
//        Normal,
//        Uncommon,
//        Rare
//    }
//    class Item
//    {
//        public ItemType ItemType;
//        public Rarity Rarity;
//    }
//    internal class S08_06_Lambda
//    {


//        static List<Item> _items = new List<Item>();

//        delegate Return MyFunc<Return>();

//        delegate Return MyFunc<T, Return>(T item);

//        delegate Return MyFunc<T1, T2, Return>(T1 t1, T2 t2);


//        static bool IsWeapon(Item item)
//        {
//            return item.ItemType == ItemType.Weapon;
//        }

//        static Item FindItem(Func<Item, bool> selector)
//        {
//            foreach (Item item in _items)
//            {
//                if (selector(item))
//                    return item;

//            }
//            return null;
//        }

//        //static Item FindRareItem()
//        //{
//        //    foreach (Item item in _items)
//        //    {
//        //        if (item.Rarity == Rarity.Rare)
//        //            return item;

//        //    }
//        //    return null;
//        //}



//        static void Main(string[] args)
//        {
//            _items.Add(new Item() { ItemType = ItemType.Weapon, Rarity = Rarity.Normal });
//            _items.Add(new Item() { ItemType = ItemType.Armor, Rarity = Rarity.Uncommon });
//            _items.Add(new Item() { ItemType = ItemType.Ring, Rarity = Rarity.Rare });

//            //delegate를 선언하지 않아도, 이미 만들어진 애들이 있음
//            // 반환 타입이 있을 경우엔 Func
//            // 반환 타입이 없을 경우엔 Action

//            Func<Item, bool> selector = ((Item item) => { return item.ItemType == ItemType.Ring; });

//            Item item = FindItem(selector);
//            //Lambda : 일회용 함수를 만드는데 사용하는 문법

//            //Item item = FindItem(delegate (Item item) { return item.ItemType == ItemType.Weapon; });

//            //Item item = FindItem((Item item) => { return item.ItemType == ItemType.Weapon; });


//        }

//    }
//}
