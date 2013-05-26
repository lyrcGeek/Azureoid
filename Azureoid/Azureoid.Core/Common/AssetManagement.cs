using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml.Linq;

namespace Azureoid.Core.Common
{
    public class AssetManagement
    {
        public static X509Certificate2 GetCertificate(XDocument xdoc)
        {
			var profile = xdoc.Descendants("PublishProfile").Single();
			var managementCertbase64String = profile.Attribute("ManagementCertificate").Value;
            Certificate = new X509Certificate2(Convert.FromBase64String(managementCertbase64String));
            return Certificate;
        }

        public static X509Certificate2 Certificate { get; set; }
    }
}
