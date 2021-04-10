using Core.Entities.Concrete;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
        List<OperationClaim> GetClaims(User user);
        void Add(User user);
        IDataResult<User> GetByMail(string email);

        IDataResult<User> GetById(int userId);
        IResult Update(User user);
    }
}
