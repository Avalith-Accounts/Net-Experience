using Net.Experience.Domain.Entities;
using Net.Experience.Domain.Interfaces.Query;

namespace Net.Experience.Persistance.Sql.Query
{
    public class ItemQuery : BaseQuery<Item>, IItemQuery
    {
        public ItemQuery(NetExperienceDbContext context) : base(context) { }
    }
}
