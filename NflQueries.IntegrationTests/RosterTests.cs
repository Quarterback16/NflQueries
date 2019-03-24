using Microsoft.VisualStudio.TestTools.UnitTesting;
using StattleShip.NflApi;
using System;

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
			DumpPlayerDto(result);
		}

		private static void DumpPlayerDto(
			System.Collections.Generic.List<StattleShip.NflApi.Dtos.PlayerDto> result )
		{
			var p = 0;
			foreach (var player in result)
			{
				if (!player.Active)
					continue;
				p++;
				System.Console.WriteLine(
					$@"{p:00} {player.UniformNumber,2} {player.Name,-25} {player.Position, -3} {
						player.HeightInFeet(),5
						} {
						player.Weight
						} {
						player.BirthDate
						}");
			}
		}

		[TestMethod]
		public void ChiefsRoster_ForSeason2018_ReturnsDto()
		{
			var sut = new RosterRequest();
			var result = sut.LoadData(
				Constants.Seasons.Season2018,
				"nfl-kc");
			Assert.IsNotNull(result);
			Assert.IsTrue(result.Count > 0);
			DumpPlayerDto(result);
		}

		[TestMethod]
		public void PlayerQueryHandler_ReturnsPlayer()
		{
			var query = new PlayerQuery(
				teamCode: "SF",
				firstName: "Nick",
				lastName: "Mullens");
			var sut = new PlayerQueryHandler();
			var result = sut.Handle(query);
			Assert.IsNotNull(result);
			Assert.IsTrue(result.IsActive);
			Assert.AreEqual(
				expected: new DateTime(1995,3,21),
				actual: result.BirthDate);
		}

		[TestMethod]
		public void PlayerQueryHandler_ReturnsPlayer2()
		{
			var query = new PlayerQuery(
				teamCode: "SF",
				firstName: "George",
				lastName: "Kittle");
			var sut = new PlayerQueryHandler();
			var result = sut.Handle(query);
			Assert.IsNotNull(result);
			Assert.IsTrue(result.IsActive);
			Assert.AreEqual(
				expected: new DateTime(1993, 10, 9),
				actual: result.BirthDate);
		}
	}

}
