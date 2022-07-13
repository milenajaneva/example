using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketApp.Domain.DomainModels;

namespace TicketApp.Domain.DTO
{
    public class ShoppingCartDto
    {
        public List<TicketInShoppingCart> ticketInShoppingCarts { get; set; }
        public double TotalPrice { get; set; }
    }
}
