using Microsoft.VisualStudio.TestTools.UnitTesting;
using StattleShip.NflApi;

namespace NflQueries.IntegrationTests
{
	[TestClass]
	public class GamesTests
	{
		[TestMethod]
		public void Games_ForSeason2018_ReturnsGamesDto()
		{
			var sut = new GameRequest();
			var result = sut.LoadData(
				Constants.Seasons.Season2018);
			Assert.IsNotNull(result);
			Assert.IsTrue(result.Count > 0);
			foreach (var game in result)
			{
				System.Console.WriteLine(game.Name + " " + game.Score);
			}
		}

		[TestMethod]
		public void Games_ForWeek201809_ReturnsGamesDto()
		{
			var sut = new GameRequest();
			var result = sut.LoadData(
				Constants.Seasons.Season2018,
				week:9);
			Assert.IsNotNull(result);
			Assert.IsTrue(result.Count > 0);
			foreach (var game in result)
			{
				System.Console.WriteLine(game.Name + " " + game.Score);
			}
		}
	}
}
