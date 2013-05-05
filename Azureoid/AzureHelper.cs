using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml.Linq;
using Android.OS;
using Android.App;

namespace Azureoid
{
    public class AzureHelper
    {
        public static string GetRunningServices(X509Certificate2 certificate, string subscriptionId)
        {
            // Request and response variables.
            HttpWebRequest httpWebRequest = null;
            HttpWebResponse httpWebResponse = null;

            // Stream variables.
            Stream responseStream = null;
            StreamReader reader = null;

            // URI variable.
            Uri requestUri = null;

            // Specify operation to use for the service management call.
            // This sample will use the operation for listing the hosted services.
            //string operation = "hostedservices";
			string operation = "hostedservices";

            // The thumbprint for the certificate. This certificate would have been
            // previously added as a management certificate within the Windows Azure management portal.
			Console.WriteLine("Using certificate with thumbprint: " + certificate.Thumbprint);

            // Create the request.
            requestUri = new Uri("https://management.core.windows.net/"
                                 + subscriptionId
                                 + "/services/"
                                 + operation);

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
    }
}
