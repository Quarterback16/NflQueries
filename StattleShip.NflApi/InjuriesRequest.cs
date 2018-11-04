using Newtonsoft.Json;
using StattleShip.NflApi.Dtos;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace StattleShip.NflApi
{
	public class InjuriesRequest : BaseNflApiRequest
	{
		public List<InjuryDto> LoadData(string seasonSlug, string teamId = "")
		{
			var Injuries = new List<InjuryDto>();
			var qp = new StringBuilder();
			qp.Append($"season_id={seasonSlug}");
			if (!string.IsNullOrEmpty(teamId)) qp.Append($"&team_id={teamId}");
			var httpWebRequest = CreateRequest(
				apiRequest: "injuries",
				queryParms: qp.ToString());

			var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();

			using (var streamReader = new StreamReader(
				httpResponse.GetResponseStream()))
			{
				var json = streamReader.ReadToEnd();
				var dto = JsonConvert.DeserializeObject<InjuredPlayersDto>(
					json);

				Players = dto.Players;
				Injuries = dto.Injuries;
			}
			return Injuries;
		}
	}
}
