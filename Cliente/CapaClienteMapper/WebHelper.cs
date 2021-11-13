using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos
{
    internal class WebHelper 
    //es internal porque solamente me interesa
    //que el acceso a HTTP se de en la capa de datos
    {
        static WebClient client;
        static string rutaBase;

        static WebHelper()
        {
            client = new WebClient();
            client.Encoding = Encoding.UTF8;
            rutaBase = "https://cai-api.azurewebsites.net/api/v1/";
            //rutaBase = ConfigurationManager.AppSettings["URL_API"];

            client.Headers.Add("ContentType", "application/json");
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
        }

        internal static string Get(string url)
        {
            var uri = rutaBase + url;

            var responseString = client.DownloadString(uri);

            return responseString;
        }

        internal static string Post(string url, NameValueCollection parametros)
        {
            string uri = rutaBase + url;

            try
            {
                var response = client.UploadValues(uri, parametros);

                var responseString = Encoding.Default.GetString(response);

                return responseString;
            }
            catch (Exception ex)
            {
                return "{ \"isOk\":false,\"id\":-1,\"error\":\"Error en el llamado al servicio\"}";
            }
        }

        internal static string Put(string url, NameValueCollection parametros)
        {
            string uri = rutaBase + url;

            try
            {
                var response = client.UploadValues(uri, "PUT", parametros);

                var responseString = Encoding.Default.GetString(response);

                return responseString;
            }
            catch (Exception ex)
            {
                return "{ \"isOk\":false,\"id\":-1,\"error\":\"Error en el llamado al servicio\"}";
            }
        }

        internal static string Delete(string url, NameValueCollection parametros)
        {
            string uri = rutaBase + url;

            try
            {
                var response = client.UploadValues(uri, "DELETE", parametros);

                var responseString = Encoding.Default.GetString(response);

                return responseString;
            }
            catch (Exception ex)
            {
                return "{ \"isOk\":false,\"id\":-1,\"error\":\"Error en el llamado al servicio\"}";
            }
        }
    }
}
