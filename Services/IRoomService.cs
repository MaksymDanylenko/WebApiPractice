using System;
using System.Threading.Tasks;
using WebApiPractice.Models;

namespace WebApiPractice.Services
{
    public interface IRoomService
    {
        Task<Room> GetRoomAsync(Guid id);
    }
}