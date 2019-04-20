using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class TeamModel
    {
        /// <summary>
        /// Represents the list of members in the team.
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();
        /// <summary>
        /// Represents the name of the team, obviously.
        /// </summary>
        public string TeamName { get; set; }

    }
}
