using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.BLL.Models
{
    public class Friend
    {
        public int Id { get; }
        public int User_Id { get; set; }
        public int Friend_Id { get; set; }

        public Friend(
            int id,
            int userId,
            int friendId)
        {
            this.Id = id;
            this.User_Id = userId;
            this.Friend_Id = friendId;
        }
    }
}
