using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisiselTelefonDefteri_Entity
{
    [Table("Kullanicilar")]
    public class Kullanici
    {
        [Key]
        [StringLength(17, MinimumLength = 17, ErrorMessage = "Kullanıcı adı 17 karakter ve unique olmalıdır!")]
        [Column(Order = 1)]
        //networkAkademi100
        public string KullaniciAdi { get; set; }

        [Required]
        [Column(Order = 2)]
        public DateTime KayitTarihi { get; set; } = DateTime.Now;

        [Required]
        [StringLength(17, MinimumLength = 8, ErrorMessage = "Şifreniz en az 8 en çok 17 karakter olmalıdır!")]
        [Column(Order = 3)]

        //sifre100
        public string Sifre { get; set; }
        [Required]
        [Column(Order = 4)]
        public DateTime SonGirisTarihi { get; set; }
    }
}
