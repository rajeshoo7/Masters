﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Masters.Data;
using Masters.Models;

namespace Masters.Controllers
{
    public class StudentsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StudentsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Students
        public async Task<IActionResult> Index(string sortOrder, string searchString)
        {
            ViewData["FirstNameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "firstName_desc" : "firstName";
            ViewData["NineOneNineNumberSortParm"] = String.IsNullOrEmpty(sortOrder) ? "nineoneninenumber_desc" : "nineoneninenumber";

            ViewData["LastNameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "lastName_desc" : "LastName";
            ViewData["SNumberSortParm"] = sortOrder == "Snumber" ? "snumber_desc" : "SNumber";
            ViewData["StudentIdSortParm"] = sortOrder == "StudentId" ? "studentId_desc" : "studentId";
            ViewData["currentFilter"] = searchString;

            var student = from s in _context.Students
                          select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                student = student.Where(s => s.FirstName.Contains(searchString) || s.LastName.Contains(searchString));
            }

            switch (sortOrder)
            {
                case "firstName_desc":
                    student = student.OrderByDescending(s => s.FirstName);
                    break;
                case "LastName":
                    student = student.OrderBy(s => s.LastName);
                    break;
                case "lastName_desc":
                    student = student.OrderByDescending(s => s.LastName);
                    break;
                case "SNumber":
                    student = student.OrderBy(s => s.Snumber);
                    break;
                case "snumber_desc":
                    student = student.OrderByDescending(s => s.Snumber);
                    break;
                case "studentId":
                    student = student.OrderBy(s => s.StudentId);
                    break;
                case "studentId_desc":
                    student = student.OrderByDescending(s => s.StudentId);
                    break;
                default:
                    student = student.OrderBy(s => s.FirstName);
                    break;
            }

            return View(await student.AsNoTracking().ToListAsync());
        }

        // GET: Students/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.Students
                .FirstOrDefaultAsync(m => m.StudentId == id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        // GET: Students/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Students/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StudentId,NineOneNineNumber,FirstName,LastName,Snumber")] Student student)
        {
            if (ModelState.IsValid)
            {
                _context.Add(student);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }

        // GET: Students/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.Students.FindAsync(id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }

        // POST: Students/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("StudentId,NineOneNineNumber,FirstName,LastName,Snumber")] Student student)
        {
            if (id != student.StudentId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(student);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudentExists(student.StudentId))
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
            return View(student);
        }

        // GET: Students/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.Students
                .FirstOrDefaultAsync(m => m.StudentId == id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        // POST: Students/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var student = await _context.Students.FindAsync(id);
            _context.Students.Remove(student);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StudentExists(int id)
        {
            return _context.Students.Any(e => e.StudentId == id);
        }
    }
}
