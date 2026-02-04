using ProjectLibrary.BLL.Entities;
using ProjectLibrary.BLL.Mappers;
using ProjectLibrary.Common.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibrary.BLL.Services
{
    public class UserProfileService : IUserProfileRepository<UserProfile>
    {

        //On récupère le UserService service du DAL qui comporte l'interface IBookRepository (ce service peut être un TestService ou un APIService ou le "classique" DAlService)
        //Grâce à du polymorphisme
        private readonly IUserProfileRepository<DAL.Entities.UserProfile> _dalService;

        public UserProfileService(IUserProfileRepository<DAL.Entities.UserProfile> dalService)
        {
            _dalService = dalService;
        }


        //On met en place le CRUD, mais dans le BLL cette fois
        //Bien prendre l'objet UserProfile de la BLL (pas DAL)
        public IEnumerable<UserProfile> Get()
        {
            //userProfile=> userProfile.ToBLL() pour chaque userProfile de DAL transforme le en userProfile de BLL grace au mapper
            return _dalService.Get().Select(userProfile => userProfile.ToBLL());
        }
        public UserProfile Get(Guid userProfileId)
        {
            return _dalService.Get(userProfileId).ToBLL();
        }

        //Transformer nos entity BLL en entity DAL pour qu'ils puissent être créé dans le DAL aussi
        public Guid Create(UserProfile entity)
        {
            return _dalService.Create(entity.ToDAL());
        }

        public void Update(Guid userProfileId, UserProfile newData)
        {
            _dalService.Update(userProfileId, newData.ToDAL());
        }

        public void Delete(Guid userProfileId)
        {
            _dalService.Delete(userProfileId);
        }
    }
}
