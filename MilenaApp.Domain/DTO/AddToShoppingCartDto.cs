using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MilenaApp.Domain.DomainModels;

namespace MilenaApp.Domain.DTO
{
    public class AddToShoppingCartDto
    {
        public Ticket SelectedTicket { get; set; }
        public Guid TicketID { get; set; }
        public int quantity { get; set; }
    }
}
