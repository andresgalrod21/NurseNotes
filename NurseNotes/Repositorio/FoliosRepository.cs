using Microsoft.EntityFrameworkCore;
using NurseNotes.Context;
using NurseNotes.Model;

namespace NurseNotes.Repositorio
{
    public interface IFoliosRepository
    {
        Task<List<Folios>> GetAll();
        Task<Folios> GetFolio(int FOLIO_ID);
        Task<Folios> CreateFolio(int FOLIO_ID, int INCOME_ID, int NOTE_ID, int SUP_ID, int USR_ID, string? EVOLUTION);
        Task<Folios> UpdateFolio(Folios folios);
        Task<Folios> DeleteFolio(int FOLIO_ID);
    }
    public class FoliosRepository : IFoliosRepository
    {
        private readonly TestDbNurseNotes _db;

        public FoliosRepository(TestDbNurseNotes db)
        {
            _db = db;
        }

        public async Task<List<Folios>> GetAll()
        {
            return await _db.Folios.ToListAsync();
        }

        public async Task<Folios> GetFolio(int FOLIO_ID)
        {
            return await _db.Folios.FirstOrDefaultAsync(f => f.FOLIO_ID == FOLIO_ID);
        }

        public async Task<Folios> CreateFolio(int FOLIO_ID, int INCOME_ID, int NOTE_ID, int SUP_ID, int USR_ID, string? EVOLUTION)
        {
            Incomes incomes = await _db.Incomes.FindAsync(INCOME_ID);
            if (incomes == null)
            {
                throw new Exception("Income not found");
            }

            NurseNote nurseNote = await _db.NurseNotes.FindAsync(NOTE_ID);
            if (nurseNote == null)
            {
                throw new Exception("Note not found");
            }

            SuppliesPatients suppliesPatients = await _db.SuppliesPatients.FindAsync(SUP_ID);
            if (suppliesPatients == null)
            {
                throw new Exception("Spplies not found");
            }

            Users users = await _db.Users.FindAsync(USR_ID);
            if (users == null)
            {
                throw new Exception("Income not found");
            }

            Folios newFolio = new Folios
            {
                FOLIO_ID = FOLIO_ID,
                INCOME_ID = INCOME_ID,
                NOTE_ID = NOTE_ID,
                SUP_ID = SUP_ID,
                USR_ID = USR_ID,
                EVOLUTION = EVOLUTION,
                Incomes = incomes,
                NurseNote = nurseNote,
                SuppliesPatients = suppliesPatients,
                Users = users
            };

            await _db.Folios.AddAsync(newFolio);
            await _db.SaveChangesAsync();

            return newFolio;
        }

        public async Task<Folios> UpdateFolio(Folios folios)
        {
            _db.Folios.Update(folios);
            await _db.SaveChangesAsync();
            return folios;
        }

        public async Task<Folios> DeleteFolio(int FOLIO_ID)
        {
            Folios folio = await GetFolio(FOLIO_ID);            
            _db.Folios.Remove(folio);
            await _db.SaveChangesAsync();
            

            return folio;
        }
    }
}
