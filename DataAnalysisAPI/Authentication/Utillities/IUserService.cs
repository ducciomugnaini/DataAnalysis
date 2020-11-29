using DataAnalysisAPI.Authentication.Entity;
using DataAnalysisAPI.Authentication.Model;
using System.Collections.Generic;

namespace DataAnalysisAPI.Authentication.Utillities
{
    public interface IUserService
    {
        AuthenticateResponse Authenticate(AuthenticateRequest model);
        IEnumerable<User> GetAll();
        User GetById(int id);
    }
}
