using Newtonsoft.Json;
using System.Collections.Generic;

namespace StattleShip.NflApi.Dtos
{
	public class GameLogsDto
	{
		[JsonProperty("teams")]
		public List<TeamDto> Teams { get; set; }

		[JsonProperty("leagues")]
		public List<LeagueDto> Leagues { get; set; }

		[JsonProperty("game_logs")]
		public List<GameLogDto> GameLogs { get; set; }
	}
}
