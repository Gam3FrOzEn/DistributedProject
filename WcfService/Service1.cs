using ApplicationService.DTOs;
using ApplicationService.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        private HotDogManagementService hotDogService = new HotDogManagementService();
       
        public List<HotDogDTO> GetHotDogs(string filter)
        {
            return hotDogService.Get(filter);
        }

        public string PostHotDog(HotDogDTO hotDogDTO)
        {
            if(!hotDogService.Save(hotDogDTO))
                return "HotDog is not inserted!";
            
            return "HotDog is inserted!";
         }

        public string PutHotDog(HotDogDTO hotDogDto)
        {
            if (!hotDogService.EditHotDog(hotDogDto))
                return "HotDog is not updated!";

            return "HotDog is updated!";
        }

        public string DeleteHotDog(int id)
        {
            if (!hotDogService.Delete(id))
            return "HotDog is not deleted!";
            
            return "HotDog is deleted!";
        }

        public HotDogDTO GetHotDogByID(int id)
        {
            return hotDogService.GetById(id);
        }

        private ClientManagementService clientService = new ClientManagementService();
        
        public List<ClientDTO> GetClients(string filter)
        {
            return clientService.Get(filter);
        }

        public string PostClient(ClientDTO clientDto)
        {
            if (!clientService.Save(clientDto))
                return "Client is not inserted";

            return "Client is inserted";
        }

        public string PutClient(ClientDTO clientDto)
        {
            if (!clientService.EditClient(clientDto))
                return "Client is not updated!";

            return "Client is updated!";
        }
        public string DeleteClient(int id)
        {
            if (!clientService.Delete(id))
                return "Client is not deleted";

            return "Client is deleted";
        }

        public ClientDTO GetClientByID(int id)
        {
            return clientService.GetById(id);
        }

        private SaleManagementService saleService = new SaleManagementService();
        public List<SaleDTO> GetSales(string filter)
        {
            return saleService.Get(filter);
        }

        public string PostSale(SaleDTO saleDTO)
        {
            if (!saleService.Save(saleDTO))
                return "Sale is not saved";

            return "Sale is saved";
        }

        public SaleDTO GetSaleById(int id)
        {
            return saleService.GetById(id);
        }

        public string DeleteSale(int id)
        {
            if (!saleService.Delete(id))
                return "Sale is not deleted!";

            return "Sale is deleted!";
        }

        public string PutSale(SaleDTO saleDto)
        {
            if (!saleService.EditSale(saleDto))
                return "Sale is not updated!";

            return "Sale is updated!";
        }
    }
}
