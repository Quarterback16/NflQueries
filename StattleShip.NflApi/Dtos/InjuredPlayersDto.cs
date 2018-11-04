using System.Collections.Generic;
using Newtonsoft.Json;

namespace StattleShip.NflApi.Dtos
{
	public class InjuredPlayersDto
	{
		[JsonProperty("players")]
		public List<PlayerDto> Players { get; set; }

		[JsonProperty("injuries")]
		public List<InjuryDto> Injuries { get; set; }
	}
}
