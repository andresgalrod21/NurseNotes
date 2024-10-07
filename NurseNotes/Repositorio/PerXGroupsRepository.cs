using Microsoft.EntityFrameworkCore;
using NurseNotes.Context;
using NurseNotes.Model;
using System.Text.RegularExpressions;

namespace NurseNotes.Repositorio
{
    public interface IPerXGroupsRepository
    {
        Task<List<PerXGroups>> GetAll();
        Task<PerXGroups> GetPerXGroup(int PG_ID);
        Task<PerXGroups> CreatePerXGroup(int PG_ID, int GRP_ID, int PER_ID);
        Task<PerXGroups> UpdatePerXGroup(PerXGroups PerXGroups);
        Task<PerXGroups> DeletePerXGroup(int PG_ID);

    }
    public class PerXGroupsRepository : IPerXGroupsRepository
    {
        private readonly TestDbNurseNotes _db;
        public PerXGroupsRepository(TestDbNurseNotes db)
        {
            _db = db;
        }
        public async Task<List<PerXGroups>> GetAll()
        {
            return await _db.PerXGroups.ToListAsync();
        }

        public async Task<PerXGroups> GetPerXGroup(int PG_ID)
        {
            return await _db.PerXGroups.FirstOrDefaultAsync(pg => pg.PG_ID == PG_ID);
        }

        public async Task<PerXGroups> CreatePerXGroup(int PG_ID, int GRP_ID, int PER_ID)
        {
            Groups Groups = await _db.Groups.FindAsync(GRP_ID);
            if (Groups == null)
            {
                throw new Exception("Group not found");
            }

            Permitions Permitions = await _db.Permitions.FindAsync(PER_ID);
            if (Permitions == null)
            {
                throw new Exception("Permition not found");
            }

            PerXGroups newPerXGroup = new PerXGroups
            {
                PG_ID = PG_ID,
                GRP_ID = GRP_ID,
                PER_ID = PER_ID,
                Groups = Groups,
                Permitions = Permitions
            };

            await _db.PerXGroups.AddAsync(newPerXGroup);
            await _db.SaveChangesAsync();

            return newPerXGroup;
        }

        public async Task<PerXGroups> UpdatePerXGroup(PerXGroups perXGroups)
        {
            _db.PerXGroups.Update(perXGroups);
            await _db.SaveChangesAsync();
            return perXGroups;
        }

        public async Task<PerXGroups> DeletePerXGroup(int PG_ID)
        {
            PerXGroups perXGroups = await GetPerXGroup(PG_ID);
            _db.PerXGroups.Remove(perXGroups);
            await _db.SaveChangesAsync();

            return perXGroups;
        }
    }
}
