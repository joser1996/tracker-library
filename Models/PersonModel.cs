using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// Represents one person.
    /// </summary>
    public class PersonModel
    {
        /// <summary>
        /// First name of this instance of person.
        /// </summary>
        public string firstName { get; set; }

        /// <summary>
        /// Last name of this instance of pesron.
        /// </summary>
        public string lastName { get; set; }

        /// <summary>
        /// The email of this particular person.
        /// </summary>
        public string email { get; set; }

        /// <summary>
        /// The cellphone of this particular person.
        /// </summary>
        public string cellPhoneNumber { get; set; }


    }
}
