using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// Represents a particular matchup.
    /// </summary>
    public class MatchupModel
    {
        /// <summary>
        /// Is a list of matchup entries; that is teams that are part of this
        /// particular matchup
        /// </summary>
        public List<MatchupEntryModel> entries { get; set; } = new List<MatchupEntryModel>();
        
        /// <summary>
        /// The winner of this particular matchup
        /// </summary>
        public TeamModel winner { get; set; }

        /// <summary>
        /// The specific round of this matchup.
        /// </summary>
        public int matchupRound { get; set; }

    }
}
