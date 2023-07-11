using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MilenaApp.Domain.DomainModels
{
    public class TicketInOrder : BaseEntity
    {
        public Guid ticketiD { get; set; }
        public Ticket selectedTicket { get; set; }
        public Guid OrderID{ get; set; }
      
        public Order Userorder { get; set; }
        public int quantity { get; set; }
    }
}
