﻿using System;

namespace FirstApp
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime DatePlaced { get; set; }
        public Shipment shipment { get; set; }
        public float TotalPrice { get; set; }

        public bool IsShipped
        {
            get { return shipment != null; }
        }


    }
}

