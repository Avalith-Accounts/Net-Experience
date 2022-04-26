using Net.Experience.Domain.Entities;
using Net.Experience.Domain.Interfaces.Command;

namespace Net.Experience.Persistance.Sql.Command
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(NetExperienceDbContext context) : base(context)
        {
        }
    }
}
