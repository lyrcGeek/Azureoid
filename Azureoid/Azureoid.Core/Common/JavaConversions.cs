using System;
using Java.Lang;

namespace Azureoid.Core.Common
{
	internal class JavaHolder : Java.Lang.Object
	{
		public readonly object Instance;
		
		public JavaHolder(object instance)
		{
			this.Instance = instance;
		}
	}	

	/// <summary>
	/// ObjectExtensions is a class that hosts extensions to convert
	/// native java objects to CLR and vice-versa
	/// </summary>
	public static class ObjectExtension
	{
		/// <summary>
		/// Converts a java (java.lang.object) to a .net (system.object)
		/// </summary>
		/// <returns>The net object.</returns>
		/// <param name="value">Object Value</param>
		/// <typeparam name="TObject">The object to apply the extension to</typeparam>
		public static TObject ToNetObject<TObject>(this Java.Lang.Object value)
		{
			if(value == null)
				return default(TObject);
			
			if(!(value is JavaHolder))
				throw new InvalidOperationException("Unable to convert to .NET object. Only Java.Lang.Object created with .ToJavaObject() can be converted.");
			
			return 
				(TObject)((JavaHolder)value).Instance;
		}

		/// <summary>
		/// Converts a .net (system.object) to a java (java.lang.object)
		/// </summary>
		/// <returns>The java object.</returns>
		/// <param name="value">Object Value</param>
		/// <typeparam name="TObject">The object to apply the extension to</typeparam>
		public static Java.Lang.Object ToJavaObject<TObject>(this TObject value)
		{
			if(value.Equals(null))
				return null;
			
			var holder = new JavaHolder(value);					
			
			return 
				(Java.Lang.Object)holder;
		}
	}
}

