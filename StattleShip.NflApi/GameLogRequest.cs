using Newtonsoft.Json;
using NflQueries.Models;
using StattleShip.NflApi.Dtos;
using System.Collections.Generic;
using System.IO;
using System.Net;


namespace StattleShip.NflApi
{
	public class GameLogRequest : BaseNflApiRequest
	{
		public List<TeamDto> LoadData(string seasonSlug)
		{
			var response = new TeamsViewModel();

			var httpWebRequest = CreateRequest(
				apiRequest: "game_logs",
				queryParms: $"season_id={seasonSlug}");

			var httpResponse = (HttpWebResponse) httpWebRequest.GetResponse();

			using (var streamReader = new StreamReader(
				httpResponse.GetResponseStream()))
			{
				var json = streamReader.ReadToEnd();
				var dto = JsonConvert.DeserializeObject<TeamStatsDto>(
					json);

				Teams = dto.Teams;
				Leagues = dto.Leagues;
			}
			return Teams;
		}
	}
}

