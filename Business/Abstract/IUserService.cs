using Core.Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IUserService
    {
        //result döndür->refactor
        List<OperationClaim> GetClaims(User user);
        void Add(User user);
        User GetByMail(string email);
    }
}
