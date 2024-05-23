using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class StorageEntity
    {
        [Key,StringLength(50)]
        public required string StorageId {  get; set; }

        [Required]
        public DateTime LastUpdate { get; set; }

        [Required]
        public int PartialQuantity {  get; set; }

        //relacion entre tablas
        //productos
        public string ProductId { get; set; }
        public ProductEntity Product { get; set; }
        //bodehas
        public string WhereHouseId { get; set; }
        public WhereHouseEntity WhereHouse { get; set; }
        //movimientos
        public ICollection<InputOutputEntity> InputOutput { get; set; }
    }
}
