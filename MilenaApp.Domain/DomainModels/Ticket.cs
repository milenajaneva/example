using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MilenaApp.Domain.DomainModels
{
    public class Ticket : BaseEntity
    {
        [Required]
        public string Ticketname { get; set; }
        [Required]
        public string Ticketimage { get; set; }
        [Required]
        public string Ticketdescription { get; set; }
        [Required]
        public string Ticketgenre { get; set; }
        [Required]
        public DateTime Ticketgate { get; set; }
        [Required]
        public int TicketPrice { get; set; }

        public virtual ICollection<TicketInShoppingCart> TicketInShoppingCarts { get; set; }
        public virtual ICollection<TicketInOrder> Orders { set; get; }

    }
}
