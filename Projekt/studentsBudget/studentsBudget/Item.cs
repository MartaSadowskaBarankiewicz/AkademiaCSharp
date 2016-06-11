using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace studentsBudget
{
    public enum Categories
    {
        Studia,
        Transport,
        Jedzenie,
        Rachunki,
        Rozrywka,
        Pożyczka,
        Pensja,
        Stypendium,
        Inne
    }
    public enum Types
    {
        income,
        expense,
        credit
    }
    public class Item
    {
        public string Name { get; set; }
        public int Value{ get; set; }
        public string Date { get; set; }
        public Categories Category { get; set; }
        internal Types type;

        public Item()
        {
            this.Name = "";
            this.Value = 0;
            this.Date = "";
            this.Category = Categories.Inne;
            this.type = Types.expense;
        }

        public Item(string name, int value, string date, Categories source, Types type)
        {
            this.Name = name;
            this.Value = value;
            this.Date = date;
            this.Category = source;
            this.type = type;
        }

        public Types GetItemType()
        {
            return this.type;
        }
        public static void SaveItemToXML(List<Item> list, string fileName)
        {
            XDocument xml = new XDocument(
            new XDeclaration("1.0", "utf-8", "yes"),
            new XElement(fileName,
                    from item in list
                    select new XElement("item",
                              new XAttribute("type", item.GetItemType()),
                              new XElement("name", item.Name),
                              new XElement("value", item.Value),
                              new XElement("date", item.Date),
                              new XElement("category", item.Category)
                              )
                           )
                        );

            xml.Save(fileName + ".xml");
        }
        public static List<Item> OpenItemFromXML(string fileName)
        {
            XDocument xml;
            try
            {
               xml = XDocument.Load(fileName + ".xml");
            }
            catch (System.IO.FileNotFoundException)
            {
                xml = new XDocument(new XDeclaration("1.0", "utf-8", "yes"));
            }
           
            List<Item> list;
            try
            {
                list = (
                    from item in xml.Root.Elements("item")
                    select new Item(
                        item.Element("name").Value,
                        int.Parse(item.Element("value").Value),
                        item.Element("date").Value,
                        (Categories) Enum.Parse(typeof (Categories), item.Element("category").Value),
                        (Types) Enum.Parse(typeof (Types), item.Attribute("type").Value)
                        )
                    ).ToList<Item>();
            }
            catch (System.NullReferenceException)
            {
                list = new List<Item>();
            }

            return list;
        }

        public static IComparer<Item> sortItem()
        {
            return  new SortingItem();
        }


    }
}
