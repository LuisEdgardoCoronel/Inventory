﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class InputOutputEntity
    {
        [Key, StringLength(50)]
        public required string InOutId { get; set; }

        [Required]
        public DateTime InOutDate { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public bool IsInput { get; set; }

        //relacion entre tablas
        //almacenamiento
        public string StorageId { get; set; }
        public StorageEntity Storages { get; set; }
    }
}
