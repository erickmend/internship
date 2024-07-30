using System;
using DATA.Entities;
using Domain.DTOs;

namespace DATA.Services
{
    public class RaspberrypiService
    {
        public RaspberrypiService()
        {
        }


        public RaspberrypiOutputDTO Post(RaspberrypiDTO dto)
        {
            Raspberry_pi entity = new Raspberry_pi(dto);
            //guardar a la base de datos

            return new RaspberrypiOutputDTO
            {
                Id = entity.Id,
                Name = entity.Name,
                Models = entity.Models,
                CreationDate = entity.CreationDate,
                IsActive = entity.IsActive,
                MessageResponse = "Raspberry pi created!"
            };
        }
    }
}

