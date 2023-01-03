using SocialNetwork.BLL.Exceptions;
using SocialNetwork.BLL.Models;
using SocialNetwork.DAL.Entities;
using SocialNetwork.DAL.Repositories;

namespace SocialNetwork.BLL.Services
{
    public class FriendService
    {
        IFriendRepository friendRepository;
        IUserRepository userRepository;

        public FriendService()
        {
            friendRepository = new FriendRepository();
            userRepository = new UserRepository();
        }

        public IEnumerable<Friend> GetFriendsListByUserId(int userId)
        {
            var friendsList = new List<Friend>();

            friendRepository.FindAllByUserId(userId).ToList().ForEach(m =>
            {
                var offeringUserEntity = userRepository.FindById(m.user_id);
                var invitedUserEntity = userRepository.FindById(m.friend_id);

                friendsList.Add(new Friend(m.id, offeringUserEntity.id, invitedUserEntity.id));
            });

            return friendsList;
        }

        public void AddFriend(FriendAddData addFriendData)
        {
            var findUserEntity = this.userRepository.FindByEmail(addFriendData.FriendEmail);
            if (findUserEntity is null) throw new UserNotFoundException();

            var friendEntity = new FriendEntity()
            {
                user_id = addFriendData.senderFriendshipUserId,
                friend_id = findUserEntity.id
            };

            if (this.friendRepository.Create(friendEntity) == 0)
                throw new Exception();
        }

        /// Добавить метод удалить из друзей!!!

        /// Скорее всего ненужный код
        private Friend ConstructUserModel(FriendEntity friendEntity)
        {
            return new Friend(friendEntity.id,
                friendEntity.user_id,
                friendEntity.friend_id);
        }
    }
}
