﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    internal class Invoice_details
    {
        public int Detail_id {get; set;}
        public int Invoice_detail { get; set; }
        public int Product_id {get; set;}
        public int Quantity { get; set;}
        public int Price { get; set;}
        public double Subtotal { get; set;}
        public int Active { get; set;}
            
    }
}
