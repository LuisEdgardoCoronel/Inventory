﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class WareHouseEntity
    {
        [Key]
        [StringLength(50)]
        public string WareHouseId {  get; set; }

        [Required,StringLength(100)]
        public string WareHouseName { get; set; }

        [Required,StringLength(100)]
        public string WareHouseAddress { get; set; }

        //relacion entre tablas
        //almacenamiento
        public ICollection<StorageEntity> Storages { get; set; }
    }
}
