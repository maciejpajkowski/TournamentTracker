using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class PrizeModel
    {
        /// <summary>
        /// Unique identifier for the given prize.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Represents the place number, for which the prize is intended.
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// Represents the place name, for which the prize is intended.
        /// </summary>
        public string PlaceName { get; set; }
        /// <summary>
        /// Represents the amount of money awarded for a given place.
        /// </summary>
        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// Represents the % cut of the entire prize pool.
        /// </summary>
        public double PrizePercentage { get; set; }

        public PrizeModel()
        {

        }

        public PrizeModel(string placeName, string placeNumber, string prizeAmount, string prizePercentage)
        {
            PlaceName = placeName;

            int placeNumberValue = 0;
            int.TryParse(placeNumber, out placeNumberValue);
            PlaceNumber = placeNumberValue;

            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);
            PrizeAmount = prizeAmountValue;

            double prizePercentageValue = 0;
            double.TryParse(prizePercentage, out prizePercentageValue);
            PrizePercentage = prizePercentageValue;
        }

    }
}
