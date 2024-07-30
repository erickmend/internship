using System;
using Domain.DTOs;
using Domain.Enums;

namespace DATA.Entities
{
    public class Raspberry_pi
    {
        public Raspberry_pi(RaspberrypiDTO dto)
        {
            Id = Guid.NewGuid().ToString();

            Name = dto.Name;
            Models = dto.Models;

            CreationDate = DateTime.Now;
            IsActive = false;
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public Rasoerrypi_Modes Models { get; set; }

        public DateTime CreationDate { get; set; }
        public bool IsActive { get; set; }
    }
}

