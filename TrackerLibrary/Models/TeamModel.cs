﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class TeamModel
    {
        /// <summary>
        /// Unique identifier for the team.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Represents the name of the team, obviously.
        /// </summary>
        public string TeamName { get; set; }
        /// <summary>
        /// Represents the list of members in the team.
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();
        

    }
}
