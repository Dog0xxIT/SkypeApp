using SkypeApp.Infrastructure.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace SkypeApp.Infrastructure.Models
{
    public class User : IdentityUser<int>
    {
        public Status Status { get; set; } = Status.Offline;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        public string RefreshToken { get; set; } = string.Empty;
        public DateTime ExpirationRefreshToken { get; set; } = DateTime.UtcNow;
    }
}
