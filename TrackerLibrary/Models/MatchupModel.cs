using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class MatchupModel
    {
        /// <summary>
        /// Unique identifier for the given matchup.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Represents the entrants for this particular matchup.
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
        /// <summary>
        /// Represents the winner for this particular matchup.
        /// </summary>
        public TeamModel Winner { get; set; }
        /// <summary>
        /// Represents the round in which this matchup takes place.
        /// </summary>
        public int MatchupRound { get; set; }
    }
}
