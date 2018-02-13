﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WaremanWS.Models
{
    public class Repository : WaremanWS.Models.IRepository
    {
        private WaremanWSContext db;

        public Repository(WaremanWSContext db)
        {
            this.db = db;
        }

        public IQueryable<Order> GetAllOrders()
        {
            return db.Orders;
        }

        public IQueryable<Order> GetAllOrdersWithDetails()
        {
            return db.Orders.Include("OrderDetails");
        }

        public Order GetOrder(int id)
        {
            return db.Orders.Include("OrderDetails.Book").FirstOrDefault(o => o.Id == id);
        }
    }
}