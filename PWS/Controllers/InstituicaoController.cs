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
    public class InstituicaoController : Controller
    {
        private readonly Contexto _context;

        public InstituicaoController(Contexto context)
        {
            _context = context;
        }

        // GET: Instituicao
        public async Task<IActionResult> Index()
        {
              return _context.Instituicao != null ? 
                          View(await _context.Instituicao.ToListAsync()) :
                          Problem("Entity set 'Contexto.Instituicao'  is null.");
        }

        // GET: Instituicao/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Instituicao == null)
            {
                return NotFound();
            }

            var instituicao = await _context.Instituicao
                .FirstOrDefaultAsync(m => m.Id == id);
            if (instituicao == null)
            {
                return NotFound();
            }

            return View(instituicao);
        }

        // GET: Instituicao/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Instituicao/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NomeInstituicao,CNPJ,Responsavel,CEP,Endereco,Cidade,Bairro,Complemento,Telefone,Ativo,Data_do_Cadastro")] Instituicao instituicao)
        {
            if (ModelState.IsValid)
            {
                _context.Add(instituicao);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(instituicao);
        }

        // GET: Instituicao/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Instituicao == null)
            {
                return NotFound();
            }

            var instituicao = await _context.Instituicao.FindAsync(id);
            if (instituicao == null)
            {
                return NotFound();
            }
            return View(instituicao);
        }

        // POST: Instituicao/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NomeInstituicao,CNPJ,Responsavel,CEP,Endereco,Cidade,Bairro,Complemento,Telefone,Ativo,Data_do_Cadastro")] Instituicao instituicao)
        {
            if (id != instituicao.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(instituicao);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InstituicaoExists(instituicao.Id))
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
            return View(instituicao);
        }

        // GET: Instituicao/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Instituicao == null)
            {
                return NotFound();
            }

            var instituicao = await _context.Instituicao
                .FirstOrDefaultAsync(m => m.Id == id);
            if (instituicao == null)
            {
                return NotFound();
            }

            return View(instituicao);
        }

        // POST: Instituicao/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Instituicao == null)
            {
                return Problem("Entity set 'Contexto.Instituicao'  is null.");
            }
            var instituicao = await _context.Instituicao.FindAsync(id);
            if (instituicao != null)
            {
                _context.Instituicao.Remove(instituicao);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InstituicaoExists(int id)
        {
          return (_context.Instituicao?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
