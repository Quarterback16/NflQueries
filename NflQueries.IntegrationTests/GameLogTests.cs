using Microsoft.VisualStudio.TestTools.UnitTesting;
using StattleShip.NflApi;

namespace NflQueries.IntegrationTests
{
	[TestClass]
	public class GameLogTests
	{
		[TestMethod]
		public void GameLogs_ForSeason2017_ReturnsTeamsDto()
		{
			var sut = new GameLogRequest();
			var result = sut.LoadData(Constants.Seasons.Season2017);
			Assert.IsNotNull(result);
			Assert.IsTrue(result.Count > 0);
		}
	}
}
