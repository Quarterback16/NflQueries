using System;

namespace NflQueries.Domain
{
	public class Injury
	{
		public Player Player { get; set; }

		public string Note { get; set; }

		public string Location { get; set; }

		public string Status { get; set; }

		public DateTime StatusDate { get; set; }
	}
}
