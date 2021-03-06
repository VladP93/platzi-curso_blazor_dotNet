﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class StorageEntity
    {
        [Key]
        [StringLength(50)]
        public string StorageId { get; set; }

        [Required]
        public DateTime LastUpdate { get; set; }

        [Required]
        public int PartialQuantity { get; set; }


        //Relación con produtos
        public string ProductId { get; set; }
        public ProductEntity Product { get; set; }


        //Relacion con bodegas
        public string WarehouseId { get; set; }
        public WarehouseEntity Warehouse { get; set; }


        //Relación con movimientos 
        public ICollection<InputOutputEntity> InputOutputs { get; set; }
    }
}
