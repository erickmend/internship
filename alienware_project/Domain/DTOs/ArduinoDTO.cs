using System;
using Domain.Enums;

namespace Domain.DTOs
{
	public class ArduinoDTO
	{
        public string Name { get; set; } = string.Empty;

        public double Price { get; set; }
        public ArduinoType Type { get; set; }
    }
}

