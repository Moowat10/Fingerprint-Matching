using FingerprintMatchingEngine.Data;
using FingerprintMatchingEngine.Interface;
using FingerprintMatchingEngine.Models;

namespace FingerprintMatchingEngine.Repository
{
    public class FingerRepository :  Repository<Finger> , IFingerRepository
    {
        public FingerRepository(DataContext context) : base(context)
        {
        }
        

    }
}
