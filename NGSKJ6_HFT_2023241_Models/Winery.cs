using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NGSKJ6_HFT_2023241_Models
{
    public class Winery
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int WineryId { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        [NotMapped]
        public virtual ICollection<Wine> Wines { get; set; }

    }
}
