using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml;




namespace RiseOfVirakis
{
    //TODO -> Fix inheritance for the classes 
    // FInish making items
    //implement XML System for items

    internal class Items
    {
        public Food C_food { get; private set; }
        public int item_id { get; private set; }
        public float itemWeight { get; private set; }
        public string? itemClass { get; private set; }

        internal Items()
        {
            this.C_food = new Food();
        }

        internal class Food
        {
            public int foodValue { get; private set; }
            public int foodBonus { get; private set; }

        }

        internal class Weapons
        {
            public int weaponValue { get; private set; }
            public int weaponBonus { get; private set; }
        }

        public void writeXML()
        {
            Items _item = new Items();
            _item.item_id = 0;
            _item.itemWeight = 1;
            _item.itemClass = "Weapon";

            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(Items));
            var path = "D:\\RiseOfVirakis\\Items\\items.xml";
            System.IO.FileStream file = System.IO.File.Create(path);
            serializer.Serialize(file, _item);
            file.Close();
            
            
        }

    }
}
