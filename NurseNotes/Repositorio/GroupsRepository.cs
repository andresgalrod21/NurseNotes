using Microsoft.EntityFrameworkCore;
using NurseNotes.Context;
using NurseNotes.Model;

namespace NurseNotes.Repositorio
{
    public interface IGroupsRepository
    {
        Task<List<Groups>> GetAll();
        Task<Groups> GetGroup(int GRP_ID);
        Task<Groups> CreateGroup(int GRP_ID, string GRPDSC);
        Task<Groups> UpdateGroup(Groups groups);
        Task<Groups> DeleteGroup(int GRP_ID);

    }
    public class GroupsRepository : IGroupsRepository
    {
        private readonly TestDbNurseNotes _db;
        public GroupsRepository(TestDbNurseNotes db)    
        {
            _db = db;
        }

        public async Task<List<Groups>> GetAll()
        {
            return await _db.Groups.ToListAsync();
        }

        public async Task<Groups> GetGroup(int GRP_ID)
        {
            return await _db.Groups.FirstOrDefaultAsync(g => g.GRP_ID == GRP_ID);
        }

        public async Task<Groups> CreateGroup(int GRP_ID, string GRPDSC)
        {
            Groups newGroup = new Groups
            {
                GRP_ID = GRP_ID,
                GRPDSC = GRPDSC
            };

            await _db.Groups.AddAsync(newGroup);
            await _db.SaveChangesAsync();

            return newGroup;
        }

        public async Task<Groups> UpdateGroup(Groups groups)
        {
            _db.Groups.Update(groups);
            await _db.SaveChangesAsync();
            return groups;
        }

        public async Task<Groups> DeleteGroup(int GRP_ID)
        {
            Groups group = await GetGroup(GRP_ID);          
            _db.Groups.Remove(group);
            await _db.SaveChangesAsync();
            
            return group;
        }
    }
}
