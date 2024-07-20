using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MaintenancePlatform.Shared;

namespace MaintenancePlatform.Server
{
    public class MentenantaService
    {
        private readonly ApplicationDbContext _context;

        public MentenantaService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Mentenanta>> GetAll()
        {
            return await _context.Mentenanta.ToListAsync();
        }

        public async Task Add(Mentenanta mentenanta)
        {
            _context.Mentenanta.Add(mentenanta);
            await _context.SaveChangesAsync();
        }

        public async Task Remove(int id)
        {
            var mentenanta = await _context.Mentenanta.FindAsync(id);
            if (mentenanta != null)
            {
                _context.Mentenanta.Remove(mentenanta);
                await _context.SaveChangesAsync();
            }
        }
    }
}

