using System;

namespace LiveSDKHelper
{
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
	internal sealed class ScopeNameAttribute : Attribute
	{
		private readonly string scopeName;

		internal ScopeNameAttribute(string scopeName)
		{
			this.scopeName = scopeName;
		}

		public string ScopeName
		{
			get { return this.scopeName; }
		}
	}
}
