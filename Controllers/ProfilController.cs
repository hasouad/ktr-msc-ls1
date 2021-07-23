using ktr_msc_ls.Model;
using ktr_msc_ls.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ktr_msc_ls.Controllers
{

    /// <summary>
    /// Controller qui permet de gérer les requêtes HTTP entrantes
    /// et de renvoyer des réponses à l'utilisateur.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ProfilController : ControllerBase
    {
        private IProfilRepository _profilRepository;

        public ProfilController(IProfilRepository profilRepository)
        {
            _profilRepository = profilRepository;
        }


        /// <summary>
        /// Methode qui renvoie les elements de la base de donnée
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetAllProfils()
        {
            var profils = await _profilRepository.GetAllAsync();
            return Ok(profils);
        }

        /// <summary>
        /// Renvoie un objet dans la base de données par rapport à un ID donné
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetByIdProfil(int id)
        {
            var profil = await _profilRepository.GetByIdAsync(id);
            return Ok(profil);
        }

        /// <summary>
        /// Insère l'objet profilModel en base de données
        /// </summary>
        /// <param name="profilModel"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> AddNewProfil([FromBody] ProfilModel profilModel)
        {
            var newProfil = await _profilRepository.AddAsync(profilModel);
            return Ok(newProfil);
        }
    }
}
