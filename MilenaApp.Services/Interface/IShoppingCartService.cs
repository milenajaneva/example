using System;
using System.Collections.Generic;
using System.Text;
using MilenaApp.Domain.DTO;

namespace MilenaApp.Services.Interface
{
    public interface IShoppingCartService
    {
        ShoppingCartDto getShoppingCartInfo(string userId);
        bool deleteTicketFromSoppingCart(string userId, Guid ticketId);
        bool order(string userId);
    }
}
