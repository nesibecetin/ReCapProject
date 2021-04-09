using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IAccountService
    {
        IDataResult<List<Account>> GetAll();
        IDataResult<List<Account>> GetByUserId(int userId);
        IDataResult<Account> GetById(int id);
        IResult Add(Account account);
        IResult Delete(Account account);
        IResult Update(Account account);
    }
}
