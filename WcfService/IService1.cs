using ApplicationService.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here

        [OperationContract]
        List<HotDogDTO> GetHotDogs(string filter);

        [OperationContract]
        string PostHotDog(HotDogDTO hotDogDTO);

        [OperationContract]
        string PutHotDog(HotDogDTO HotDogDto);

        [OperationContract]
        HotDogDTO GetHotDogByID(int id);

        [OperationContract]
        string DeleteHotDog(int id);

        // gfgfd

        [OperationContract]
        List<ClientDTO> GetClients(string filter);

        [OperationContract]
        ClientDTO GetClientByID(int id);

        [OperationContract]
        string PostClient(ClientDTO clientDto);

        [OperationContract]
        string PutClient(ClientDTO clientDTO);

        [OperationContract]
        string DeleteClient(int id);

         // kgfgldf

        [OperationContract]
        List<SaleDTO> GetSales(string filter);

        [OperationContract]
        string PostSale(SaleDTO saleDto);

        [OperationContract]
        SaleDTO GetSaleById(int id);

        [OperationContract]
        string DeleteSale(int id);

        [OperationContract]
        string PutSale(SaleDTO saleDto);
    }



    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "WcfService.ContractType".
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
