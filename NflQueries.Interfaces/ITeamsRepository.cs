using NflQueries.Models;

namespace NflQueries.Interfaces
{
    public interface ITeamsRepository
    {
		TeamsViewModel FindTeams();
    }
}
