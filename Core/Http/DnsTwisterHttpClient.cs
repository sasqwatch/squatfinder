﻿using RestSharp;
using SquatFinder.Web.Core.Models;

namespace SquatFinder.Web.Core.Http
{
	public class DnsTwisterHttpClient : ITwisterHttpClient
	{
		private const string BaseUrl = "http://dnstwister.report/api/fuzz/";

		public FuzzyResponseWrapper GetFuzzyDomains(string domainName)
		{
			var url = BaseUrl + domainName;
			var client = new RestClient(url);
			var request = new RestRequest(Method.GET);

			var response = client.Execute<FuzzyResponseWrapper>(request);

			return response.Data;
		}
	}
}