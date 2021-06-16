using Newtonsoft.Json;
using System.Net;

namespace WcfServiceDemo
{
    public class IpAddressService : IIpAddressService
    {
        public const string ApiUrl = "https://api.ipify.org/?format=json";
        public CompositeType GetIpAddress()
        {
            using (var client = new WebClient())
            {
                var jsonResponse = client.DownloadString(ApiUrl);
                var response = JsonConvert.
                    DeserializeObject<IpResponse>(jsonResponse);
                return new CompositeType() {IpAddress = response.Ip};
            }
        }
    }
}
