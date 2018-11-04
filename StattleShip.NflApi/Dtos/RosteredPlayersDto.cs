using System.Collections.Generic;
using Newtonsoft.Json;


namespace StattleShip.NflApi.Dtos
{
	public class RosteredPlayersDto
	{
		[JsonProperty("players")]
		public List<PlayerDto> Players { get; set; }

	}
}
