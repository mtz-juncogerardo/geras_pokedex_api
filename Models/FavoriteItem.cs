using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GerasPokedex_API.Models
{
    public class FavoriteItem
    {
        [Required]
        [MaxLength(36)]
        public string Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string ApiPath { get; set; }
        public List<UserFavoriteItem> UsersFavorites { get; set; }
    }
}
