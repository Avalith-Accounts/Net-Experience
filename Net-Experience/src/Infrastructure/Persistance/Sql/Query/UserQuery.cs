using Net.Experience.Domain.Entities;
using Net.Experience.Domain.Interfaces.Query;

namespace Net.Experience.Persistance.Sql.Query
{
    public class UserQuery : BaseQuery<User>, IUserQuery
    {
        public UserQuery(NetExperienceDbContext context) : base(context) { }
    }
}
