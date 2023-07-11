using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MilenaApp.Domain.Identity;

namespace MilenaApp.Domain.DomainModels
{
    public class ShoppingCart : BaseEntity
    {
        public string OwnerId { get; set; }
        public virtual MilenaAppUser Owner { get; set; }
        public virtual ICollection<TicketInShoppingCart> TicketInShoppingCarts { get; set; }
    }
}
