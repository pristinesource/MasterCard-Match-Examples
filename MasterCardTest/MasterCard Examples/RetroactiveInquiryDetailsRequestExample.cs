using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MasterCard.Api.Match;
using MasterCard.Core.Model;

namespace MasterCardTest.MasterCard_Examples {
    public static class RetroactiveInquiryDetailsRequestExample {

        public static void run() {

            RequestMap map = new RequestMap();
            map.Set("RetroInquiryRequest.InquiryReferenceNumber", "19962014090200009");

            RetroactiveInquiryDetailsRequest response = RetroactiveInquiryDetailsRequest.Create(map);

            ExampleHelper.DisplayResponse(response);

        }
    }
}
