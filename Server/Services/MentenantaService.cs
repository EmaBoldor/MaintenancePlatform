using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MaintenancePlatform.Shared;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MaintenancePlatform.Server.Services
{
    public class MentenantaService
    {
        private readonly MentenantaContext _context;

        public MentenantaService(MentenantaContext context)
        {
            _context = context;
        }

        public async Task<List<Mentenanta>> GetMentenanteAsync()
        {
            return await _context.Mentenante.ToListAsync();
        }

        public async Task<Mentenanta> GetMentenantaByIdAsync(int id)
        {
            return await _context.Mentenante.FindAsync(id);
        }

        public async Task AddMentenantaAsync(Mentenanta mentenanta)
        {
            _context.Mentenante.Add(mentenanta);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateMentenantaAsync(Mentenanta mentenanta)
        {
            _context.Entry(mentenanta).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteMentenantaAsync(int id)
        {
            var mentenanta = await _context.Mentenante.FindAsync(id);
            if (mentenanta != null)
            {
                _context.Mentenante.Remove(mentenanta);
                await _context.SaveChangesAsync();
            }
        }
    }
}
