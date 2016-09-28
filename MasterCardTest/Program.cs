using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MasterCard.Api.Match;
using MasterCard.Core;
using MasterCard.Core.Model;
using MasterCard.Core.Security.OAuth;

namespace MasterCardTest {
    class Program {
        static void Main(string[] args) {


            string consumerKey = "L5BsiPgaF-O3qA36znUATgQXwJB6MRoMSdhjd7wt50c97279!50596e52466e3966546d434b7354584c4975693238513d3d";   // You should copy this from "My Keys" on your project page e.g. UTfbhDCSeNYvJpLL5l028sWL9it739PYh6LU5lZja15xcRpY!fd209e6c579dc9d7be52da93d35ae6b6c167c174690b72fa
            string keyAlias = "alias";   // For production: change this to the key alias you chose when you created your production key
            string keyPassword = "password";   // For production: change this to the key alias you chose when you created your production key
            var path = MasterCard.Core.Util.GetCurrenyAssemblyPath(); // This returns the path to your assembly so it be used to locate your cert
            string certPath = path + "\\mcapi_sandbox_key.p12"; // e.g. /Users/yourname/project/sandbox.p12 | C:\Users\yourname\project\sandbox.p12
            ApiConfig.setAuthentication(new OAuthAuthentication(consumerKey, certPath, keyAlias, keyPassword));   // You only need to set this once
            ApiConfig.setSandbox(true); // For production: use ApiConfig.setSandbox(false)


            runTest(MasterCardTest.MasterCard_Examples.TerminationInquiryRequestExample.run, nameof(MasterCardTest.MasterCard_Examples.TerminationInquiryRequestExample));

            // this is a modification of the first test that uses my dynamic response display
            //runTest(MasterCardTest.MasterCard_Examples.TerminationInquiryRequest2Example.run, nameof(MasterCardTest.MasterCard_Examples.TerminationInquiryRequest2Example));

            runTest(MasterCardTest.MasterCard_Examples.TerminationInquiryHistoryRequestExample.run, nameof(MasterCardTest.MasterCard_Examples.TerminationInquiryHistoryRequestExample));
            runTest(MasterCardTest.MasterCard_Examples.AddTerminatedMerchantExample.run, nameof(MasterCardTest.MasterCard_Examples.AddTerminatedMerchantExample));
            runTest(MasterCardTest.MasterCard_Examples.AcquirerContactRequestExample.run, nameof(MasterCardTest.MasterCard_Examples.AcquirerContactRequestExample));
            runTest(MasterCardTest.MasterCard_Examples.RetroactiveInquiryRequestExample.run, nameof(MasterCardTest.MasterCard_Examples.RetroactiveInquiryRequestExample));
            runTest(MasterCardTest.MasterCard_Examples.RetroactiveInquiryDetailsRequestExample.run, nameof(MasterCardTest.MasterCard_Examples.RetroactiveInquiryDetailsRequestExample));


            Console.ReadKey();

        }


        public static void runTest(Action t, string name) {
            Console.WriteLine("===========================================================================");
            Console.WriteLine(name);
            Console.WriteLine("===========================================================================");

            try {
                t();
            } catch (Exception ex) {
                Console.WriteLine(ex.ToString());
            }

            Console.Write(Environment.NewLine + Environment.NewLine);
        }
    }
}
