using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGSKJ6_HFT_2023241_Models
{
    public enum Types
    {
        Barrique,
        Lager
    }
    public class Barrell
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BarrelId { get; set; }
        public int Capacity { get; set; }
        public string Material { get; set; }
        public int NumberOfUses { get; set; }
        public Types Type { get; set; }
        [ForeignKey("Wine")]
        public int WineId { get; set; }
        [NotMapped]
        public virtual Wine Wine { get; set; }
    }
}
