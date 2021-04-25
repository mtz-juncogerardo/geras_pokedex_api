using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GerasPokedex_API.Models
{
    public class UserItem
    {
        [Required]
        [MaxLength(36)]
        public string Id { get; set; } 
        [Required]
        [MaxLength(100)]
        public string Email { get; set; }
        [MaxLength(7)]
        public string UIColor { get; set; }
        [MaxLength(100)]
        public string Avatar { get; set; }
        public List<UserFavoriteItem> UsersFavorites { get; set; }
    }
}