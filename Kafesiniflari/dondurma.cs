namespace Kafesiniflari
{
    public abstract class dondurma : menukalitim
    {
        public  abstract void dkiloo();
        public void cikodond()
        {
            urunad = "Çikolatalı Dondurma";
            fiyat = 20;
        }
        public void cilekdond()
        {
            urunad = "Çilekli Dondurma";
            fiyat = 20;
        }
        public void vanilyadond()
        {
            urunad = "Vanilyalı Dondurma";
            fiyat = 20;
        }
        public void muzdond()
        {
            urunad = "Muzlu Dondurma";
            fiyat = 20;
        }
    }
    
}