using Newtonsoft.Json;
using System;

namespace StattleShip.NflApi.Dtos
{
	public class PlayerDto
	{
		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("uniform_number")]
		public string UniformNumber { get; set; }

		[JsonProperty("first_name")]
		public string FirstName { get; set; }

		[JsonProperty("last_name")]
		public string LastName { get; set; }

		[JsonProperty("birth_date")]
		public string BirthDate { get; set; }

		[JsonProperty("active")]
		public bool Active { get; set; }

		[JsonProperty("position_abbreviation")]
		public string Position { get; set; }

		[JsonProperty("weight")]
		public string Weight { get; set; }

		[JsonProperty("height")]
		public string Height { get; set; }

		public string HeightInFeet()
		{
			if (string.IsNullOrEmpty(Height))
				return "?";

			var feet = Int32.Parse(Height) / 12;
			var inches = Int32.Parse(Height) % 12;
			return $"{feet} {inches}";
		}
	}
}
