using System.Collections.Generic;
using System.Linq;
using LottoApi.Models;

namespace LottoApi.Services.Tests
{
    public class ConsecutiveDraws
    {

        public bool NextDrawHasOnlyOneNumberFromPrevious(LottoResult previousDraw, LottoResult nextDraw)
        {
          

            var next = new List<int>() { nextDraw.NUM1, nextDraw.NUM2, nextDraw.NUM3 };

            var one = next.Count(x => x == previousDraw.NUM1);

            var two = next.Count(x => x == previousDraw.NUM2);
            
            var three = next.Count(x => x == previousDraw.NUM3);

            return one + two + three == 1;


        }


    }
}