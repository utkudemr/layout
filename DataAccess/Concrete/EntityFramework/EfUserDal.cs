using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Microsoft.EntityFrameworkCore;
using Remotion.Linq.Parsing.Structure.IntermediateModel;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal:EfEntityRepositoryBase<User,WeeklyContext>,IUserDal
    {
        public List<string> GetClaims(int opId)
        {
            using (var context = new WeeklyContext())
            {
                var result = context.ClaimArea.Where(a => a.OperationClaimId == opId).Select(a=>a.Area.Name).ToList();
                
                return result;

            }
        }


        public List<User> GetAllUserWithClaims()
        {
            using (var context = new WeeklyContext())
            {
                var result = context.Users.Include(a => a.OperationClaim).Where(a => a.Status == true).ToList(); ;
                return result;

            }
        }

      public User Login(string username,string password)
        {
            using (var context = new WeeklyContext())
            {
                var result = context.Users.FirstOrDefault(a => a.SESANo == username && a.Password == password && a.Status==true);
                //result.OperationClaim.ClaimArea = context.ClaimArea.Include(a=>a.Area).Where(a => a.OperationClaimId == result.OperationClaimId).ToList();

                return result;
            }
        }
        public User GetUserWithClaims(int id)
        {
            using (var context = new WeeklyContext())
            {
                var result = context.Users.Include(a => a.OperationClaim).Include(a => a.OperationClaim).FirstOrDefault(a=>a.Status==true && a.Id==id);
                return result;

            }
        }
    }
}
