using ktr_msc_ls.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ktr_msc_ls.Repository
{

    /// <summary>
    /// Interface qui contient les methodes CRUD
    /// </summary>
    public interface IProfilRepository
    {
        Task<ProfilModel> AddAsync(ProfilModel model);
        Task<List<ProfilModel>> GetAllAsync();
        Task<ProfilModel> GetByIdAsync(int id);

      
    }
}
