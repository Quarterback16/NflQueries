using Newtonsoft.Json;

namespace StattleShip.NflApi.Dtos
{
	public class PlayerDto
	{
		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("first_name")]
		public string FirstName { get; set; }

		[JsonProperty("last_name")]
		public string LastName { get; set; }

	}
}
