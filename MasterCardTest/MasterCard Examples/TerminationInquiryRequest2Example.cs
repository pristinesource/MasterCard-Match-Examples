using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MasterCard.Api.Match;
using MasterCard.Core;
using MasterCard.Core.Model;
using MasterCard.Core.Security.OAuth;

namespace MasterCardTest.MasterCard_Examples {
    public static class TerminationInquiryRequest2Example {
        public static void run() {
            
            RequestMap map = new RequestMap();
            map.Set("TerminationInquiryRequest.AcquirerId", "1996");
            map.Set("TerminationInquiryRequest.Merchant.Name", "XYZTEST  XYZTECHMERCHANT");
            map.Set("TerminationInquiryRequest.Merchant.DoingBusinessAsName", "XYZTEST  XYZTECHMERCHANT");
            map.Set("TerminationInquiryRequest.Merchant.AltPhoneNumber", "3098876333");
            map.Set("TerminationInquiryRequest.Merchant.Address.Line1", "88 Nounce World");
            map.Set("TerminationInquiryRequest.Merchant.Address.Line2", "APT 9009");
            map.Set("TerminationInquiryRequest.Merchant.Address.City", "MICKENVINCE");
            map.Set("TerminationInquiryRequest.Merchant.Address.CountrySubdivision", "MO");
            map.Set("TerminationInquiryRequest.Merchant.Address.PostalCode", "66559");
            map.Set("TerminationInquiryRequest.Merchant.Address.Country", "USA");
            map.Set("TerminationInquiryRequest.Merchant.ServiceProvLegal", "JJC WORKSHIRE");
            map.Set("TerminationInquiryRequest.Merchant.Principal.FirstName", "PRINCE");
            map.Set("TerminationInquiryRequest.Merchant.Principal.LastName", "HENREY");
            map.Set("TerminationInquiryRequest.Merchant.Principal.PhoneNumber", "9983339923");
            map.Set("TerminationInquiryRequest.Merchant.Principal.AltPhoneNumber", "6365689336");
            map.Set("TerminationInquiryRequest.Merchant.Principal.Address.CountrySubdivision", "IL");
            map.Set("TerminationInquiryRequest.Merchant.Principal.Address.PostalCode", "66579");
            map.Set("TerminationInquiryRequest.Merchant.Principal.Address.Country", "USA");
            map.Set("TerminationInquiryRequest.Merchant.SearchCriteria.SearchAll", "Y");
            map.Set("TerminationInquiryRequest.Merchant.SearchCriteria.MinPossibleMatchCount", "1");
            map.Set("PageLength", "10");
            map.Set("PageOffset", "0");

            TerminationInquiryRequest response = TerminationInquiryRequest.Create(map);

            ExampleHelper.DisplayResponse(response);
        }
    }
}
