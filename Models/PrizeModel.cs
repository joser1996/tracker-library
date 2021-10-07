using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// Represents a prize.
    /// </summary>
    public class PrizeModel
    {

        public PrizeModel()
        {
            
        }

        public PrizeModel(string placeName, string placeNumber, string prizeAmount, string prizePercentage)
        {
            this.placeName = placeName;

            int.TryParse(placeNumber, out int placeNumberValue);
            this.placeNumber = placeNumberValue;

            decimal.TryParse(prizeAmount, out decimal prizeAmountVal);
            this.prizeAmount = prizeAmountVal;

            double.TryParse(prizePercentage, out double prizePercentageVal);
            this.prizePercentage = prizePercentageVal;
        }

        /// <summary>
        /// The unique Id for this prize.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The numerical interperation of the place. Exa 1 = first place
        /// </summary>
        public int placeNumber { get; set; }

        /// <summary>
        /// The name of this prize model place number. 1 = First place or
        /// 1 = First etc.
        /// </summary>
        public string placeName { get; set; }

        /// <summary>
        /// The prize amount for this particular prize.
        /// </summary>
        public decimal prizeAmount { get; set; }

        /// <summary>
        /// The percentage of the total amount to be given away as prize many
        /// that will be given to this particular prize.
        /// </summary>
        public double prizePercentage { get; set; }

    }
}
