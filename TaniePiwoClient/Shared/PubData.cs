using System.Collections.Generic;
using System.Linq;

namespace TaniePiwoClient.Shared
{
    public class PubData
    {
        public string Name;
        public float Lat;
        public float Lng;
        public List<BeerData> BeerDataList;
        public int CheapestBeerPrice => BeerDataList.Min(b => b.Price);
    }
}