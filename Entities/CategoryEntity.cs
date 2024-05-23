using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class CategoryEntity
    {
        [Key]
        [StringLength(50)]
        public required string CategoryId { get; set; }
        [Required]
        [StringLength(100)]
        public required string CategoryName { get; set; }

        //relacion entre tablas
        //productos
        public ICollection<ProductEntity> Products { get; set; }
    }
}
