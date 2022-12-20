using CustomerRegistration.Models;
using CustomerRegistration.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CustomerRegistration.Controllers
{
    public class CustomerController : Controller
    {
        private readonly CustomerDbContext _context;

        public CustomerController(CustomerDbContext context) {
            _context = context;
        }

        //GET: Customer
        public async Task<IActionResult> Index() 
        {
            return View(await _context.Customers.ToListAsync());
        }

         // GET: Customer/AddOrEdit
        public IActionResult AddOrEdit(int id = 0)
        {
            if (id == 0)
                return View(new Customer());
            else
                return View(_context.Customers.Find(id));
        }

        // POST: Customer/AddOrEdit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("Id,Cpf,Name,Birthday,Gender,Address,State,City")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                if (customer.Id == 0)
                {
                    _context.Add(customer);
                }
                else
                    _context.Update(customer);
                
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(customer);
        }

        // POST: Customer/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var customer = await _context.Customers.FindAsync(id);
            _context.Customers.Remove(customer);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

    }
}