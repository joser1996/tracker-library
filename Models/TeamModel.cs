using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// Represents a particular team.
    /// </summary>
    public class TeamModel
    {
        /// <summary>
        /// Roster of team members in the team.
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();

        /// <summary>
        /// The name of this particular team.
        /// </summary>
        public string TeamName { get; set; }
    }
}
