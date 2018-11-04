using Newtonsoft.Json;
using System.Collections.Generic;


namespace StattleShip.NflApi.Dtos
{
	public class GameStatsDto
	{
		[JsonProperty("games")]
		public List<GameDto> Games { get; set; }

		[JsonProperty("home_teams")]
		public List<TeamDto> HomeTeams { get; set; }

		[JsonProperty("away_teams")]
		public List<TeamDto> AwayTeams { get; set; }

		[JsonProperty("winning_teams")]
		public List<TeamDto> WinningTeams { get; set; }

		[JsonProperty("leagues")]
		public List<LeagueDto> Leagues { get; set; }
	}
}
