using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TicketApp.Domain.DomainModels;
using TicketApp.Domain.DTO;
using TicketApp.Domain.Identity;
using TicketApp.Repository;

namespace TicketApp.Web.Controllers
{
    public class ShoppingCartController : Controller
    {

        private readonly ApplicationDbContext _context;
        private readonly UserManager<TicketAppUser> _userManager;

        public ShoppingCartController(ApplicationDbContext context, UserManager<TicketAppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var loggedInUser = await _context.Users
                .Where(z => z.Id == userId)
                .Include(z => z.UserCart)
                .Include(z => z.UserCart.TicketInShoppingCarts)
                .Include("UserCart.TicketInShoppingCarts.Ticket")
                .FirstOrDefaultAsync();

            var userShoppingCart = loggedInUser.UserCart;

            var ticketPrice = userShoppingCart.TicketInShoppingCarts.Select(z => new
            {
                TicketPrice = z.Ticket.TicketPrice,
                Quantity = z.Quantity
            }).ToList();

            double totalPrice = 0;

            foreach(var item in ticketPrice)
            {
                totalPrice += item.TicketPrice * item.Quantity;
            }

            ShoppingCartDto shoppingCartDtoItem = new ShoppingCartDto
            {
                ticketInShoppingCarts = userShoppingCart.TicketInShoppingCarts.ToList(),
                TotalPrice = totalPrice
            };

            return View(shoppingCartDtoItem);
        }

        public async Task<IActionResult> DeleteTicketFromShoppingCart(Guid ticketId)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var loggedInUser = await _context.Users
                .Where(z => z.Id == userId)
                .Include(z => z.UserCart)
                .Include(z => z.UserCart.TicketInShoppingCarts)
                .Include("UserCart.TicketInShoppingCarts.Ticket")
                .FirstOrDefaultAsync();

            var userShoppingCart = loggedInUser.UserCart;

            var ticketToDelete = userShoppingCart.TicketInShoppingCarts
                .Where(z => z.TicketId == ticketId)
                .FirstOrDefault();

            userShoppingCart.TicketInShoppingCarts.Remove(ticketToDelete);

            _context.Update(userShoppingCart);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index", "ShoppingCart");
        }

        public async Task<IActionResult> OrderNow()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var loggedInUser = await _context.Users
                .Where(z => z.Id == userId)
                .Include(z => z.UserCart)
                .Include(z => z.UserCart.TicketInShoppingCarts)
                .Include("UserCart.TicketInShoppingCarts.Ticket")
                .FirstOrDefaultAsync();

            var userShoppingCart = loggedInUser.UserCart;

            Order orderItem = new Order
            {
                Id = Guid.NewGuid(),
                UserId = userId,
                User = loggedInUser
            };

            _context.Add(orderItem);

            List<TicketInOrder> ticketInOrders = new List<TicketInOrder>();

            ticketInOrders = userShoppingCart.TicketInShoppingCarts
                .Select(z => new TicketInOrder
                {
                    OrderId = orderItem.Id,
                    TicketId = z.TicketId,
                    SelectedTicket = z.Ticket,
                    UserOrder = orderItem
                }).ToList();

            foreach(var item in ticketInOrders)
            {
                _context.Add(item);            
            }

            loggedInUser.UserCart.TicketInShoppingCarts.Clear();

            _context.Update(loggedInUser);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index", "ShoppingCart");
        }
    }
}
