using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLProject
{
    class Controller
    {
        public String[] LoadValues(String type)
        {
            LoadContent c = new LoadContent();
            String[] Val=c.LoadDetails(type);
            return Val;
        }

        public String[] LoadTitle(String auth)
        {
            LoadContent lc = new LoadContent();
            String[] Val1 = lc.LoadNameandPrice(auth);
            return Val1;
        }
        public String GetPrice(String NameofBook)
        {
            LoadContent vv = new LoadContent();
           String Val2= vv.GetRate(NameofBook);
           return Val2;
            
        }
    }
}
