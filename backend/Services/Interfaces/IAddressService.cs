using backend.Models;
using System.Threading.Tasks;

namespace backend.Services.Interfaces
{
    public interface IAddressService
    {
        Task<Address> GetAddressByIdAsync(int addressId);
    }
}