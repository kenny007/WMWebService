using System;
using System.Linq;
namespace WaremanWS.Models
{
    public interface IRepository
    {
       IQueryable<Order> GetAllOrders();
       IQueryable<Order> GetAllOrdersWithDetails();
        Order GetOrder(int id);
    }
}
