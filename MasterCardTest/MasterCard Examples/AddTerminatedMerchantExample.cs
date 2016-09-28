using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MasterCard.Api.Match;
using MasterCard.Core.Model;

namespace MasterCardTest.MasterCard_Examples {
    public static class AddTerminatedMerchantExample {

        public static void run() {

            RequestMap map = new RequestMap();
            map.Set("AddMerchantRequest.AcquirerId", "1996");
            map.Set("AddMerchantRequest.Merchant.Name", "TEST TECHMERCHANT1");
            map.Set("AddMerchantRequest.Merchant.DoingBusinessAsName", "TEST TECHMERCHANT1");
            map.Set("AddMerchantRequest.Merchant.MerchantId", "204862114971580");
            map.Set("AddMerchantRequest.Merchant.MerchantCategory", "0742");
            map.Set("AddMerchantRequest.Merchant.Address.Line1", "6700 Ben Nevis");
            map.Set("AddMerchantRequest.Merchant.Address.Line2", "");
            map.Set("AddMerchantRequest.Merchant.Address.City", "GLASGOW");
            map.Set("AddMerchantRequest.Merchant.Address.Province", "");
            map.Set("AddMerchantRequest.Merchant.Address.CountrySubdivision", "MA");
            map.Set("AddMerchantRequest.Merchant.Address.PostalCode", "93137");
            map.Set("AddMerchantRequest.Merchant.Address.Country", "USA");
            map.Set("AddMerchantRequest.Merchant.PhoneNumber", "5675542210");
            map.Set("AddMerchantRequest.Merchant.AltPhoneNumber", "5672655441");
            map.Set("AddMerchantRequest.Merchant.NationalTaxId", "56733");
            map.Set("AddMerchantRequest.Merchant.CountrySubdivisionTaxId", "37354");
            map.Set("AddMerchantRequest.Merchant.CATFlag", "N");
            map.Set("AddMerchantRequest.Merchant.DateOpened", "04/12/2009");
            map.Set("AddMerchantRequest.Merchant.DateClosed", "03/19/2013");
            map.Set("AddMerchantRequest.Merchant.ServiceProvLegal", "TEST SVC PRVDER");
            map.Set("AddMerchantRequest.Merchant.ServiceProvDBA", "JNL ASSOC");
            map.Set("AddMerchantRequest.Merchant.Url[0]", "www.testjj.com");
            map.Set("AddMerchantRequest.Merchant.Url[1]", "www.jnltestjj.com");
            map.Set("AddMerchantRequest.Merchant.Principal.FirstName", "PAUL");
            map.Set("AddMerchantRequest.Merchant.Principal.LastName", "HEMINGHOFF");
            map.Set("AddMerchantRequest.Merchant.Principal.MiddleInitial", "L");
            map.Set("AddMerchantRequest.Merchant.Principal.Address.Line1", "2200 Shepley Drive");
            map.Set("AddMerchantRequest.Merchant.Principal.Address.Line2", "SUITE 789");
            map.Set("AddMerchantRequest.Merchant.Principal.Address.City", "BROWNSVILLE");
            map.Set("AddMerchantRequest.Merchant.Principal.Address.Province", "");
            map.Set("AddMerchantRequest.Merchant.Principal.Address.CountrySubdivision", "MO");
            map.Set("AddMerchantRequest.Merchant.Principal.Address.PostalCode", "89022");
            map.Set("AddMerchantRequest.Merchant.Principal.Address.Country", "USA");
            map.Set("AddMerchantRequest.Merchant.Principal.PhoneNumber", "3906541234");
            map.Set("AddMerchantRequest.Merchant.Principal.AltPhoneNumber", "4567390234");
            map.Set("AddMerchantRequest.Merchant.Principal.NationalId", "123456789");
            map.Set("AddMerchantRequest.Merchant.Principal.DriversLicense.Number", "3K33094");
            map.Set("AddMerchantRequest.Merchant.Principal.DriversLicense.CountrySubdivision", "MS");
            map.Set("AddMerchantRequest.Merchant.Principal.DriversLicense.Country", "USA");
            map.Set("AddMerchantRequest.Merchant.ReasonCode", "04");
            map.Set("AddMerchantRequest.Merchant.Comments", "Added for test reasons");

            AddTerminatedMerchant response = AddTerminatedMerchant.Create(map);

            ExampleHelper.DisplayResponse(response);

        }
    }
}
