﻿using ComputerRepairShop.ClassLibrary.Helpers;
using System;
using System.ComponentModel.DataAnnotations;

namespace ComputerRepairShop.Data.Models
{
    public class RepairOrder
    {
            public int Id { get; set; }

            public string Name { get; set; }

            [DataType(DataType.Date)]
            [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
            [Required]
            public DateTime StartDate { get; set; }
            [DataType(DataType.Date)]
            [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
            public DateTime EndDate { get; set; }
            [Required]
            public RepairOrderStatus Status { get; set; }
            public string Description_Client { get; set; }
          /*  public string Description_Mechanic { get; set; }
            public string Assigned { get; set; }*/
            //  public bool Visible { get; set; }
    }
}
