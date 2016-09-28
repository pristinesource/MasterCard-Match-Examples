using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MasterCard.Api.Match;
using MasterCard.Core.Model;

namespace MasterCardTest.MasterCard_Examples {
    public static class TerminationInquiryHistoryRequestExample {

        public static void run() {

            RequestMap map = new RequestMap();
            map.Set("IRN", "19962016070500348");
            map.Set("PageLength", "10");
            map.Set("AcquirerId", "1996");
            map.Set("PageOffset", "0");


            TerminationInquiryHistoryRequest response = TerminationInquiryHistoryRequest.Read("", map);


            ExampleHelper.DisplayResponse(response);

        }

    }
}
