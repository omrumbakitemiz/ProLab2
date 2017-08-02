using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProLab.GUI.Data.Models
{
    public class MotorIslemi
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key]
        public int MotorIslemID { get; set; }
        public string DegisenParca { get; set; }
        public string DegisenParcaFiyat { get; set; }
        public string TamirEdilenParca { get; set; }
        public string TamirEdilenFiyat { get; set; }
        public string Fiyat { get; set; }
        public string Iscilik { get; set; }
        public Durum Durum { get; set; }
        public string Usta { get; set; }
    }
}