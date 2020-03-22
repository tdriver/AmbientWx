using Newtonsoft.Json;
using System;
using System.Configuration;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AmbientWx.Util
{
    /// <summary>
    /// Utilities to help create the service calls.
    /// </summary>
    public static class Networking
    {
        public static string ApiKey { get; set; }
        public static string ApplicationKey { get; set; }
        public static Uri BaseUri { get; set; }
        public static string MacAddress { get; set; }

        static Networking()
        {
            Init();
        }
        public static void Init()
        {
            try
            {
                var efm = new ExeConfigurationFileMap { ExeConfigFilename = "AmbientWx.config" };
                var configuration = ConfigurationManager.OpenMappedExeConfiguration(efm, ConfigurationUserLevel.None);
                AppSettingsSection asc = (AppSettingsSection)configuration.GetSection("appSettings");
                ApiKey = asc.Settings["ApiKey"].Value;
                if (string.IsNullOrEmpty(ApiKey))
                {
                    throw new ArgumentNullException("The ApiKey is not defined in the configuration file.");
                }

                ApplicationKey = asc.Settings["ApplicationKey"].Value;
                if (string.IsNullOrEmpty(ApplicationKey))
                {
                    throw new ArgumentNullException("The ApplicationKey is not defined in the configuration file.");
                } 

                MacAddress = asc.Settings["MacAddress"].Value;
                
                var url = asc.Settings["BaseUrl"].Value;
                if (string.IsNullOrEmpty(url))
                {
                    throw new ArgumentNullException("The BaseUrl is not defined in the configuration file.");
                }
                BaseUri = new Uri(url);

            }catch(Exception e){
                throw new ConfigurationErrorsException("There is an error with the configuration file.",e);
            }
        }

        /// <summary>
        /// Makes a HTTP GET call to the specified uri address.
        /// </summary>
        /// <param name="address">The URI to call</param>
        /// <typeparam name="R">The type of return object expected.</typeparam>
        /// <returns>A deserialized object of type "R", returned from the service call.</returns>
        public static async Task<R> HttpGetCall<R>(Uri address){
            using (var client = new HttpClient())
            {
                try	
                {
                    var jsonResponse = await client.GetStringAsync(address);
                    return JsonConvert.DeserializeObject<R>(jsonResponse);
                }  
                catch(HttpRequestException e)
                {
                    throw new WebException("An error occurred calling the URI: " + address.ToString(), e);
                }
            }
        }

        /// <summary>
        /// Build the correct URI for an AmbientWx api service call
        /// </summary>
        /// <param name="relativeUri">The relative uri to call</param>
        /// <param name="queryParameters">Even-numbered list of key/value query parameters.</param>
        /// <returns>Fully-formed URI ready to be used in a service call.</returns>
        public static Uri GetFullUri(string relativeUri, params string[] queryParameters)
        {
            var query = new StringBuilder("?applicationKey=" + ApplicationKey + "&apiKey=" + ApiKey);
            
            if(queryParameters.Length > 0){

                if(queryParameters.Length % 2 != 0)
                    throw new ArgumentException("queryParameters must be an even-numbered list of key/value pairs.");

                for (var i = 0; i < queryParameters.Length - 1; i+=2)
                {
                    query.Append("&"+queryParameters[i]);
                    query.Append("="+queryParameters[i+1]);
                }               
            }
            return new Uri(BaseUri, relativeUri + query.ToString());
        }
                                           
    }
}
