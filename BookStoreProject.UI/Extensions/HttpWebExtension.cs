using System;
using System.Net;

namespace BookStoreProject.UI.Extensions
{
	public static class HttpWebExtension
	{
		public static bool IsUrlReachable(this string Url)
		{
			var request = (HttpWebRequest)WebRequest.Create(Url);
			request.Timeout = 10_000;
			request.Method = "HEAD";

			try
			{
				using var response = (HttpWebResponse) request.GetResponse();
				return response.StatusCode == HttpStatusCode.OK;
			}
			catch (WebException)
			{
				return false;
			}
		}
	}
}