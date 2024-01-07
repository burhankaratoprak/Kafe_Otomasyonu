using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kafesiniflari
{

    public class sicak : icecek 
    {

        public override void indirim()
        {
            if (adet > 15)
            {
                tindirim += adet * 6;
            }
            base.indirim();

        }
        #region İçecekler

        public void cay()
        {
            urunad = "Çay";
            fiyat = 25;


        }
        public void cappucino()
        {
            urunad = "Çilekli Milkshake";

            fiyat = 30;

        }
        public void latte()
        {
            urunad = "Vanilyalı Milkshake";

            fiyat = 30;

        }
        public void türkkahvesi()
        {
            urunad = "İce Latte";

            fiyat = 40;

        }
        public void americano()
        {
            urunad = "İce Americano";

            fiyat = 35;

        }
        public void esppresso()
        {
            urunad = "İce Cappuccino";

            fiyat = 40;

        }

    }
} 
#endregion
