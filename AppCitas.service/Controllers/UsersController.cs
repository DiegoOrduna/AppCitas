using AppCitas.service.Data;
using AppCitas.service.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AppCitas.service.Controllers;

public class UsersController : BaseApiController
{
    private readonly DataContext _context;
    public UsersController(DataContext context)
    {
        _context = context;
    }
    
    //GET api/users
    [HttpGet]
    public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
    {
        return await _context.Users.ToListAsync();
    }

    //GET api/users/id
    [HttpGet("{id}")]
    public async Task<ActionResult<AppUser>> GetUserById(int id)
    {
        return await _context.Users.FindAsync(id);
    }
}
