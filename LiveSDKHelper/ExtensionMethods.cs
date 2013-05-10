using System;
using System.Collections.Generic;
using System.Text;

namespace LiveSDKHelper
{
    public static class ExtensionMethods
    {
        /// <summary>
        /// Creates a string from the sequence by concatenating the result
        /// of the specified string selector function for each element.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source">The source.</param>
        /// <param name="stringSelector">The string selector.</param>
        /// <param name="separator">
        /// The string which separates each concatenated item.
        /// Optional; default is string.Empty
        /// </param>
        /// <returns></returns>
        public static string ToConcatenatedString<T>(this IEnumerable<T> source,
            Func<T, string> stringSelector,
            string separator = "")
        {
            var b = new StringBuilder();

            foreach (var item in source)
            {
                b.Append(stringSelector(item) + separator);
            }

            return b.ToString().Trim(separator.ToCharArray());
        }

        public static string ToStringScope(this Scope scope)
        {
            var scopeName = scope.GetAttribute<ScopeNameAttribute>();

            return scopeName == null ? string.Empty : scopeName.ScopeName;
        }

        internal static UriBuilder SetQueryParam(this UriBuilder uri, string key, string value)
        {
            var collection = uri.ParseQuery();

            // add (or replace existing) key-value pair
            collection[key] = value;

            var query = collection
                .ToConcatenatedString(pair =>
                                      pair.Key == null
                                          ? pair.Value
                                          : pair.Key + "=" + pair.Value, "&");

            uri.Query = query;

            return uri;
        }

        internal static IEnumerable<KeyValuePair<string, string>> GetQueryParams(
            this UriBuilder uri)
        {
            return uri.ParseQuery();
        }

        internal static Dictionary<string, string> ParseQuery(this UriBuilder uri)
        {
            var nameValueCollection = new Dictionary<string, string>();
            string[] items = uri.Query.Split('&');

            foreach (string item in items)
            {
                if (item.Contains("="))
                {
                    string[] nameValue = item.Split('=');
                    if (nameValue[0].Contains("?"))
                        nameValue[0] = nameValue[0].Replace("?", "");
                    nameValueCollection.Add(nameValue[0], (nameValue[1]));
                }
            }

            return nameValueCollection;
        }
    }
}
