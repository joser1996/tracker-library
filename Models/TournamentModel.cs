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
    class TournamentModel
    {
        /// <summary>
        /// The name of this particular name.
        /// </summary>
        public string tournamentName { get; set; }

        /// <summary>
        /// The entry fee to enter the tournament.
        /// </summary>
        public decimal entryFee { get; set; }

        /// <summary>
        /// List of teams that are entered in the tournament.
        /// </summary>
        public List<TeamModel> enteredTeams { get; set; } = new List<TeamModel>();

        /// <summary>
        /// List of prizes that will be awared in this tournament.
        /// </summary>
        public List<PrizeModel> prizes { get; set; } = new List<PrizeModel>();

        /// <summary>
        /// List of rounds. Each round is simply a list of MatchupModel's that is to say games
        /// in this round.
        /// </summary>
        public List<List<MatchupModel>> rounds { get; set; } = new List<List<MatchupModel>>();

    }
}
