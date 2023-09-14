using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BE_HelacorTest.Models.Repository
{
    public class RepartoRepository: IRepartoRepository
    {
        private readonly AplicationDbContext _context;

        public RepartoRepository(AplicationDbContext context)
        {
            _context = context;
        }
      
        public async Task<List<Repartos>> GetListRepartos()
        {
            return await _context.Repartos.ToListAsync();
        }

        public async Task<Repartos?> GetReparto(int id)
        {
            return await _context.Repartos
                        .FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
