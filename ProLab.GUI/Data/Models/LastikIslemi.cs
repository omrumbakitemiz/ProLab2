using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProLab.GUI.Data.Models
{
    public class LastikIslemi
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key]
        public int LastikIslemID { get; set; }
        public string LastikMarka { get; set; }
        public string Adet { get; set; }
        public string Iscilik { get; set; }
        public string Fiyat { get; set; }
        public Durum Durum { get; set; }
        public string Usta { get; set; }
    }
}
