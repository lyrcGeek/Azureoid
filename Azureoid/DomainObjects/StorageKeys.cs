using System;

namespace Azureoid.DomainObjects.StorageKeys
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.microsoft.com/windowsazure")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace="http://schemas.microsoft.com/windowsazure", IsNullable=false)]
	public partial class StorageService {
		
		private string urlField;
		
		private StorageServiceStorageServiceKeys storageServiceKeysField;
		
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
		public StorageServiceStorageServiceKeys StorageServiceKeys {
			get {
				return this.storageServiceKeysField;
			}
			set {
				this.storageServiceKeysField = value;
			}
		}
	}
	
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.microsoft.com/windowsazure")]
	public partial class StorageServiceStorageServiceKeys {
		
		private string primaryField;
		
		private string secondaryField;
		
		/// <remarks/>
		public string Primary {
			get {
				return this.primaryField;
			}
			set {
				this.primaryField = value;
			}
		}
		
		/// <remarks/>
		public string Secondary {
			get {
				return this.secondaryField;
			}
			set {
				this.secondaryField = value;
			}
		}
	}

}

