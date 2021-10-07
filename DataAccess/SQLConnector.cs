using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;
using TrackerLibrary.Interface;
using System.Data;
using Dapper;

namespace TrackerLibrary
{
    public class SQLConnector : IDataConnection
    {
        // TODO - Make the createPrize method actualls save to the Database
        /// <summary>
        /// Saves the prize to the database.
        /// </summary>
        /// <param name="model">The prize information.</param>
        /// <returns>Prize info, including the unique Id.</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Tournaments")))
            {
                var p = new DynamicParameters();
                p.Add("@PlaceNumber", model.placeNumber);
                p.Add("@PrizeAmount", model.prizeAmount);
                p.Add("@PrizePercentage", model.prizePercentage);
                p.Add("@PlaceName", model.placeName);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spPrizes_Insert", p, commandType: CommandType.StoredProcedure);
                model.Id = p.Get<int>("@id");

                return model;

            }
        }
    }
}

/*@PlaceNumber int,
	@PrizeAmount money,
    @PrizePercentage float,
	@PlaceName nvarchar(50),
	@id int = 0 output*/