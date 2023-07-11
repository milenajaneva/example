using MilenaApp.Domain.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MilenaApp.Domain.DTO
{
    public class ShoppingCartDto
    {
        public List<TicketInShoppingCart> ticketInShoppingCarts { get; set; }
        public double TotalPrice { get; set; }
    }
}
