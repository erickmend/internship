using System;
using Domain.DTOs;
using Domain.Enums;

namespace DATA.Entities
{
	public class Arduino
	{
		public Arduino(ArduinoDTO dto)
		{
			Id = Guid.NewGuid().ToString();
			Name = dto.Name;
			Type = dto.Type;
			Price = dto.Price;


			CreationDate = DateTime.Now;
			IsActive = false;
		}

		public string Id { get; set; }
		public string Name { get; set; }
        public double Price { get; set; }
        public ArduinoType Type { get; set; }

		public DateTime CreationDate { get; set; }
		public bool IsActive { get; set; }
	}
}

