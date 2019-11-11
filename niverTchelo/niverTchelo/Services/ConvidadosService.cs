using Microsoft.EntityFrameworkCore;
using niverTchelo.Data;
using niverTchelo.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace niverTchelo.Services
{
    public class ConvidadosService
    {
        private readonly niverTcheloContext _context;

        public ConvidadosService(niverTcheloContext context)
        {
            _context = context;
        }

        public async Task InsertAsync(Convidados convidado) 
        {
            _context.Convidados.Add(convidado);
            await _context.SaveChangesAsync();
        }

        public async Task <List<Convidados>> Listar()
        {
            return await _context.Convidados.ToListAsync();
        }

        public async Task DeleteAsync(Convidados convidado)
        {
            _context.Convidados.Remove(convidado);
            await _context.SaveChangesAsync();
        }
    }
}
