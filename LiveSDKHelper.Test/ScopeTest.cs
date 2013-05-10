using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

// ReSharper disable CheckNamespace
namespace LiveSDKHelper.Test.ScopeEnum
{
	[TestClass]
	public class ScopeTest
	{
		[TestMethod]
		public void MustAllHaveScopeNameAttribute()
		{
			var scopeValues = Enum.GetValues(typeof(Scope));
			var scopes = scopeValues.Cast<Scope>().ToList();

			var scopesWithName = new List<Scope>(scopes.Where(scope => scope.ToStringScope() != string.Empty));

			Assert.AreEqual(scopes.Count, scopesWithName.Count);
		}

		[TestMethod]
		public void MustEachHaveUniqueScopeName()
		{
			var scopeValues = Enum.GetValues(typeof(Scope));
			var scopes = scopeValues.Cast<Scope>().ToList();

			var scopeNames = new List<string>();
			foreach (var scope in scopes)
			{
				if (scopeNames.Contains(scope.ToStringScope())) { continue; }

				scopeNames.Add(scope.ToStringScope());
			}

			Assert.AreEqual(scopes.Count, scopeNames.Count);
		}
	}
}
