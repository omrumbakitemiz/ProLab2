﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProLab.GUI.Data.Models
{
    public class Arac
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Plaka { get; set; }
        public string Tarih { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }

        public virtual List<KaportaIslemi> KaportaIslemleri { get; set; }
        public virtual List<MotorIslemi> MotorIslemleri { get; set; }
        public virtual List<ElektrikIslemi> ElektrikIslemleri { get; set; }
        public virtual List<LastikIslemi> LastikIslemleri { get; set; }


        public void TamirEkle(KaportaIslemi kaportaIslemi)
        {
            KaportaIslemleri = new List<KaportaIslemi> {kaportaIslemi};
        }

        public void TamirEkle(ElektrikIslemi elektrikIslemi)
        {
            ElektrikIslemleri = new List<ElektrikIslemi>{elektrikIslemi};
        }

        public void TamirEkle(MotorIslemi motorIslemi)
        {
            MotorIslemleri = new List<MotorIslemi> {motorIslemi};
        }

        public void TamirEkle(LastikIslemi lastikIslemi)
        {
            LastikIslemleri = new List<LastikIslemi> {lastikIslemi};
        }
    }
    public enum Durum
    {
        TamirBaslamadi = 0,
        TamirEdiliyor = 1,
        TamirBitti = 2
    }
}
