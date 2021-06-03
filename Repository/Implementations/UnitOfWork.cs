using Data.Context;
using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Implementations
{
    public class UnitOfWork : IDisposable
    {
        private HotDogDBContext context = new HotDogDBContext();
        private GenericRepository<HotDog> hotDogRepository;
        private GenericRepository<Client> clientRepository;
        private GenericRepository<Sale> saleRepository;

        public GenericRepository<HotDog> HotDogRepository
        {
            get
            {

                if (this.hotDogRepository == null)
                {
                    this.hotDogRepository = new GenericRepository<HotDog>(context);
                }
                return hotDogRepository;
            }
        }

        public GenericRepository<Client> ClientRepository
        {
            get
            {

                if (this.clientRepository == null)
                {
                    this.clientRepository = new GenericRepository<Client>(context);
                }
                return clientRepository;
            }
        }

        public GenericRepository<Sale> SaleRepository
        {
            get
            {

                if (this.saleRepository == null)
                {
                    this.saleRepository = new GenericRepository<Sale>(context);
                }
                return saleRepository;
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
