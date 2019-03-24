using Microsoft.VisualStudio.TestTools.UnitTesting;
using StattleShip.NflApi;

namespace NflQueries.IntegrationTests
{
	[TestClass]
	public class TeamsTests
	{
		[TestMethod]
		public void Teams_ForSeason2016_ReturnsTeamsDto()
		{
			var sut = new TeamsRequest();
			var result = sut.LoadData(Constants.Seasons.Season2016);
			Assert.IsNotNull(result);
			Assert.IsTrue(result.Count > 0);
		}

		[TestMethod]
		public void Teams_ForSeason2017_ReturnsTeamsDto()
		{
			var sut = new TeamsRequest();
			var result = sut.LoadData(Constants.Seasons.Season2017);
			Assert.IsNotNull(result);
			Assert.IsTrue(result.Count > 0);
		}

		[TestMethod]
		public void Teams_ForSeason2018_ReturnsTeamsDto()
		{
			var sut = new TeamsRequest();
			var result = sut.LoadData(Constants.Seasons.Season2018);
			Assert.IsNotNull(result);
			Assert.IsTrue(result.Count > 0);
			foreach (var team in result)
				System.Console.WriteLine(team);
		}

		[TestMethod]
		public void Teams_ForSeason2019_ReturnsTeamsDto()
		{
			var sut = new TeamsRequest();
			var result = sut.LoadData(Constants.Seasons.Season2019);
			Assert.IsNotNull(result);
			Assert.IsTrue(result.Count > 0);
			foreach (var team in result)
				System.Console.WriteLine(team);
		}

	}
}
