using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MasterCard.Api.Match;
using MasterCard.Core.Model;

namespace MasterCardTest.MasterCard_Examples {
    public static class AcquirerContactRequestExample {

        public static void run() {
            RequestMap map = new RequestMap();
            map.Set("ContactRequest.AcquirerId", "12086");

            AcquirerContactRequest response = AcquirerContactRequest.Create(map);

            ExampleHelper.DisplayResponse(response);
        }
    }
}
