using System.ComponentModel.DataAnnotations.Schema;

namespace AJ.Models
{
    public class AJModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }
        public int KW { get; set; }
        public string Montag { get; set; }
        public string Dienstag { get; set; }
        public string Mittwoch { get; set; }
        public string Donnerstag { get; set; }
        public string Freitag { get; set; }
        public string Wochenrückblick { get; set; }
        public string Lupe_der_Woche { get; set; }
        public string Reflexion { get; set; }
    }
}