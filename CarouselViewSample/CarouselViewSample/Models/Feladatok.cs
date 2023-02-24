using System;
using SQLite;

namespace CarouselViewSample.Models
{
    [Table("Feladatok")]
    public class Feladatok
    {
        [AutoIncrement, PrimaryKey]
        public int ID { get; set; }
        public string Kerdes { get; set; }
        public string Kerdes2 { get; set; }
        public string Kerdes3 { get; set; }
        public string Valasz1 { get; set; }
        public string Valasz2 { get; set; }
        public string Valasz3 { get; set; }
        public string Valasz4 { get; set; }
        public string Valasz5 { get; set; }
        public string Valasz6 { get; set; }
        public int Megoldas { get; set; }
        public string Magyarazas { get; set; }
        public string Magyarazas2 { get; set; }
        public int Feladatszam { get; set; }
        public int Pont { get; set; }
        public string Feladattipus { get; set; }
        public string Evszam { get; set; }
        public string Tantargy { get; set; }
        public bool Emelt { get; set; }
    }
}
