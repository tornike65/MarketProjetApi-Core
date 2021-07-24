using MarketProj.DAL.Database;
using MarketProj.DAL.Repositories.Abstract;
using MarketProj.DAL.Repositories.Abstract.Base;
using MarketProj.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarketProj.DAL.Repositories.Concrete
{
    public class TemporaryUserRepository : BaseRepository<TemporaryUser>, ITemporaryUserRepository
    {
        public TemporaryUserRepository(UsersDB userDB) : base(userDB)
        {

        }
    }
}
