using Newtonsoft.Json;

namespace StattleShip.NflApi.Dtos
{
	public class InjuryDto
	{
		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("player_id")]
		public string PlayerId { get; set; }

		[JsonProperty("location_name")]
		public string InjuredPart { get; set; }

		[JsonProperty("note")]
		public string Note { get; set; }

		[JsonProperty("status")]
		public string Status { get; set; }

		[JsonProperty("status_updated_at")]
		public string StatusDate { get; set; }
	}
}
