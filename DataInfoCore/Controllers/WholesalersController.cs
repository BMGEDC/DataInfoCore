using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DataInfoCore.Data;
using DataInfoCore.Models;

namespace DataInfoCore.Controllers
{
    public class WholesalersController : Controller
    {
        private readonly DataContext _context;

        public WholesalersController(DataContext context)
        {
            _context = context;
        }

        // GET: Wholesalers
        public async Task<IActionResult> Index()
        {
            return View(await _context.Wholesaler.ToListAsync());
        }

        // GET: Wholesalers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wholesaler = await _context.Wholesaler
                .SingleOrDefaultAsync(m => m.ID == id);
            if (wholesaler == null)
            {
                return NotFound();
            }

            return View(wholesaler);
        }

        // GET: Wholesalers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Wholesalers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Market,WholesalerCode,WholesalerName,ETSUser,InBook,Online,DailyFeed,CustomerFeed,Comments,ETSLocation")] Wholesaler wholesaler)
        {
            if (ModelState.IsValid)
            {
                _context.Add(wholesaler);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(wholesaler);
        }

        // GET: Wholesalers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wholesaler = await _context.Wholesaler.SingleOrDefaultAsync(m => m.ID == id);
            if (wholesaler == null)
            {
                return NotFound();
            }
            return View(wholesaler);
        }

        // POST: Wholesalers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Market,WholesalerCode,WholesalerName,ETSUser,InBook,Online,DailyFeed,CustomerFeed,Comments,ETSLocation")] Wholesaler wholesaler)
        {
            if (id != wholesaler.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(wholesaler);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WholesalerExists(wholesaler.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(wholesaler);
        }

        // GET: Wholesalers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wholesaler = await _context.Wholesaler
                .SingleOrDefaultAsync(m => m.ID == id);
            if (wholesaler == null)
            {
                return NotFound();
            }

            return View(wholesaler);
        }

        // POST: Wholesalers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var wholesaler = await _context.Wholesaler.SingleOrDefaultAsync(m => m.ID == id);
            _context.Wholesaler.Remove(wholesaler);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WholesalerExists(int id)
        {
            return _context.Wholesaler.Any(e => e.ID == id);
        }
    }
}
