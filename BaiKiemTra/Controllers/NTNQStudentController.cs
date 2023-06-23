using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BaiKiemTra.Models;

namespace BaiKiemTra.Controllers
{
    public class NTNQStudentController : Controller
    {
        private readonly ApplicationDbContext _context;

        public NTNQStudentController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: NTNQStudent
        public async Task<IActionResult> Index()
        {
              return _context.NTNQStudent != null ? 
                          View(await _context.NTNQStudent.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.NTNQStudent'  is null.");
        }

        // GET: NTNQStudent/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.NTNQStudent == null)
            {
                return NotFound();
            }

            var nTNQStudent = await _context.NTNQStudent
                .FirstOrDefaultAsync(m => m.NTNQStudentID == id);
            if (nTNQStudent == null)
            {
                return NotFound();
            }

            return View(nTNQStudent);
        }

        // GET: NTNQStudent/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: NTNQStudent/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("NTNQStudentID,NTNQStudentName,NTNQAdress")] NTNQStudent nTNQStudent)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nTNQStudent);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nTNQStudent);
        }

        // GET: NTNQStudent/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.NTNQStudent == null)
            {
                return NotFound();
            }

            var nTNQStudent = await _context.NTNQStudent.FindAsync(id);
            if (nTNQStudent == null)
            {
                return NotFound();
            }
            return View(nTNQStudent);
        }

        // POST: NTNQStudent/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("NTNQStudentID,NTNQStudentName,NTNQAdress")] NTNQStudent nTNQStudent)
        {
            if (id != nTNQStudent.NTNQStudentID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nTNQStudent);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NTNQStudentExists(nTNQStudent.NTNQStudentID))
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
            return View(nTNQStudent);
        }

        // GET: NTNQStudent/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.NTNQStudent == null)
            {
                return NotFound();
            }

            var nTNQStudent = await _context.NTNQStudent
                .FirstOrDefaultAsync(m => m.NTNQStudentID == id);
            if (nTNQStudent == null)
            {
                return NotFound();
            }

            return View(nTNQStudent);
        }

        // POST: NTNQStudent/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.NTNQStudent == null)
            {
                return Problem("Entity set 'ApplicationDbContext.NTNQStudent'  is null.");
            }
            var nTNQStudent = await _context.NTNQStudent.FindAsync(id);
            if (nTNQStudent != null)
            {
                _context.NTNQStudent.Remove(nTNQStudent);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NTNQStudentExists(string id)
        {
          return (_context.NTNQStudent?.Any(e => e.NTNQStudentID == id)).GetValueOrDefault();
        }
    }
}
