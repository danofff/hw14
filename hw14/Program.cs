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
            task1_5();
            task6();
        }
        static void task1_5()
        {
            
            XmlDocument doc = new XmlDocument();
            XmlDeclaration declaration = doc.CreateXmlDeclaration("1.0", "utf-8", "yes");
            doc.AppendChild(declaration);
            XmlElement product = doc.CreateElement("product");
            XmlElement group = doc.CreateElement("group");

            //bread group
            XmlElement bread = doc.CreateElement("bread");
            //sliced bread
            XmlComment comment1 = doc.CreateComment("about_slice_bread");
            comment1.InnerText = "нарезанный хлеб";
            XmlElement sliced = doc.CreateElement("sliced");            
            XmlElement sliced_price = doc.CreateElement("price");
            sliced.InnerText = "sliced";
            XmlElement day_price1 = doc.CreateElement("day_price");
            XmlElement night_price1 = doc.CreateElement("night_price");
            day_price1.InnerText = "80";
            night_price1.InnerText = "60";

            //extra info 
            XmlElement quantity1 = doc.CreateElement("quantity");
            quantity1.InnerText = "50";
            XmlElement halal1 = doc.CreateElement("halal");
            halal1.InnerText = "yes";
            XmlElement manufacturer1 = doc.CreateElement("manufacturer");
            manufacturer1.InnerText = "aksay";
            XmlElement expireDate1 = doc.CreateElement("expire_date");
            expireDate1.InnerText = DateTime.Now.AddDays(3).ToShortDateString();

            sliced_price.AppendChild(day_price1);
            sliced_price.AppendChild(night_price1);
            sliced.AppendChild(comment1);
            sliced.AppendChild(sliced_price);
            sliced.AppendChild(quantity1);
            sliced.AppendChild(halal1);
            sliced.AppendChild(manufacturer1);
            sliced.AppendChild(expireDate1);
            bread.AppendChild(sliced);

            //wholemeal bread
            XmlComment comment2 = doc.CreateComment("about_wholemeal_bread");
            comment2.InnerText = "цельнозерновой хлеб";
            XmlElement wholemeal = doc.CreateElement("wholemeal");
            XmlElement wholemeal_price = doc.CreateElement("price");
            wholemeal.InnerText = "wholemeal bread";
            XmlElement day_price2 = doc.CreateElement("day_price");
            XmlElement night_price2 = doc.CreateElement("night_price");
            day_price2.InnerText = "120";
            night_price2.InnerText = "105";

            //extra info
            XmlElement quantity2 = doc.CreateElement("quantity");
            quantity2.InnerText = "30";
            XmlElement halal2 = doc.CreateElement("halal");
            halal2.InnerText = "yes";
            XmlElement manufacturer2 = doc.CreateElement("manufacturer");
            manufacturer2.InnerText = "aksay";
            XmlElement expireDate2 = doc.CreateElement("expire_date");
            expireDate2.InnerText = DateTime.Now.AddDays(3).ToShortDateString();

            wholemeal_price.AppendChild(day_price2);
            wholemeal_price.AppendChild(night_price2);
            wholemeal.AppendChild(comment2);
            wholemeal.AppendChild(wholemeal_price);
            wholemeal.AppendChild(quantity2);
            wholemeal.AppendChild(halal2);
            wholemeal.AppendChild(manufacturer2);
            wholemeal.AppendChild(expireDate2);
            bread.AppendChild(wholemeal);

            //milk group
            XmlElement milk = doc.CreateElement("milk");
            //2,6 milk
            XmlElement fat2_6 = doc.CreateElement("fat2.6");
            XmlElement fat2_6_price = doc.CreateElement("price");
            fat2_6.InnerText = "fat2.6";
            XmlElement day_price3 = doc.CreateElement("day_price");
            XmlElement night_price3 = doc.CreateElement("night_price");
            day_price3.InnerText = "280";
            night_price3.InnerText = "260";

            //extra info
            XmlElement quantity3 = doc.CreateElement("quantity");
            quantity3.InnerText = "100";
            XmlElement halal3 = doc.CreateElement("halal");
            halal3.InnerText = "yes";
            XmlElement manufacturer3 = doc.CreateElement("manufacturer");
            manufacturer3.InnerText = "adal";
            XmlElement expireDate3 = doc.CreateElement("expire_date");
            expireDate3.InnerText = DateTime.Now.AddDays(5).ToShortDateString();

            fat2_6_price.AppendChild(day_price3);
            fat2_6_price.AppendChild(night_price3);
            fat2_6.AppendChild(fat2_6_price);
            fat2_6.AppendChild(quantity3);
            fat2_6.AppendChild(halal3);
            fat2_6.AppendChild(manufacturer3);
            fat2_6.AppendChild(expireDate3);
            milk.AppendChild(fat2_6);

            //3,2 milk
            XmlElement fat3_2 = doc.CreateElement("fat3.2");
            XmlElement fat3_2_price = doc.CreateElement("price");
            fat3_2.InnerText = "fat3.2";
            XmlElement day_price4 = doc.CreateElement("day_price");
            XmlElement night_price4 = doc.CreateElement("night_price");
            day_price4.InnerText = "320";
            night_price4.InnerText = "300";

            //extra info
            XmlElement quantity4 = doc.CreateElement("quantity");
            quantity4.InnerText = "120";
            XmlElement halal4 = doc.CreateElement("halal");
            halal4.InnerText = "yes";
            XmlElement manufacturer4 = doc.CreateElement("manufacturer");
            manufacturer4.InnerText = "adal";
            XmlElement expireDate4 = doc.CreateElement("expire_date");
            expireDate4.InnerText = DateTime.Now.AddDays(5).ToShortDateString();

            fat3_2_price.AppendChild(day_price4);
            fat3_2_price.AppendChild(night_price4);
            fat3_2.AppendChild(fat3_2_price);
            fat3_2.AppendChild(quantity4);
            fat3_2.AppendChild(halal4);
            fat3_2.AppendChild(manufacturer4);
            fat3_2.AppendChild(expireDate4);
            milk.AppendChild(fat3_2);

            //append group
            group.AppendChild(bread);
            group.AppendChild(milk);
            product.AppendChild(group);

            XmlElement startDate = doc.CreateElement("start_date_of_sell");
            startDate.InnerText = DateTime.Now.ToString();
            XmlElement expireDate = doc.CreateElement("expire_date_of_sell");
            expireDate.InnerText = DateTime.Now.AddMonths(1).ToString();
            XmlElement manager = doc.CreateElement("manager");
            manager.InnerText = "John Smith";
            XmlElement organization = doc.CreateElement("organization");
            organization.InnerText = "wallmart";
            XmlElement rights = doc.CreateElement("rights");
            rights.InnerText = "all rights reserved";

            product.AppendChild(startDate);
            product.AppendChild(expireDate);
            product.AppendChild(manager);
            product.AppendChild(organization);
            doc.AppendChild(product);
            doc.Save("product.xml");
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
