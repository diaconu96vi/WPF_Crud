using System.Collections.Generic;
using FriendOrganizer.Model;
using System.Threading.Tasks;

namespace FriendOrganizer.UI.Data
{
  public interface IFriendDataService
  {
        /* Fancy way
     Task<List<Friend>> GetAllAsync();
     */
     IEnumerable<Friend> GetAll();
        void SaveAsync(Friend friend);
        void Delete(Friend friend);
  }
}