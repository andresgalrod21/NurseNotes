using NurseNotes.Model;
using NurseNotes.Repositorio;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NurseNotes.Services
{
    public interface IMedicationsService
    {
        Task<List<Medications>> GetAll();
        Task<Medications> GetMedication(int MED_ID);
        Task<Medications> CreateMedication(Medications medication);
        Task<Medications> UpdateMedication(Medications Medication);
        Task<Medications> DeleteMedication(int MED_ID);

    }
    public class MedicationsService : IMedicationsService
    {
        private readonly IMedicationsRepository _medicationsRepository;

        public MedicationsService(IMedicationsRepository medicationsRepository)
        {
            _medicationsRepository = medicationsRepository;
        }

        public async Task<List<Medications>> GetAll()
        {
            return await _medicationsRepository.GetAll();
        }

        public async Task<Medications> GetMedication(int MED_ID)
        {
            return await _medicationsRepository.GetMedication(MED_ID);
        }

        public async Task<Medications> CreateMedication(Medications medication)
        {
            return await _medicationsRepository.CreateMedication(
                medication.MED_ID, medication.MEDDSC, medication.STOCK);
        }

        public async Task<Medications> UpdateMedication(Medications medication)
        {
            return await _medicationsRepository.UpdateMedication(medication);
        }

        public async Task<Medications> DeleteMedication(int MED_ID)
        {
            return await _medicationsRepository.DeleteMedication(MED_ID);
        }
    }
}
