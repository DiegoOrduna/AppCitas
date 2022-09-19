using AppCitas.service.Entities;

namespace AppCitas.service.Interfaces;

public interface ITokenService
{
    string CreateToken(AppUser user);
}
