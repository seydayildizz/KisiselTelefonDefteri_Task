using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisiselTelefonDefteri_Entity.ViewModels
{
    public class LoginViewModel
    {
        public string S { get; set; }
        public string HATA_KODU { get; set; }
        public string HATA_ACIKLAMASI { get; set; }
        public string MESAJ { get; set; }
        public string UTOKEN { get; set; }
        public string e_personel_adi_soyadi { get; set; }
        public string e_personel_id { get; set; }
    }
}
