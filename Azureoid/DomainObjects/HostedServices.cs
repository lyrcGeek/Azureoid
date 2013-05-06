using System;

namespace Azureoid
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.microsoft.com/windowsazure")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace="http://schemas.microsoft.com/windowsazure", IsNullable=false)]
	public partial class HostedServices {
		
		private HostedServicesHostedService hostedServiceField;
		
		/// <remarks/>
		public HostedServicesHostedService HostedService {
			get {
				return this.hostedServiceField;
			}
			set {
				this.hostedServiceField = value;
			}
		}
	}
	
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.microsoft.com/windowsazure")]
	public partial class HostedServicesHostedService {
		
		private string urlField;
		
		private string serviceNameField;
		
		private HostedServicesHostedServiceHostedServiceProperties hostedServicePropertiesField;
		
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
		public HostedServicesHostedServiceHostedServiceProperties HostedServiceProperties {
			get {
				return this.hostedServicePropertiesField;
			}
			set {
				this.hostedServicePropertiesField = value;
			}
		}
	}
	
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.microsoft.com/windowsazure")]
	public partial class HostedServicesHostedServiceHostedServiceProperties {
		
		private string descriptionField;
		
		private string locationField;
		
		private string labelField;
		
		private string statusField;
		
		private System.DateTime dateCreatedField;
		
		private System.DateTime dateLastModifiedField;
		
		private object extendedPropertiesField;
		
		/// <remarks/>
		public string Description {
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
		public System.DateTime DateCreated {
			get {
				return this.dateCreatedField;
			}
			set {
				this.dateCreatedField = value;
			}
		}
		
		/// <remarks/>
		public System.DateTime DateLastModified {
			get {
				return this.dateLastModifiedField;
			}
			set {
				this.dateLastModifiedField = value;
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
	}

}

