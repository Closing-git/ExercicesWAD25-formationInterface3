using ProjectLibrary.BLL.Entities;
using ProjectLibrary.BLL.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibrary.BLL.Services
{
    public class UserProfileService
    {
        //On récupère le UserProfileService du DAL
        private readonly DAL.Services.UserProfileService _dalService;
        //On créé un constructeur pour le UserProfileService qu'on appelera ensuite dans notre application
        //afin d'obtenir notre _dalService
        public UserProfileService(DAL.Services.UserProfileService dalService)
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
