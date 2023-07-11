using System;
using System.Collections.Generic;
using System.Text;
using MilenaApp.Domain.DomainModels;

namespace MilenaApp.Services.Interface
{
    public interface IOrderService
    {
        List<Order> GetAllOrders();
    }
}
