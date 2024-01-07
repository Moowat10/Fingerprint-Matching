using FingerprintMatchingEngine.DTO;
using FingerprintMatchingEngine.Models;

namespace FingerprintMatchingEngine.Interface
{
    public interface IFingerServices
    {
        Task<IEnumerable<Finger>> GetFingersAsync();
        Task<Finger> GetFingerByIdAsync(int fingerId);
        Task<Finger> AddFingerAsync(NewFingerDTO user);
        Task<Finger> UpdateFingerAsync(int fingerId, Finger userDTO);
        Task<bool> DeleteFingerAsync(int fingerId);
    }
}
