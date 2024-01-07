using FingerprintMatchingEngine.DTO;
using FingerprintMatchingEngine.Interface;
using FingerprintMatchingEngine.Models;
using FingerprintMatchingEngine.Repository;

namespace FingerprintMatchingEngine.Services
{
    public class FingerServices : IFingerServices
    {
        private readonly IFingerRepository _fingerRepository;

        public FingerServices(IFingerRepository fingerRepository)
        {
            _fingerRepository = fingerRepository;
        }

        public async Task<IEnumerable<Finger>> GetFingersAsync()
        {
            var fingers = await _fingerRepository.GetAllAsync();
            return fingers;
        }

        public async Task<Finger> GetFingerByIdAsync(int id)
        {
            var finger = await _fingerRepository.GetByIdAsync(id);
            return finger;
        }

        public async Task<Finger> AddFingerAsync(NewFingerDTO finger)
        {
            var newFinger = new Finger
            {
                EmpolyeeID = finger.EmpolyeeID,
                LedgerID = finger.LedgerID,
                EmployeeFinger = finger.EmployeeFinger,
            };
            newFinger = await _fingerRepository.AddAsync(newFinger);
            return newFinger;
        }

        public async Task<Finger> UpdateFingerAsync(int id, Finger finger)
        {
            var existingFinger = await _fingerRepository.UpdateAsync(id, finger);
            return existingFinger;
        }

        public async Task<bool> DeleteFingerAsync(int id)
        {
            var result = await _fingerRepository.DeleteAsync(id);
            return result;
        }
    }
}
