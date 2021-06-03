using ApplicationService.DTOs;
using Data.Context;
using Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationService.Implementations
{
    public class SaleManagementService
    {
        private HotDogDBContext ctx = new HotDogDBContext();

        public List<SaleDTO> Get(string filter)
        {
            List<SaleDTO> saleDTOs = new List<SaleDTO>();
            var SaleList = ctx.Sales.Include(x => x.HotDog).Include(x => x.Client).ToList();//eager loading
            foreach (var item in SaleList.Where(x => x.Client.Name.Contains(filter)))
            {
                saleDTOs.Add(new SaleDTO
                {
                    Id = item.Id,
                    Quantity = item.Quantity,
                    Date = item.Date,
                    FinalPrice = item.FinalPrice,
                    HotDogId = item.HotDogId,
                    ClientId = item.ClientId,
                    HotDog = new HotDogDTO
                    {
                        Id = item.HotDogId,
                        Title = item.HotDog.Title,
                        Sauce = item.HotDog.Sauce,
                        Spice = item.HotDog.Spice,
                        Price = item.HotDog.Price,
                        SausageType = item.HotDog.SausageType,
                        BunType = item.HotDog.BunType
                    },
                    Client = new ClientDTO
                    {
                        Id = item.ClientId,
                        Name = item.Client.Name,
                        Age = item.Client.Age,
                        Email = item.Client.Email,
                        Number = item.Client.Number,
                        City = item.Client.City,
                        Neighborhood = item.Client.Neighborhood,
                        Street = item.Client.Street
                    }
                });

            }
            return saleDTOs;
        }

        public SaleDTO GetById(int id)
        {
            Sale sale = ctx.Sales.Where(x => x.Id == id).Include(x => x.HotDog).Include(x => x.Client).FirstOrDefault();

            //SaleDTO saleDTO = new SaleDTO();

            SaleDTO saleDTO = new SaleDTO
            {
                Id = sale.Id,
                Quantity = sale.Quantity,
                Date = sale.Date,
                FinalPrice = sale.FinalPrice,
                HotDogId = sale.HotDogId,
                ClientId = sale.ClientId
            };

            //Sale sale = ctx.Sales.Find(id);
            //if (sale != null)
            //{
            //    saleDTO.Id = sale.Id;
            //    saleDTO.Quantity = sale.Quantity;
            //    saleDTO.Cost = sale.Cost;
            //    saleDTO.FinalPrice = sale.FinalPrice;
            //    saleDTO.HotDogId = sale.HotDogId;
            //    saleDTO.ClientId = sale.ClientId;
            //}
            return saleDTO;
        }

        public bool Save(SaleDTO saleDto)
        {
            //if (saleDto.HotDog == null || saleDto.HotDog.Id == 0)
            //{
            //    return false;
            //}

            //HotDog hot = new HotDog
            //{
            //    Id = saleDto.HotDog.Id,
            //    Title = saleDto.HotDog.Title
            //};

            Sale sale = new Sale
            {
                //Name = saleDto.Name,
                Quantity = saleDto.Quantity,
                Date = saleDto.Date,
                FinalPrice = saleDto.FinalPrice,
                HotDogId = saleDto.HotDogId,
                ClientId = saleDto.ClientId,
            };

            try
            {
                ctx.Sales.Add(sale);
                ctx.SaveChanges();

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
                Sale sale = ctx.Sales.Find(id);
                ctx.Sales.Remove(sale);
                ctx.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool EditSale(SaleDTO saleDto)
        {
            Sale sale = new Sale
            {
                Id = saleDto.Id,
                Quantity = saleDto.Quantity,
                Date = saleDto.Date,
                FinalPrice = saleDto.FinalPrice,
                HotDogId = saleDto.HotDogId,
                ClientId = saleDto.ClientId
            };
            try
            {
                ctx.Sales.Attach(sale);
                ctx.Entry(sale).State = EntityState.Modified;
                ctx.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
