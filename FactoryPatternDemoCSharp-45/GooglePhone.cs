using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternDemoCSharp_45
{
    public class GooglePhone : IMobilePhone
    {
        public void Call()
        {
            Console.WriteLine("Making a call with a Google phone..");
        }

        public void Text()
        {
            Console.WriteLine("Texting with a Google phone..");
        }
    }
}
