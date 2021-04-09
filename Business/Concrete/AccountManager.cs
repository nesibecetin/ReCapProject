using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class AccountManager : IAccountService
    {
        IAccountDal _accountDal;
        public AccountManager(IAccountDal accountDal)
        {
            _accountDal = accountDal;
        }
        public IResult Add(Account account)
        {
            _accountDal.Add(account);
            return new SuccessResult(Messages.AccountAdded);
        }

        public IResult Delete(Account account)
        {
            _accountDal.Delete(account);
            return new SuccessResult(Messages.AccountDeleted);
        }

        public IDataResult<List<Account>> GetAll()
        {
            return new SuccessDataResult<List<Account>>(_accountDal.GetAll(),Messages.AccountListed);
        }

        public IDataResult<Account> GetById(int id)
        {
            return new SuccessDataResult<Account>(_accountDal.Get(a=>a.AccountId==id), Messages.AccountListed);
        }

        public IDataResult<List<Account>> GetByUserId(int customerId)
        {
            return new SuccessDataResult<List<Account>>(_accountDal.GetAll(a => a.CustomerId == customerId), Messages.AccountListed);
        }

        public IResult Update(Account account)
        {
            _accountDal.Update(account);
            return new SuccessResult(Messages.AccountUpdated);
        }
    }
}
