using Newtonsoft.Json;

namespace StattleShip.NflApi.Dtos
{
	public class GameLogDto
	{
		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("game_id")]
		public string GameId { get; set; }

		[JsonProperty("player_id")]
		public string PlayerId { get; set; }

		[JsonProperty("team_id")]
		public string TeamId { get; set; }
	}
}
