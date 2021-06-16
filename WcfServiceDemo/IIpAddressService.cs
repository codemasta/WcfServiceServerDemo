using System.Runtime.Serialization;
using System.ServiceModel;

namespace WcfServiceDemo
{
    [ServiceContract]
    public interface IIpAddressService
    {
        [OperationContract]
        CompositeType GetIpAddress();
    }
   
    [DataContract]
    public class CompositeType
    {
        [DataMember]
        public string IpAddress
        {
            get;
            set;
        }
    }
    public class IpResponse
    { 
        public string Ip { get; set; }
    }
}
