using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace hw14
{
    class Program
    {
        static void Main(string[] args)
        {
            task6();
        }

        static void task6()
        {
            XmlDocument doc = new XmlDocument();
            XmlDeclaration declaration=doc.CreateXmlDeclaration("1.0", "windows-1251", "yes");
            doc.AppendChild(declaration);
            XmlElement tovar = doc.CreateElement("tovar");           
            XmlElement name = doc.CreateElement("name");
            name.InnerText = "Бензин";          
            XmlElement price = doc.CreateElement("price");
            price.InnerText = "20";
            tovar.AppendChild(name);
            tovar.AppendChild(price);
            doc.AppendChild(tovar);
            doc.Save("1.xml");
        }

    }
}
