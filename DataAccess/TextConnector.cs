using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Interface;
using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextHelpers;

namespace TrackerLibrary
{
    public class TextConnector : IDataConnection
    {

        private const string PrizesFile = "PrizeModels.csv";

        // TODO - Wire up the CreatPrize for the text files.
        public PrizeModel CreatePrize(PrizeModel model)
        {
            List<PrizeModel> prizes = PrizesFile.FullFilePath().LoadFile().convertToPrizeModels();

            int currentId = 1;

            if (prizes.Count > 0)
            {
                currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;

            prizes.Add(model);

            prizes.SaveToPrizeFile(PrizesFile);

            return model;
        }
    }
}
