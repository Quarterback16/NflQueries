using Newtonsoft.Json;

namespace StattleShip.NflApi.Dtos
{
	public class GameDto
	{
		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("attendance")]
		public string Attendance { get; set; }

		[JsonProperty("label")]
		public string Label { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("score")]
		public string Score { get; set; }
	}
}
