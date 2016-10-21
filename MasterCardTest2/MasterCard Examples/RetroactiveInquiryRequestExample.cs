using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MasterCard.Api.Match;
using MasterCard.Core.Model;

namespace MasterCardTest.MasterCard_Examples {
    public static class RetroactiveInquiryRequestExample {

        public static void run() {
            RequestMap map = new RequestMap();
            map.Set("RetroRequest.AcquirerId", "1996");

            RetroactiveInquiryRequest response = RetroactiveInquiryRequest.create(map);

            ExampleHelper.DisplayResponse(response);
        }

    }
}
