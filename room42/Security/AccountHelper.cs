using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using Data.Models;
using Infrastructure.Interfaces;
using Ninject;

namespace room42.Security
{
    public class AccountHelper
    {
        
        protected readonly HashAlgorithm _hashAlgorithm;
        [Inject]
        protected IRepository _repository;

        public AccountHelper()
        {
            _hashAlgorithm = HashAlgorithm.Create("123");
           // _repository = repository;
        }

        public string GetUserHash(string username)
        {
            var user = _repository.Single<User>(x => x.UserName.Equals(username));
            return user.PasswordHash;
        }
    }
}