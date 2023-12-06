using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

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
        [JsonIgnore]
        public virtual ICollection<Wine> Wines { get; set; }
        public Winery()
        {
            Wines = new HashSet<Wine>();
        }

    }
}
