using System;
using System.Collections;
using System.Collections.Specialized;
using System.IO;
using System.Net;
using System.Text;
using System.Data;
using System.Configuration;
using System.Web;
using WingtipToys;
using WingtipToys.Models;
using System.Collections.Generic;
using System.Linq;
using Braintree;

namespace WingtipToys.Logic
{
    public class ClientTokenHandler : IHttpHandler
    {
        BraintreeGateway gateway = new BraintreeGateway("access_token$sandbox$q9h79xnj9rn266mg$7d2b8f4cafad1b3f85f0de88bc554eea");

        public bool IsReusable => true;

        public void ProcessRequest(HttpContext context)
        {
            var clientToken = gateway.ClientToken.Generate();
            context.Response.Write(clientToken);
        }

      
    }

    public class PayPalBraintree
    {
    }
}