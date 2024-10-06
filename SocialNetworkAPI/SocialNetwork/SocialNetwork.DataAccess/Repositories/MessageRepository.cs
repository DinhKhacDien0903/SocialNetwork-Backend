using Microsoft.AspNetCore.Identity;

namespace SocialNetwork.DataAccess.Repositories
{
    public class MessageRepository : BaseRepository<MessagesEntity>, IMessageRepository
    {
        public readonly SocialNetworkdDataContext _context;

        private readonly UserManager<UserEntity> _userManager;
        public MessageRepository(
            SocialNetworkdDataContext context,
            UserManager<UserEntity> userManager) : base(context)
        {
            _context = context;
            _userManager = userManager;
        }
    }
}
