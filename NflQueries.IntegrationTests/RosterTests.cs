using Microsoft.VisualStudio.TestTools.UnitTesting;
using StattleShip.NflApi;

namespace NflQueries.IntegrationTests
{
	[TestClass]
	public class RosterTests
	{
		[TestMethod]
		public void NinersRoster_ForSeason2018_ReturnsDto()
		{
			var sut = new RosterRequest();
			var result = sut.LoadData(
				Constants.Seasons.Season2018,
				"nfl-sf");
			Assert.IsNotNull(result);
			Assert.IsTrue(result.Count > 0);
			var p = 0;
			foreach (var player in result)
			{
				p++;
				System.Console.WriteLine($"{p:#0} {player.Name}");
			}
		}
	}

}
