﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ComputerReperatieShop.Data.Models
{
    public class RepairOrder
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime StartDate { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime EndDate { get; set; }
        public Status Status { get; set; }
        public string Description { get; set; }
        public bool Visible { get; set; }
    }


    public enum Status
    {
        Pending,
        Underway,
        [Display(Name = "Waiting for parts")]
        WaitingForParts,
        Done
    }
}