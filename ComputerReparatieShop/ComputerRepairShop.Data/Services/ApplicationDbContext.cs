﻿using ComputerRepairShop.Data.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ComputerRepairShop.Data.Services
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
    : base("DefaultConnection", throwIfV1Schema: false)
        {
        }
        public DbSet<RepairOrder> RepairOrders { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}
