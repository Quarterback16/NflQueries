using Newtonsoft.Json;
using StattleShip.NflApi.Dtos;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace StattleShip.NflApi
{
	public class RosterRequest : BaseNflApiRequest
	{
		public List<PlayerDto> LoadData(string seasonSlug, string teamSlug = "")
		{
			var qp = new StringBuilder();
			qp.Append($"season_id={seasonSlug}");
			if (!string.IsNullOrEmpty(teamSlug)) qp.Append($"&team_id={teamSlug}");
			qp.Append("&page=3");
			var httpWebRequest = CreateRequest(
				apiRequest: "rosters",
				queryParms: qp.ToString());

			var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();

			using (var streamReader = new StreamReader(
				httpResponse.GetResponseStream()))
			{
				var json = streamReader.ReadToEnd();
				var dto = JsonConvert.DeserializeObject<RosteredPlayersDto>(
					json);

				Players = dto.Players;
			}
			return Players;
		}
	}
}
