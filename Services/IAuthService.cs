using StudentRoutineTrackerApi.Models;

namespace StudentRoutineTrackerApi.Services
{
    public interface IAuthService
    {
        string HashPassword(string password);
        bool VerifyPassword(string password, string passwordHash);
        string GenerateJwtToken(User user);
    }
}
