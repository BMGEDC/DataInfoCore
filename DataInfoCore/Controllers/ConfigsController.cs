﻿using System;
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
    public class ConfigsController : Controller
    {
        private readonly DataContext _context;

        public ConfigsController(DataContext context)
        {
            _context = context;
        }

        // GET: Configs
        public async Task<IActionResult> Index()
        {
            var dataContext = _context.Config.Include(c => c.Wholesaler).Include(d => d.Market); ;
            return View(await dataContext.ToListAsync());
        }

        // GET: Configs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var config = await _context.Config
                .SingleOrDefaultAsync(m => m.ID == id);
            if (config == null)
            {
                return NotFound();
            }

            return View(config);
        }

        // GET: Configs/Create
        public IActionResult Create()
        {
            ViewBag.WholesalerList = new SelectList(_context.Wholesaler, "ID", "WholesalerName");
            return View();
        }
        
        // POST: Configs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,MarketID,WholesalerID,DataPeriod,Active,Function,DataRecieved,DataProcessed,DataUploaded,ProofSent,PagesApproved,Summary,ExternalProcess,ProcessStartTime,ProcessEndTIme")] Config config)
        {
            if (ModelState.IsValid)
            {
                _context.Add(config);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(config);
        }

        // GET: Configs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var config = await _context.Config.SingleOrDefaultAsync(m => m.ID == id);
            if (config == null)
            {
                return NotFound();
            }
            ViewBag.MarketList = new SelectList(_context.Market, "ID", "MarketName", config.MarketID);
            ViewBag.WholesalerList = new SelectList(_context.Wholesaler , "ID", "WholesalerName", config.WholesalerID);
            return View(config);
        }

        // POST: Configs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,MarketID,WholesalerID,DataPeriod,Active,Function,DataRecieved,DataProcessed,DataUploaded,ProofSent,PagesApproved,Summary,ExternalProcess,ProcessStartTime,ProcessEndTIme")] Config config)
        {
            if (id != config.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(config);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ConfigExists(config.ID))
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
            return View(config);
        }

        // GET: Configs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var config = await _context.Config
                .SingleOrDefaultAsync(m => m.ID == id);
            if (config == null)
            {
                return NotFound();
            }

            return View(config);
        }

        // POST: Configs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var config = await _context.Config.SingleOrDefaultAsync(m => m.ID == id);
            _context.Config.Remove(config);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ConfigExists(int id)
        {
            return _context.Config.Any(e => e.ID == id);
        }
    }
}
