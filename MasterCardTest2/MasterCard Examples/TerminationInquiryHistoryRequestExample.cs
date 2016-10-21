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
            // This IRN number is supposed to come from "TerminationInquiry​.TransactionReferenceNumber" in the TerminationInquiryRequest
            // but that field is blank.  Instead it can be pulled form the url in the field named "TerminationInquiry​.Ref" of the
            // TerminationInquiryRequest
            map.Set("IRN", "19962016102100041");
    
            map.Set("AcquirerId", "1996");
            map.Set("PageLength", "10");
            map.Set("PageOffset", "0");
            //map.Set("id", "");


            TerminationInquiryHistoryRequest response = TerminationInquiryHistoryRequest.Read(map);

      ExampleHelper.DisplayResponse(response);
      /*
            int c = 0;
            foreach(var r in response) {
                ExampleHelper.DisplayResponse(r, "[" + c.ToString() + "].");
            }
            */
        }

    }
}
