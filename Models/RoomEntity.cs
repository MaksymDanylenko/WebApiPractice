using System;

namespace WebApiPractice.Models
{
    public class RoomEntity
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public int Rate { get; set; }
    }
}