using Net.Experience.Domain.Entities;
using Net.Experience.Domain.Interfaces.Command;

namespace Net.Experience.Persistance.Sql.Command
{
    public class ItermRepository : BaseRepository<Item>, IItemRepository
    {
        public ItermRepository(NetExperienceDbContext context) : base(context)
        {
        }
    }
}
