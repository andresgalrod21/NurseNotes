using NurseNotes.Model;
using NurseNotes.Repositorio;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NurseNotes.Services
{
    public interface IPatientsService
    {
        Task<List<Patients>> GetAll();
        Task<Patients> GetPatient(int PATIENT_ID);
        Task<Patients> CreatePatient(Patients patient);
        Task<Patients> UpdatePatient(Patients patient);
        Task<Patients> DeletePatient(int PATIENT_ID);

    }
    public class PatientsService : IPatientsService
    {
        private readonly IPatientsRepository _patientsRepository;

        public PatientsService(IPatientsRepository patientsRepository)
        {
            _patientsRepository = patientsRepository;
        }

        public async Task<List<Patients>> GetAll()
        {
            return await _patientsRepository.GetAll();
        }

        public async Task<Patients> GetPatient(int PATIENT_ID)
        {
            return await _patientsRepository.GetPatient(PATIENT_ID);
        }

        public async Task<Patients> CreatePatient(Patients patient)
        {
            return await _patientsRepository.CreatePatient(
                patient.PATIENT_ID, patient.NAME, patient.LASTNAME,
                patient.TIPDOC_ID, patient.NUMDOC, patient.AGE,
                patient.NUMCONTACT, patient.MAIL);
        }

        public async Task<Patients> UpdatePatient(Patients patient)
        {
            return await _patientsRepository.UpdatePatient(patient);
        }

        public async Task<Patients> DeletePatient(int PATIENT_ID)
        {
            return await _patientsRepository.DeletePatient(PATIENT_ID);
        }
    }
}
