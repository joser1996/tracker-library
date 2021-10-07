using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.Interface
{
    public interface IDataConnection

    {
        /// <summary>
        /// Call this when we want to create a new prize.
        /// </summary>
        /// <param name="model">Model that we created from our form.</param>
        /// <returns>
        /// Returns a prize model that was created in the DB or the textfile.
        /// Contais additional info like the ID.
        /// </returns>
        PrizeModel CreatePrize(PrizeModel model);
    }
}
