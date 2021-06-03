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
    public class HotDogManagementService
    {
        private HotDogDBContext ctx = new HotDogDBContext(); // instanciq na context

        public List<HotDogDTO> Get(string filter) // shte ni vrushta vsichki zapisi
        {
            List<HotDogDTO> hotdogsDto = new List<HotDogDTO>(); // izvikva contexta ?

            using (UnitOfWork unitofwork = new UnitOfWork())
            {
                foreach (var item in unitofwork.HotDogRepository.Get(x => x.Title.Contains(filter))) // shte vzemem vsichki rezultati ot balicata HotDogs
                {

                    hotdogsDto.Add(new HotDogDTO
                    {
                        Id = item.Id,
                        Title = item.Title,
                        Sauce = item.Sauce,
                        Spice = item.Spice,
                        Price = item.Price,
                        SausageType = item.SausageType,
                        BunType = item.BunType
                    });

                }
            }
            return hotdogsDto; // vrushta ni rezultatite v list
        }

        public HotDogDTO GetById(int id)
        {
            HotDogDTO hotDogDTO = new HotDogDTO();

            using(UnitOfWork unitofwork = new UnitOfWork())
            {
                HotDog hotDog = unitofwork.HotDogRepository.GetByID(id);
                if (hotDog != null)
                {
                    hotDogDTO.Id = hotDog.Id;
                    hotDogDTO.Title = hotDog.Title;
                    hotDogDTO.Sauce = hotDog.Sauce;
                    hotDogDTO.Spice = hotDog.Spice;
                    hotDogDTO.Price = hotDog.Price;
                    hotDogDTO.SausageType = hotDog.SausageType;
                    hotDogDTO.BunType = hotDog.BunType;
                }
            }
            return hotDogDTO;
        }

        public bool Save(HotDogDTO hotDogDTO)
        {
            HotDog HotDog = new HotDog
            {
                
                Title = hotDogDTO.Title,
                Sauce = hotDogDTO.Sauce,
                Spice = hotDogDTO.Spice,
                Price = hotDogDTO.Price,
                SausageType = hotDogDTO.SausageType,
                BunType = hotDogDTO.BunType
            };

            try
            {
                using (UnitOfWork unitofwork = new UnitOfWork())
                { 
                    unitofwork.HotDogRepository.Insert(HotDog);
                    unitofwork.Save();
                }

                return true;
            }
            catch
            {
                //Console.WriteLine(HotDog);
                return false;
            }
        }

        public bool Delete(int id)
        {

            try
            {
                using (UnitOfWork unitofwork = new UnitOfWork())
                {
                    HotDog hotDog = unitofwork.HotDogRepository.GetByID(id);
                    unitofwork.HotDogRepository.Delete(hotDog);
                    unitofwork.Save();
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool EditHotDog(HotDogDTO hotDogDTO)
        {
            HotDog hotDog = new HotDog
            {
                Id = hotDogDTO.Id,
                Title = hotDogDTO.Title,
                Sauce = hotDogDTO.Sauce,
                Spice = hotDogDTO.Spice,
                Price = hotDogDTO.Price,
                SausageType = hotDogDTO.SausageType,
                BunType = hotDogDTO.BunType
            };
            try
            {
                using(UnitOfWork unitofwork = new UnitOfWork())
                {
                    unitofwork.HotDogRepository.Update(hotDog);
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
