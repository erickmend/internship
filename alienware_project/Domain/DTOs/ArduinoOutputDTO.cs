using System;
using Domain.Enums;

namespace Domain.DTOs
{
	public class ArduinoOutputDTO
	{
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;

        public double Price { get; set; } 

        public ArduinoType Type { get; set; }

        public DateTime CreationDate { get; set; }
        public bool IsActive { get; set; }


        public string MessageResponse { get; set; } = string.Empty;
    }
}

