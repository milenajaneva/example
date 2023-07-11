using System;
using MilenaApp.Domain;

namespace MilenaApp.Domain.DomainModels
{
    public class TicketInShoppingCart : BaseEntity
    {

        public Guid TicketID { get; set; }
        public Ticket Ticket { get; set; }
        public Guid ShoppingCartID { get; set; }
        public ShoppingCart ShoppingCart { get; set; }

        public int quantity { get; set; }

    }
}
