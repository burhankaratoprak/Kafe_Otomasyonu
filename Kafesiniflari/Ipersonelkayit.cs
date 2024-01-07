using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kafesiniflari
{
    public interface Ipersonelkayit
    { 
        string garson();
        string sef();
        int id { get; set; }
        string adsoyad { get; set; }
        string telno { get; set; }
        string tecrube{get; set; }
        DateTime isegiris { get; set; }
    }
}
