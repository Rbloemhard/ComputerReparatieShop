﻿using ComputerRepairShop.ClassLibrary.Helpers;
using ComputerRepairShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComputerRepairShop.Web.ViewModels
{
    public class RepairOrderViewModel
    {
        public IDictionary<RepairOrderStatus, int> StatusCount { get; private set; }
        public IEnumerable<RepairOrder> RepairOrders { get; set; }

        public RepairOrderViewModel(IEnumerable<RepairOrder> retrievedOrders)
        {
            RepairOrders = retrievedOrders;
            StatusCount = new Dictionary<RepairOrderStatus, int>();
            foreach (var statData in RepairOrders.Select(order => order.Status).GroupBy(sType => sType).Select(status => (name: status.Key, count: status.Count())))
            {
                    StatusCount.Add(statData.name, statData.count);
            }
            var globalStatus = Enum.GetValues(typeof(RepairOrderStatus)).Cast<RepairOrderStatus>();
            if (StatusCount.Count < globalStatus.Count())
            {
                foreach (var emptyStatus in globalStatus.Except(StatusCount.Keys))
                {
                    StatusCount.Add(emptyStatus, 0);
                }
            }

/*            if (StatusCount.Count() < Enum.GetValues(typeof(RepairOrderStatus)).Length)
            {
                foreach (var status in Enum.GetValues(typeof(RepairOrderStatus)))
                {
                    if (!StatusCount.ContainsKey((RepairOrderStatus)status))
                        StatusCount.Add((RepairOrderStatus)status, 0);

                }
            }*/    
        }
    }
}