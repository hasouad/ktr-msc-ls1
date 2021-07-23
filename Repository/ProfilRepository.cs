using ktr_msc_ls.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ktr_msc_ls.Repository
{
    public class ProfilRepository : IProfilRepository
    {
        private readonly MyDbContext _context;

        public ProfilRepository(MyDbContext context)
        {
            _context = context;
        }


        /// <summary>
        /// Ajouter un element dans la base
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task<ProfilModel> AddAsync(ProfilModel model)
        {
            _context.Profils.Add(model);
            await _context.SaveChangesAsync();
            return model;
        }


        /// <summary>
        /// Afficher tous les elements de la base
        /// </summary>
        /// <returns></returns>
        public async Task<List<ProfilModel>> GetAllAsync()
        {
            return await _context.Profils.ToListAsync();
        }

        /// <summary>
        /// Afficher un seul element en precisant son ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<ProfilModel> GetByIdAsync(int id)
        {
            return await _context.Profils.FirstOrDefaultAsync(p => p.ID == id);
        }
    }
}