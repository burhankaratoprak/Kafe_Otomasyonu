namespace Kafesiniflari
{
    public class Personelkayit : Ipersonelkayit
    {
        public int id { get; set; }
        public string adsoyad { get; set; }
        public string tecrube { get; set; }
        public string telno { get; set; }
        public DateTime isegiris { get; set; }
        string Ipersonelkayit.garson()
        {
           return   "Garson 20-99";
             
        }
        string Ipersonelkayit.sef()
        {
           return   "Şef 0-19";
             
        }
        
    }
}