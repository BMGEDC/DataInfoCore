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
    public class ContactRolesController : Controller
    {
        private readonly DataContext _context;

        public ContactRolesController(DataContext context)
        {
            _context = context;
        }

        // GET: ContactRoles
        public async Task<IActionResult> Index()
        {
            return View(await _context.ContactRole.ToListAsync());
        }

        // GET: ContactRoles/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contactRole = await _context.ContactRole
                .SingleOrDefaultAsync(m => m.ID == id);
            if (contactRole == null)
            {
                return NotFound();
            }

            return View(contactRole);
        }

        // GET: ContactRoles/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ContactRoles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,ContactId,RoleId,WholesalerId")] ContactRole contactRole)
        {
            if (ModelState.IsValid)
            {
                _context.Add(contactRole);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(contactRole);
        }

        // GET: ContactRoles/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contactRole = await _context.ContactRole.SingleOrDefaultAsync(m => m.ID == id);
            if (contactRole == null)
            {
                return NotFound();
            }
            return View(contactRole);
        }

        // POST: ContactRoles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,ContactId,RoleId,WholesalerId")] ContactRole contactRole)
        {
            if (id != contactRole.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(contactRole);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ContactRoleExists(contactRole.ID))
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
            return View(contactRole);
        }

        // GET: ContactRoles/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contactRole = await _context.ContactRole
                .SingleOrDefaultAsync(m => m.ID == id);
            if (contactRole == null)
            {
                return NotFound();
            }

            return View(contactRole);
        }

        // POST: ContactRoles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var contactRole = await _context.ContactRole.SingleOrDefaultAsync(m => m.ID == id);
            _context.ContactRole.Remove(contactRole);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ContactRoleExists(int id)
        {
            return _context.ContactRole.Any(e => e.ID == id);
        }
    }
}
