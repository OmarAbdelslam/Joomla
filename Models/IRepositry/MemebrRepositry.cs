using Microsoft.EntityFrameworkCore;
using Mobile_Market.Models;
using Mobile_Market.Models.DBwork;

namespace Mobil_Market.Models.IRepositry
{
    public class MemebrRepositry : IRepositryDBcontext<Member>
    {
        private readonly dbcontext db;
        public MemebrRepositry(dbcontext _db)
        {
            db = _db;
        }

        public void Add(Member entity)
        {
            db.members.Add(entity);
            db.SaveChanges();

        }

        public void Delete(string id)
        {
            db.members.Remove(Get(id));
            db.SaveChanges();
        }

        public Member Get(string id)
        {
            return db.members.SingleOrDefault(m => m.memberId == id);
        }

        public IEnumerable<Member> GetAllList()
        {
         return   db.members.ToList();
        }

        public void Update(string id, Member entity)
        {
             db.members.Update(entity);
            db.SaveChanges();
        }

    }
}
