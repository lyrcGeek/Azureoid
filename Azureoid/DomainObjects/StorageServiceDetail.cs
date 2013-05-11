using System;
using System.Xml.Serialization;

namespace Azureoid
{
	// 
	// This source code was auto-generated by xsd, Version=4.0.30319.17929.
	// 

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.microsoft.com/windowsazure")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace="http://schemas.microsoft.com/windowsazure", IsNullable=false)]
	public partial class StorageService {
		
		private string urlField;
		
		private string serviceNameField;
		
		private StorageServiceStorageServiceProperties storageServicePropertiesField;
		
		private object extendedPropertiesField;
		
		private StorageServiceCapabilities capabilitiesField;
		
		/// <remarks/>
		public string Url {
			get {
				return this.urlField;
			}
			set {
				this.urlField = value;
			}
		}
		
		/// <remarks/>
		public string ServiceName {
			get {
				return this.serviceNameField;
			}
			set {
				this.serviceNameField = value;
			}
		}
		
		/// <remarks/>
		public StorageServiceStorageServiceProperties StorageServiceProperties {
			get {
				return this.storageServicePropertiesField;
			}
			set {
				this.storageServicePropertiesField = value;
			}
		}
		
		/// <remarks/>
		public object ExtendedProperties {
			get {
				return this.extendedPropertiesField;
			}
			set {
				this.extendedPropertiesField = value;
			}
		}
		
		/// <remarks/>
		public StorageServiceCapabilities Capabilities {
			get {
				return this.capabilitiesField;
			}
			set {
				this.capabilitiesField = value;
			}
		}
	}
	
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.microsoft.com/windowsazure")]
	public partial class StorageServiceStorageServiceProperties {
		
		private object descriptionField;
		
		private string locationField;
		
		private string labelField;
		
		private string statusField;
		
		private string[] endpointsField;
		
		private bool geoReplicationEnabledField;
		
		private string geoPrimaryRegionField;
		
		private object statusOfPrimaryField;
		
		private string geoSecondaryRegionField;
		
		private object statusOfSecondaryField;
		
		private System.DateTime creationTimeField;
		
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
		public object Description {
			get {
				return this.descriptionField;
			}
			set {
				this.descriptionField = value;
			}
		}
		
		/// <remarks/>
		public string Location {
			get {
				return this.locationField;
			}
			set {
				this.locationField = value;
			}
		}
		
		/// <remarks/>
		public string Label {
			get {
				return this.labelField;
			}
			set {
				this.labelField = value;
			}
		}
		
		/// <remarks/>
		public string Status {
			get {
				return this.statusField;
			}
			set {
				this.statusField = value;
			}
		}
		
		/// <remarks/>
		[System.Xml.Serialization.XmlArrayItemAttribute("Endpoint", IsNullable=false)]
		public string[] Endpoints {
			get {
				return this.endpointsField;
			}
			set {
				this.endpointsField = value;
			}
		}
		
		/// <remarks/>
		public bool GeoReplicationEnabled {
			get {
				return this.geoReplicationEnabledField;
			}
			set {
				this.geoReplicationEnabledField = value;
			}
		}
		
		/// <remarks/>
		public string GeoPrimaryRegion {
			get {
				return this.geoPrimaryRegionField;
			}
			set {
				this.geoPrimaryRegionField = value;
			}
		}
		
		/// <remarks/>
		public object StatusOfPrimary {
			get {
				return this.statusOfPrimaryField;
			}
			set {
				this.statusOfPrimaryField = value;
			}
		}
		
		/// <remarks/>
		public string GeoSecondaryRegion {
			get {
				return this.geoSecondaryRegionField;
			}
			set {
				this.geoSecondaryRegionField = value;
			}
		}
		
		/// <remarks/>
		public object StatusOfSecondary {
			get {
				return this.statusOfSecondaryField;
			}
			set {
				this.statusOfSecondaryField = value;
			}
		}
		
		/// <remarks/>
		public System.DateTime CreationTime {
			get {
				return this.creationTimeField;
			}
			set {
				this.creationTimeField = value;
			}
		}
	}
	
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.microsoft.com/windowsazure")]
	public partial class StorageServiceCapabilities {
		
		private string capabilityField;
		
		/// <remarks/>
		public string Capability {
			get {
				return this.capabilityField;
			}
			set {
				this.capabilityField = value;
			}
		}
	}

}
