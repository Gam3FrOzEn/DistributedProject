using ApplicationService.DTOs;
using Data.Context;
using Data.Entities;
using Repository.Implementations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationService.Implementations
{
    public class ClientManagementService
    {
        private HotDogDBContext ctx = new HotDogDBContext();

        public List<ClientDTO> Get(string filter)
        {
            List<ClientDTO> clientsDTO = new List<ClientDTO>();

            using (UnitOfWork unitofwork = new UnitOfWork())
            {

                foreach  (var item in unitofwork.ClientRepository.Get(x => x.Name.Contains(filter)))
                    {
                    clientsDTO.Add(new ClientDTO
                    {
                        Id = item.Id,
                        Name = item.Name,
                        Age = item.Age,
                        Email = item.Email,
                        Number = item.Number,
                        City = item.City,
                        Neighborhood = item.Neighborhood,
                        Street = item.Street
                    });
                }
            }
            return clientsDTO;
        }

        public ClientDTO GetById(int id)
        {
            ClientDTO clientDTO = new ClientDTO();

            //Client client = ctx.Clients.Find(id);
            using (UnitOfWork unitofwork = new UnitOfWork())
            {
                Client client = unitofwork.ClientRepository.GetByID(id);
                if (client != null)
                {
                    clientDTO.Id = client.Id;
                    clientDTO.Name = client.Name;
                    clientDTO.Age = client.Age;
                    clientDTO.Email = client.Email;
                    clientDTO.Number = client.Number;
                    clientDTO.City = client.City;
                    clientDTO.Neighborhood = client.Neighborhood;
                    clientDTO.Street = client.Street;
                }
            }
            return clientDTO;
        }
        public bool Save(ClientDTO clientDto)
        {
            Client client = new Client
            {
                Name = clientDto.Name,
                Age = clientDto.Age,
                Email = clientDto.Email,
                Number = clientDto.Number,
                City = clientDto.City,
                Neighborhood = clientDto.Neighborhood,
                Street = clientDto.Street
            };
        
            try
            {
                using (UnitOfWork unitofwork = new UnitOfWork())
                {
                    unitofwork.ClientRepository.Insert(client);
                    unitofwork.Save();
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                using (UnitOfWork unitofwork = new UnitOfWork())
                {
                    Client client = unitofwork.ClientRepository.GetByID(id);
                    unitofwork.ClientRepository.Delete(client);
                    unitofwork.Save();
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool EditClient(ClientDTO clientDto)
        {
            Client client = new Client
            {
                Id = clientDto.Id,
                Name = clientDto.Name,
                Age = clientDto.Age,
                Email = clientDto.Email,
                Number = clientDto.Number,
                City = clientDto.City,
                Neighborhood = clientDto.Neighborhood,
                Street = clientDto.Street
            };
            try
            {
                using (UnitOfWork unitofwork = new UnitOfWork())
                {
                    unitofwork.ClientRepository.Update(client);
                    unitofwork.Save();
                }

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
