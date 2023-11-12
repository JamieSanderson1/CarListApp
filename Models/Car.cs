﻿using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarListApp.Models
{
    [SQLite.Table("cars")]

    public class Car : BaseEntity
    {
        public string Make { get; set; }
        public string Model { get; set; }

        [SQLite.MaxLength(12)]
        [Unique]
        public string Vin { get; set; }

    }

}
