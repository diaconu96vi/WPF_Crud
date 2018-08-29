using FriendOrganizer.DataAccess;
using FriendOrganizer.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace FriendOrganizer.UI.Data
{
  public class FriendDataService : IFriendDataService
  {
        public void Delete(Friend friend)
        {
            var DBItems = new FriendOrganizerDbContext();
            DBItems.Friends.Attach(friend);
            DBItems.Friends.Remove(friend);
            DBItems.SaveChanges();
        }

        /* Fancy async
private Func<FriendOrganizerDbContext> _contextCreator;

public FriendDataService(Func<FriendOrganizerDbContext> contextCreator)
{
 _contextCreator = contextCreator;
}
public async Task<List<Friend>> GetAllAsync()
{
 using (var ctx = _contextCreator())
 {

   return await ctx.Friends.AsNoTracking().ToListAsync();
 }
}
*/
        public IEnumerable<Friend> GetAll()
        {
            var DBItems = new FriendOrganizerDbContext();
            return DBItems.Friends.ToList();
        }
        public void SaveAsync(Friend friend)
        {
            var DBItems = new FriendOrganizerDbContext();
                DBItems.Friends.Attach(friend);
                DBItems.Entry(friend).State = EntityState.Modified;
                DBItems.SaveChangesAsync();
        }
    }
}
