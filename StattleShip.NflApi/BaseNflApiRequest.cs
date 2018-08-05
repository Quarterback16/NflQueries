using StattleShip.NflApi.Dtos;
using System;
using System.Collections.Generic;
using System.Net;

namespace StattleShip.NflApi
{
	public class BaseNflApiRequest
	{
		public List<TeamDto> Teams { get; set; }

		public HttpWebRequest CreateRequest(
			string apiRequest,
			string queryParms)
		{
			var apiKey = Environment.GetEnvironmentVariable("STATAPI");
			var url = $@"https://api.stattleship.com/{
				"football"
				}/{
				"nfl"
				}/{
				apiRequest
				}?{
				queryParms
				}";
			var httpWebRequest = (HttpWebRequest)WebRequest.Create(
				requestUriString: url);
			httpWebRequest.ContentType = "application/json";
			httpWebRequest.Accept = "application/vnd.stattleship.com; version=1";
			httpWebRequest.Method = "GET";
			httpWebRequest.Headers.Add(
				"Authorization",
				apiKey);
			//Console.WriteLine($"url:{url}");
			return httpWebRequest;
		}
	}
}
