using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class TournamentModel
    {
        /// <summary>
        /// Come on, I mean, what could that possibly be? Take a guess, I'll wait.
        /// </summary>
        public string TournamentName { get; set; }
        /// <summary>
        /// This is the amount of money required from every participating party.
        /// </summary>
        public decimal EntryFee { get; set; }
        /// <summary>
        /// Represents the list of teams, which are in the tournament.
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();
        /// <summary>
        /// Represents the list of prizes available in this tournament.
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
        /// <summary>
        /// Represents the list of lists of matchups.
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();

    }
}
