using System;
using Domain.Enums;

namespace Domain.DTOs
{
    public class RaspberrypiOutputDTO
    {
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public Rasoerrypi_Modes Models { get; set; }

        public DateTime CreationDate { get; set; }
        public bool IsActive { get; set; }


        public string MessageResponse { get; set; } = string.Empty;
    }
}

