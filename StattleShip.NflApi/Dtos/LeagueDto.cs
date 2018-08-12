using Newtonsoft.Json;
using System.Collections.Generic;

namespace StattleShip.NflApi.Dtos
{
	public class LeagueDto
	{
		[JsonProperty("id")]
		public string LeagueId { get; set; }

		[JsonProperty("abbreviation")]
		public string Abbreviation { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }
	}
}
