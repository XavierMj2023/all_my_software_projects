﻿using System.Collections.Generic;

namespace EBill.Models
{
	public class BillDetail
	{
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string MobileNumber { get; set; }
        public string Address { get; set; }
        public int TotalAmt { get; set; }
        public List<Items> Items { get; set; }
        public BillDetail()
        {
            Items = new List<Items>();
        }
    }
}