using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kafesiniflari
{
    public class donabstrack : dondurma
    {
        public override void dkiloo()
        {
            if (adet > 10)
            {
                tindirim += adet * 3;
            }
        }
        
    }
}
