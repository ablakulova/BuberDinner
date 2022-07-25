using BuberDinner.Domain.Entities.Entities;

namespace BuberDinner.Application.Common.Interfaces.Authentication
{
    public interface IJwtTokenGenerator
    {
        string GenerateToken(User user);
    }
}
