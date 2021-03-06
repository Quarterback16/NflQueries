﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace StattleShip.NflApi.Dtos
{
	public class TeamStatsDto
	{
		[JsonProperty("teams")]
		public List<TeamDto> Teams { get; set; }

		[JsonProperty("leagues")]
		public List<LeagueDto> Leagues { get; set; }
	}
}
