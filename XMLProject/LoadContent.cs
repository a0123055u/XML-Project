using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XMLProject
{
    class LoadContent
    {
       
        public String[] LoadDetails(String typeneeded)
        {
            var xdoc = XDocument.Load("F://Test.xml");

            //var xmlStr = File.ReadAllText("F://Test.xml");
           
           // var type = XElement.Parse(xmlStr);
           // book is tag name,genere is element name(key),computer is element value;
            //var result = type.Elements("book").
            //Where(y => y.Element("genre").Value.Equals("Computer")).ToList();
            String Val1;
            String Val2;
            var ter = from i in xdoc.Descendants("book")
                      where i.Element("genre").Value.Equals(typeneeded)
                      select
                          (String)i.Element("author");
                      //String parsing is to get the value without tags             



            int Size = ter.Count();     
            String[] Type = new String[Size]; 
            int Count = 0;
            foreach(var t  in ter)
            {
                Console.WriteLine(t);
                Type[Count] = Convert.ToString(t);
                Count++;
            }
            return Type;
        }
        public String[] LoadNameandPrice(String auth)
        {
             var xdoc = XDocument.Load("F://Test.xml");
             var titleandprice = from s in xdoc.Descendants("book")
                                 where s.Element("author").Value.Equals(auth)
                                 select (String)s.Element("title");

             int Size = titleandprice.Count();
             String[] Title = new String[Size]; ;
             int Count = 0;
             foreach (var t in titleandprice)
             {
                 Console.WriteLine(t);
                 Title[Count] = Convert.ToString(t);
                 Count++;
             }
             return Title;
        }
        public String GetRate(String Name)
        {
            var xdoc = XDocument.Load("F://Test.xml");
            var price = from s in xdoc.Descendants("book")
                                where s.Element("title").Value.Equals(Name)
                                select (String)s.Element("price");

            int Size = price.Count();
            String price1= "";
            int Count = 0;
            foreach (var t in price)
            {
                Console.WriteLine(t);
                price1 = Convert.ToString(t);
                Count++;
            }
            return price1;
        }
    }
}
