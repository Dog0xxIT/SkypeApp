using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SkypeApp.Infrastructure.Enums;

namespace SkypeApp.Infrastructure.Models
{
    public class Room
    {
        public int Id { get; set; }
        public RoomType Type { get; set; } = RoomType.Personal;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdateAt { get; set; } = DateTime.UtcNow;
        public ICollection<Message> Messages { get; set; }
        public ICollection<User> Members { get; set; }
    }
}
