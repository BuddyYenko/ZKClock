using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ZK_Door_API.Controllers
{
    public class DoorController : ApiController
    {
        public ZkemClient client;
        // POST api/Door
        public void Post(string ipAddress,int port,string qrcode)
        {
            client = new ZkemClient(null);
            client.Connect_Net(ipAddress, port);
            if(ValidateQrCode(qrcode))
            {
                client.ACUnlock(1, 3);
            }
        }

        private bool ValidateQrCode(string qrcode)
        {
            return true;
        }
    }
}
