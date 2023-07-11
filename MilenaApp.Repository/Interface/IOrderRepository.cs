using System;
using System.Collections.Generic;
using System.Text;
using MilenaApp.Domain.DomainModels;

namespace MilenaApp.Repository.Interface
{
    public interface IOrderRepository
    {
        public List<Order> GetAllOrders();
    }
}
