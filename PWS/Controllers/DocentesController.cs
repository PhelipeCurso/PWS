using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PWS.Models;

namespace PWS.Controllers
{
    public class DocentesController : Controller
    {
        private readonly Contexto _context;

        public DocentesController(Contexto context)
        {
            _context = context;
        }

        // GET: Docentes
        public async Task<IActionResult> Index()
        {
              return _context.Docentes != null ? 
                          View(await _context.Docentes.ToListAsync()) :
                          Problem("Entity set 'Contexto.Docentes'  is null.");
        }

        // GET: Docentes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Docentes == null)
            {
                return NotFound();
            }

            var docentes = await _context.Docentes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (docentes == null)
            {
                return NotFound();
            }

            return View(docentes);
        }

        // GET: Docentes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Docentes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Idade,Email,CPF,CNPJ,CEP,Endereco,Cidade,Bairro,Complemento,Telefone,Celular,Ativo,Data_do_Cadastro,Observacao")] Docentes docentes)
        {
            if (ModelState.IsValid)
            {
                _context.Add(docentes);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(docentes);
        }

        // GET: Docentes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Docentes == null)
            {
                return NotFound();
            }

            var docentes = await _context.Docentes.FindAsync(id);
            if (docentes == null)
            {
                return NotFound();
            }
            return View(docentes);
        }

        // POST: Docentes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Idade,Email,CPF,CNPJ,CEP,Endereco,Cidade,Bairro,Complemento,Telefone,Celular,Ativo,Data_do_Cadastro,Observacao")] Docentes docentes)
        {
            if (id != docentes.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(docentes);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DocentesExists(docentes.Id))
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
            return View(docentes);
        }

        // GET: Docentes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Docentes == null)
            {
                return NotFound();
            }

            var docentes = await _context.Docentes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (docentes == null)
            {
                return NotFound();
            }

            return View(docentes);
        }

        // POST: Docentes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Docentes == null)
            {
                return Problem("Entity set 'Contexto.Docentes'  is null.");
            }
            var docentes = await _context.Docentes.FindAsync(id);
            if (docentes != null)
            {
                _context.Docentes.Remove(docentes);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DocentesExists(int id)
        {
          return (_context.Docentes?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
