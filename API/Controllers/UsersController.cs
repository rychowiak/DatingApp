using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
  [ApiController]
  [Route("api/[controller]")] // GET /api/users
  public class UsersController : ControllerBase
  {
    private readonly DataContext _context;
    public UsersController(DataContext context)
    {
      _context = context;
    }

    [HttpGet] // API endpoint
    public async  Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
    {
      return await _context.Users.ToListAsync();
    }

    [HttpGet("{id}")] // /api/users/{id}
    public async Task<ActionResult<AppUser>> GetUser(int id)
    {
      return await _context.Users.FindAsync(id);
    }
  }
}