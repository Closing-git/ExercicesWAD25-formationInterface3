using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibrary.Common.Repositories
{
    public interface IUserProfileRepository<TUserProfile>
    {
        public IEnumerable<TUserProfile> Get();
        public TUserProfile Get(Guid userProfileId);
        public Guid Create(TUserProfile entity);

        public void Update(Guid userProfileId, TUserProfile entity);
        public void Delete(Guid userProfileId);
    }
}
