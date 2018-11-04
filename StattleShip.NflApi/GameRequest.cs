using Newtonsoft.Json;
using StattleShip.NflApi.Dtos;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace StattleShip.NflApi
{
	public class GameRequest : BaseNflApiRequest
	{
		public List<GameDto> LoadData(string seasonSlug, int week = 0)
		{
			//var response = new GamesViewModel();
			var qp = new StringBuilder();
			qp.Append($"season_id={seasonSlug}");
			if (week > 0) qp.Append($"&week={week}");
			var httpWebRequest = CreateRequest(
				apiRequest: "games",
				queryParms: qp.ToString());

			var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();

			using (var streamReader = new StreamReader(
				httpResponse.GetResponseStream()))
			{
				var json = streamReader.ReadToEnd();
				var dto = JsonConvert.DeserializeObject<GameStatsDto>(
					json);

				Games = dto.Games;
			}
			return Games;
		}
	}
}
