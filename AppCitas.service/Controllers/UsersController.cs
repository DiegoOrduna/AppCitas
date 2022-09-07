using AppCitas.service.Data;
using AppCitas.service.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SQLitePCL;

namespace AppCitas.service.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
    private readonly DataContext _context;
    public UsersController(DataContext context)
    {
        _context = context;
    }
    [HttpGet]
    public ActionResult<IEnumerable<AppUser>> GetUsers()
    {
        return _context.Users.ToList();
    }
}
