using GerasPokedex_API.Models;
using Microsoft.AspNetCore.Mvc;

namespace GerasPokedex_API.Controllers
{
    [ApiController]
    [Route("admin")]
    public class UserController
    {
        private readonly GerasPokedexContext _context;

        public UserController(GerasPokedexContext context)
        {
            _context = context;
        }
    }
}