using Microsoft.VisualStudio.TestTools.UnitTesting;
using StattleShip.NflApi;

namespace NflQueries.IntegrationTests
{
	[TestClass]
	public class InjuriesTests
	{
		[TestMethod]
		public void Injuries_ForSeason2018_ReturnsInjuriesDto()
		{
			var sut = new InjuriesRequest();
			var result = sut.LoadData(
				Constants.Seasons.Season2018);
			Assert.IsNotNull(result);
			Assert.IsTrue(
				condition: result.Count > 0,
				message: "No Injuries returned");
			foreach (var injury in result)
			{
				System.Console.WriteLine(injury.Status + " " + injury.Note);
			}
		}
	}
}
