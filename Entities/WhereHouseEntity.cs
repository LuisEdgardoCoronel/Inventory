using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class WhereHouseEntity
    {
        [Key]
        [StringLength(50)]
        public required string WhereHouseId {  get; set; }

        [Required,StringLength(100)]
        public required string WhereHouseName { get; set; }

        [Required,StringLength(100)]
        public required string WhereHouseAddress { get; set; }
    }
}
