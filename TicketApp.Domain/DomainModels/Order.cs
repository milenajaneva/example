using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketApp.Domain.Identity;

namespace TicketApp.Domain.DomainModels
{
    public class Order
    {
        public Guid Id { get; set; }
        public string UserId { get; set; }
        public TicketAppUser User { get; set; }

        public virtual ICollection<TicketInOrder> Tickets { set; get; }
    }
}
