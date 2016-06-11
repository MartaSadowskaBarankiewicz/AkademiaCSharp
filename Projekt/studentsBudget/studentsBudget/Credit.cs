using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace studentsBudget
{
    public class Credit : Item
    {
        public string PayDate { get; set; }
        public string Lender { get; set; }
        

        public Credit()
        {
            this.Name = "";
            this.Value = 0;
            this.Date = "";
            this.Category=Categories.Pożyczka;
            this.PayDate = "";
            this.Lender = "";
            this.type = Types.credit;

        }
        public Credit(string name, int value, string date, string payDate, string lender)
        {
            this.Name = name;
            this.Value = value;
            this.Date = date;
            this.Category = Categories.Pożyczka;
            this.PayDate = payDate;
            this.Lender = lender;
            this.type = Types.credit;

        }

        public static void SaveItemToXML(List<Credit>list, string fileName)
        {
            XDocument xml = new XDocument(
            new XDeclaration("1.0", "utf-8", "yes"),
            new XElement(fileName,
                    from item in list
                    select new XElement("item",
                              new XAttribute("category", item.Category),
                              new XAttribute("type", item.GetItemType()),
                              new XElement("name", item.Name),
                              new XElement("value", item.Value),
                              new XElement("date", item.Date),
                              new XElement("payDate", item.PayDate),
                              new XElement("lender", item.Lender)
                              )
                           )
                        );

            xml.Save(fileName + ".xml");
        }

        public new static List<Credit> OpenItemFromXML(string fileName)
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

            List<Credit> list;

            try
            {
                list = (
                from item in xml.Root.Elements("item")
                select new Credit(
                    item.Element("name").Value,
                    int.Parse(item.Element("value").Value),
                    item.Element("date").Value,
                    item.Element("payDate").Value,
                    item.Element("lender").Value
                    )
                ).ToList<Credit>();
            }
            catch (System.NullReferenceException)
            {
                list=new List<Credit>();
            }

            return list;
        }
    }
}
