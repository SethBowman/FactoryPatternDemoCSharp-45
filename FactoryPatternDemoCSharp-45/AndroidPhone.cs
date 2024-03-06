using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternDemoCSharp_45
{
    public class AndroidPhone : IMobilePhone
    {
        public void Call()
        {
            Console.WriteLine("Making a call with an Android phone..");
        }

        public void Text()
        {
            Console.WriteLine("Texting with an Android phone..");
        }
    }
}
