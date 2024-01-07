using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kafesiniflari
{
    public class soguk : icecek
    {
        public override   void indirim()
        {
            if (adet > 10)
            {
                tindirim += adet*4;
            }
           base.indirim();

        }
        #region İçecekler
        public void limonata()
        {
            urunad = "limonata";
            fiyat = 15;


        }
        public void ckmilk()
        {
            urunad = "Çikolatalı Milkshake";
            fiyat = 30;
        }
        public void clkmilk()
        {
            urunad = "Çilekli Milkshake";

            fiyat = 30;

        }
        public void vanilmilk()
        {
            urunad = "Vanilyalı Milkshake";

            fiyat = 30;

        }
        public void icelatte()
        {
            urunad = "İce Latte";

            fiyat = 40;

        }
        public void iceamericano()
        {
            urunad = "İce Americano";

            fiyat = 35;

        }
        public void icecapp()
        {
            urunad = "İce Cappuccino";

            fiyat = 40;

        }
        public void ayran()
        {
            urunad = "Ayran";

            fiyat = 15;

        }
        public void su()
        {
            urunad = "Su";

            fiyat = 10;

        }
        public void kola()
        {
            urunad = "Kola";

            fiyat = 18;

        }
        public void fanta()
        {
            urunad = "Fanta";

            fiyat = 18;

        }
        public void sprite()
        {
            urunad = "limonata";

            fiyat = 18;

        }

    }
}

#endregion