using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Linq;
using System.Xml.Linq;
using Android.OS;
using Android.App;
using System.Xml.Serialization;
using System.Dynamic;

namespace Azureoid
{
	//TODO: Instead of passing the certificate to all calls, find a way to define it once on the AzureHelperclass
	//Or simply implement the certificate on the certificate store and retrieve it on each method

    public class AzureHelper
    {
		/// <summary>
		/// Helper to perform HTTP Calls to the Azure Management Service. 
		/// </summary>
		/// <returns>The http call.</returns>
		/// <param name="certificate">Certificate.</param>
		/// <param name="subscriptionId">Subscription identifier.</param>
		/// <param name="requestUri">Request URI.</param>
		public static string PerformHttpCall(X509Certificate2 certificate, string subscriptionId, Uri requestUri)
		{
			// Request and response variables.
			HttpWebRequest httpWebRequest = null;
			HttpWebResponse httpWebResponse = null;
			
			// Stream variables.
			Stream responseStream = null;
			StreamReader reader = null;

			// The thumbprint for the certificate. This certificate would have been
			// previously added as a management certificate within the Windows Azure management portal.
			Console.WriteLine("Using certificate with thumbprint: " + certificate.Thumbprint);

			httpWebRequest = (HttpWebRequest)WebRequest.Create(requestUri);
			
			// Add the certificate to the request.
			httpWebRequest.ClientCertificates.Add(certificate);
			
			// Specify the version information in the header.
			httpWebRequest.Headers.Add("x-ms-version", "2013-03-01");
			
			// Make the call using the web request.
			httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			
			// Display the web response status code.
			Console.WriteLine("Response status code: " + httpWebResponse.StatusCode);
			
			// Display the request ID returned by Windows Azure.
			if (null != httpWebResponse.Headers)
			{
				Console.WriteLine("x-ms-request-id: "
				                  + httpWebResponse.Headers["x-ms-request-id"]);
			}
			
			// Parse the web response.
			responseStream = httpWebResponse.GetResponseStream();
			reader = new StreamReader(responseStream);
			// Display the raw response.
			
			var str = reader.ReadToEnd();
			
			// Close the resources no longer needed.
			httpWebResponse.Close();
			responseStream.Close();
			reader.Close();
			
			return str;
		}

		/// <summary>
		/// Gets the hosted services on the Azure Subscription
		/// </summary>
		/// <returns>The hosted services.</returns>
		/// <param name="certificate">Certificate.</param>
		/// <param name="subscriptionId">Subscription identifier.</param>
		public static HostedServices GetHostedServices(X509Certificate2 certificate, string subscriptionId)
        {
			HostedServices services;

            // Create the request.
            var requestUri = new Uri("https://management.core.windows.net/"
                                 + subscriptionId
                                 + "/services/hostedservices");

			//Receive response from server
			var xmlResponse = PerformHttpCall(certificate, subscriptionId, requestUri);
			
			//Serialize and return response
			var serializer = new XmlSerializer(typeof(HostedServices));
			using (var memStream = new MemoryStream(Encoding.UTF8.GetBytes(xmlResponse)))
			{
				services = (HostedServices)serializer.Deserialize(memStream);
			}
			return services;
        }

		/// <summary>
		/// Gets the storage account list on the Azure Subscription
		/// </summary>
		/// <returns>The hosted services.</returns>
		/// <param name="certificate">Certificate.</param>
		/// <param name="subscriptionId">Subscription identifier.</param>
		public static StorageServices GetStorageAccounts(X509Certificate2 certificate, string subscriptionId)
		{
			StorageServices services;

			// Create the request.
			var requestUri = new Uri("https://management.core.windows.net/"
			                         + subscriptionId
			                         + "/services/storageservices");

			//Query the Azure Server
			var xmlResponse = PerformHttpCall(certificate, subscriptionId, requestUri);

			//Serialize and return response
			var serializer = new XmlSerializer(typeof(StorageServices));
			using (var memStream = new MemoryStream(Encoding.UTF8.GetBytes(xmlResponse)))
			{
				services = (StorageServices)serializer.Deserialize(memStream);
			}
			return services;
		}

		/// <summary>
		/// Gets information for a specific storage account (details)
		/// </summary>
		/// <param name="certificate">Certificate.</param>
		/// <param name="subscriptionId">Subscription identifier.</param>
		public static StorageService GetStorageAccountDetail(X509Certificate2 certificate, string subscriptionId, string storageName)
		{
			StorageService service;

			var requestUri = new Uri("https://management.core.windows.net/"
			                         + subscriptionId 
			                         + "/services/storageservices/"
			                         + storageName);

			//Query the Azure Server
			var httpResponse = PerformHttpCall(certificate, subscriptionId, requestUri);
			var serializer = new XmlSerializer(typeof(StorageService));
			using (var memStream = new MemoryStream(Encoding.UTF8.GetBytes(httpResponse)))
			{
				//TODO: Stop using the memory stream here, instead do an overload for PerformHttpCall to return a proper XDocument
				service = (StorageService)serializer.Deserialize(memStream);
			}

			//Serialize and return response
			return service;
		}

		/// <summary>
		/// Gets access keys for a storage account (details)
		/// </summary>
		/// <param name="certificate">Certificate.</param>
		/// <param name="subscriptionId">Subscription identifier.</param>
		public static dynamic GetStorageAccountKeys(X509Certificate2 certificate, string subscriptionId, string storageName)
		{
			Azureoid.DomainObjects.StorageKeys.StorageService service;

			//TODO: This call is exactly like the one before. Find a pattern and reduce boilerplate
			var requestUri = new Uri("https://management.core.windows.net/"
			                         + subscriptionId 
			                         + "/services/storageservices/"
			                         + storageName
			                         + "/keys");
			
			//Query the Azure Server
			var httpResponse = PerformHttpCall(certificate, subscriptionId, requestUri);
			var serializer = new XmlSerializer(typeof(Azureoid.DomainObjects.StorageKeys.StorageService));
			using (var memStream = new MemoryStream(Encoding.UTF8.GetBytes(httpResponse)))
			{
				//TODO: Automatically serialized files using XSD.EXE have a tendency to be too long
				//Also, there's unnecessary/verbose/repetitive code, and we need to add additional namespace
				//just to prevent name clashes with the partial classes
				service = (Azureoid.DomainObjects.StorageKeys.StorageService)serializer.Deserialize(memStream);
			}
			
			//Serialize and return response
			return service;
		}
    }
}
