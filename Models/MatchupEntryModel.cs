using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// Represents a particular matchup entry.
    /// </summary>
    public class MatchupEntryModel
    {
        /// <summary>
        /// Represents one team in the matchup
        /// </summary>
        public TeamModel teamCompeting { get; set; }
        
        /// <summary>
        /// Represents the score for this team
        /// </summary>
        public double score { get; set; }

        /// <summary>
        /// Represents the matchup that this team came
        /// from as the winner
        /// </summary>
        public MatchupModel parentMatchup { get; set; }

    }
}
