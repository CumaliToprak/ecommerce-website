using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace UzmanMetal.Core.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string DisplayName { get; set; }
        public ICollection<RefreshToken> RefreshTokens { get; set; } = new List<RefreshToken>();

    }
}