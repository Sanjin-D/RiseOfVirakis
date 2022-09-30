using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml;




namespace RiseOfVirakis
{
    
    public class Items
    {
        internal int item_id { get; set; }
        internal float itemWeight { get; set; }
        internal string? itemClass { get; set; }

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
