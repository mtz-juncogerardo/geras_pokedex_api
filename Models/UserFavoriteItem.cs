using System.ComponentModel.DataAnnotations;

namespace GerasPokedex_API.Models
{
    public class UserFavoriteItem
    {
        [Required]
        [MaxLength(36)]
        public string Id { get; set; }
        [Required]
        [MaxLength(36)]
        public string UserId { get; set; }
        [Required]
        [MaxLength(36)]
        public string FavoriteId { get; set; }
        public UserItem User { get; set; }
        public FavoriteItem Favorite { get; set; }
    }
}