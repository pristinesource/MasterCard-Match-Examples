﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MasterCard.Api.Match;
using MasterCard.Core;
using MasterCard.Core.Model;
using MasterCard.Core.Security.OAuth;

namespace MasterCardTest.MasterCard_Examples {
    public static class TerminationInquiryRequestExample {
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
            Console.WriteLine("TerminationInquiry.PageOffset-->" + response["TerminationInquiry.PageOffset"]); //TerminationInquiry.PageOffset-->0
            Console.WriteLine("TerminationInquiry.PossibleMerchantMatches[0].TotalLength-->" + response["TerminationInquiry.PossibleMerchantMatches[0].TotalLength"]); //TerminationInquiry.PossibleMerchantMatches[0].TotalLength-->14
            Console.WriteLine("TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.Name-->" + response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.Name"]); //TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.Name-->XYZTEST  XYZTECHMERCHANT
            Console.WriteLine("TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.DoingBusinessAsName-->" + response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.DoingBusinessAsName"]); //TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.DoingBusinessAsName-->XYZTEST  XYZTECHMERCHANT
            Console.WriteLine("TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.AddedByAcquirerID-->" + response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.AddedByAcquirerID"]); //TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.AddedByAcquirerID-->1996
            Console.WriteLine("TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.AddedOnDate-->" + response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.AddedOnDate"]); //TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.AddedOnDate-->10/13/2015
            Console.WriteLine("TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.PhoneNumber-->" + response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.PhoneNumber"]); //TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.PhoneNumber-->5675543210
            Console.WriteLine("TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.AltPhoneNumber-->" + response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.AltPhoneNumber"]); //TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.AltPhoneNumber-->5672655441
            Console.WriteLine("TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.Address.Line1-->" + response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.Address.Line1"]); //TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.Address.Line1-->6700 BEN NEVIS
            Console.WriteLine("TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.Address.City-->" + response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.Address.City"]); //TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.Address.City-->GLASGOW
            Console.WriteLine("TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.Address.CountrySubdivision-->" + response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.Address.CountrySubdivision"]); //TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.Address.CountrySubdivision-->MA
            Console.WriteLine("TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.Address.PostalCode-->" + response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.Address.PostalCode"]); //TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.Address.PostalCode-->93137
            Console.WriteLine("TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.Address.Country-->" + response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.Address.Country"]); //TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.Address.Country-->USA
            Console.WriteLine("TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.CountrySubdivisionTaxId-->" + response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.CountrySubdivisionTaxId"]); //TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.CountrySubdivisionTaxId-->*****
            Console.WriteLine("TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.NationalTaxId-->" + response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.NationalTaxId"]); //TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.NationalTaxId-->*****
            Console.WriteLine("TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.ServiceProvLegal-->" + response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.ServiceProvLegal"]); //TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.ServiceProvLegal-->TESTXYZ SVC PRVDER
            Console.WriteLine("TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.ServiceProvDBA-->" + response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.ServiceProvDBA"]); //TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.ServiceProvDBA-->JNL ASSOC
            Console.WriteLine("TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.Principal[0].FirstName-->" + response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.Principal[0].FirstName"]); //TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.Principal[0].FirstName-->PAUL
            Console.WriteLine("TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.Principal[0].LastName-->" + response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.Principal[0].LastName"]); //TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.Principal[0].LastName-->HEMINGHOFF
            Console.WriteLine("TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.Principal[0].NationalId-->" + response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.Principal[0].NationalId"]); //TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.Principal[0].NationalId-->*****
            Console.WriteLine("TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.Principal[0].PhoneNumber-->" + response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.Principal[0].PhoneNumber"]); //TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.Principal[0].PhoneNumber-->3906541234
            Console.WriteLine("TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.Principal[0].AltPhoneNumber-->" + response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.Principal[0].AltPhoneNumber"]); //TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.Principal[0].AltPhoneNumber-->4567390234
            Console.WriteLine("TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.Principal[0].Address.Line1-->" + response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.Principal[0].Address.Line1"]); //TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.Principal[0].Address.Line1-->2200 SHEPLEY DRIVE
            Console.WriteLine("TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.Principal[0].Address.Line2-->" + response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.Principal[0].Address.Line2"]); //TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.Principal[0].Address.Line2-->SUITE 789
            Console.WriteLine("TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.Principal[0].Address.City-->" + response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.Principal[0].Address.City"]); //TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.Principal[0].Address.City-->BROWNSVILLE
            Console.WriteLine("TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.Principal[0].Address.CountrySubdivision-->" + response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.Principal[0].Address.CountrySubdivision"]); //TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.Principal[0].Address.CountrySubdivision-->MO
            Console.WriteLine("TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.Principal[0].Address.PostalCode-->" + response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.Principal[0].Address.PostalCode"]); //TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.Principal[0].Address.PostalCode-->89022
            Console.WriteLine("TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.Principal[0].Address.Country-->" + response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.Principal[0].Address.Country"]); //TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.Principal[0].Address.Country-->USA
            Console.WriteLine("TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.Principal[0].DriversLicense.Number-->" + response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.Principal[0].DriversLicense.Number"]); //TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.Principal[0].DriversLicense.Number-->*****
            Console.WriteLine("TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.Principal[0].DriversLicense.CountrySubdivision-->" + response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.Principal[0].DriversLicense.CountrySubdivision"]); //TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.Principal[0].DriversLicense.CountrySubdivision-->MS
            Console.WriteLine("TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.Principal[0].DriversLicense.Country-->" + response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.Principal[0].DriversLicense.Country"]); //TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.Principal[0].DriversLicense.Country-->USA
            Console.WriteLine("TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.UrlGroup[0].NoMatchUrls.Url[0]-->" + response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.UrlGroup[0].NoMatchUrls.Url[0]"]); //TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.UrlGroup[0].NoMatchUrls.Url[0]-->WWW.TESTJJ.COM
            Console.WriteLine("TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.UrlGroup[0].NoMatchUrls.Url[1]-->" + response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.UrlGroup[0].NoMatchUrls.Url[1]"]); //TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.UrlGroup[0].NoMatchUrls.Url[1]-->WWW.JNLTESTJJ.COM
            Console.WriteLine("TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.TerminationReasonCode-->" + response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.TerminationReasonCode"]); //TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].Merchant.TerminationReasonCode-->04
            Console.WriteLine("TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].MerchantMatch.Name-->" + response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].MerchantMatch.Name"]); //TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].MerchantMatch.Name-->M01
            Console.WriteLine("TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].MerchantMatch.DoingBusinessAsName-->" + response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].MerchantMatch.DoingBusinessAsName"]); //TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].MerchantMatch.DoingBusinessAsName-->M02
            Console.WriteLine("TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].MerchantMatch.Address-->" + response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].MerchantMatch.Address"]); //TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].MerchantMatch.Address-->M00
            Console.WriteLine("TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].MerchantMatch.PhoneNumber-->" + response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].MerchantMatch.PhoneNumber"]); //TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].MerchantMatch.PhoneNumber-->M00
            Console.WriteLine("TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].MerchantMatch.AltPhoneNumber-->" + response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].MerchantMatch.AltPhoneNumber"]); //TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].MerchantMatch.AltPhoneNumber-->M00
            Console.WriteLine("TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].MerchantMatch.CountrySubdivisionTaxId-->" + response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].MerchantMatch.CountrySubdivisionTaxId"]); //TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].MerchantMatch.CountrySubdivisionTaxId-->M00
            Console.WriteLine("TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].MerchantMatch.NationalTaxId-->" + response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].MerchantMatch.NationalTaxId"]); //TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].MerchantMatch.NationalTaxId-->M00
            Console.WriteLine("TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].MerchantMatch.ServiceProvLegal-->" + response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].MerchantMatch.ServiceProvLegal"]); //TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].MerchantMatch.ServiceProvLegal-->M00
            Console.WriteLine("TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].MerchantMatch.ServiceProvDBA-->" + response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].MerchantMatch.ServiceProvDBA"]); //TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].MerchantMatch.ServiceProvDBA-->M00
            Console.WriteLine("TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].MerchantMatch.PrincipalMatch[0].Name-->" + response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].MerchantMatch.PrincipalMatch[0].Name"]); //TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].MerchantMatch.PrincipalMatch[0].Name-->M00
            Console.WriteLine("TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].MerchantMatch.PrincipalMatch[0].Address-->" + response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].MerchantMatch.PrincipalMatch[0].Address"]); //TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].MerchantMatch.PrincipalMatch[0].Address-->M00
            Console.WriteLine("TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].MerchantMatch.PrincipalMatch[0].PhoneNumber-->" + response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].MerchantMatch.PrincipalMatch[0].PhoneNumber"]); //TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].MerchantMatch.PrincipalMatch[0].PhoneNumber-->M00
            Console.WriteLine("TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].MerchantMatch.PrincipalMatch[0].AltPhoneNumber-->" + response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].MerchantMatch.PrincipalMatch[0].AltPhoneNumber"]); //TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].MerchantMatch.PrincipalMatch[0].AltPhoneNumber-->M00
            Console.WriteLine("TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].MerchantMatch.PrincipalMatch[0].NationalId-->" + response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].MerchantMatch.PrincipalMatch[0].NationalId"]); //TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].MerchantMatch.PrincipalMatch[0].NationalId-->M00
            Console.WriteLine("TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].MerchantMatch.PrincipalMatch[0].DriversLicense-->" + response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].MerchantMatch.PrincipalMatch[0].DriversLicense"]); //TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[0].MerchantMatch.PrincipalMatch[0].DriversLicense-->M00
            Console.WriteLine("TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.Name-->" + response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.Name"]); //TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.Name-->XYZTEST  XYZTECHMERCHANT
            Console.WriteLine("TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.DoingBusinessAsName-->" + response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.DoingBusinessAsName"]); //TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.DoingBusinessAsName-->XYZTEST  XYZTECHMERCHANT
            Console.WriteLine("TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.AddedByAcquirerID-->" + response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.AddedByAcquirerID"]); //TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.AddedByAcquirerID-->1996
            Console.WriteLine("TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.AddedOnDate-->" + response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.AddedOnDate"]); //TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.AddedOnDate-->01/20/2016
            Console.WriteLine("TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.PhoneNumber-->" + response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.PhoneNumber"]); //TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.PhoneNumber-->5675543210
            Console.WriteLine("TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.AltPhoneNumber-->" + response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.AltPhoneNumber"]); //TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.AltPhoneNumber-->5672655441
            Console.WriteLine("TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.Address.Line1-->" + response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.Address.Line1"]); //TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.Address.Line1-->6700 BEN NEVIS
            Console.WriteLine("TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.Address.City-->" + response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.Address.City"]); //TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.Address.City-->GLASGOW
            Console.WriteLine("TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.Address.CountrySubdivision-->" + response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.Address.CountrySubdivision"]); //TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.Address.CountrySubdivision-->MA
            Console.WriteLine("TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.Address.PostalCode-->" + response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.Address.PostalCode"]); //TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.Address.PostalCode-->93137
            Console.WriteLine("TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.Address.Country-->" + response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.Address.Country"]); //TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.Address.Country-->USA
            Console.WriteLine("TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.CountrySubdivisionTaxId-->" + response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.CountrySubdivisionTaxId"]); //TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.CountrySubdivisionTaxId-->*****
            Console.WriteLine("TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.NationalTaxId-->" + response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.NationalTaxId"]); //TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.NationalTaxId-->*****
            Console.WriteLine("TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.ServiceProvLegal-->" + response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.ServiceProvLegal"]); //TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.ServiceProvLegal-->TESTXYZ SVC PRVDER
            Console.WriteLine("TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.ServiceProvDBA-->" + response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.ServiceProvDBA"]); //TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.ServiceProvDBA-->JNL ASSOC
            Console.WriteLine("TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.Principal[0].FirstName-->" + response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.Principal[0].FirstName"]); //TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.Principal[0].FirstName-->PAUL
            Console.WriteLine("TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.Principal[0].LastName-->" + response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.Principal[0].LastName"]); //TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.Principal[0].LastName-->HEMINGHOFF
            Console.WriteLine("TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.Principal[0].NationalId-->" + response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.Principal[0].NationalId"]); //TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.Principal[0].NationalId-->*****
            Console.WriteLine("TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.Principal[0].PhoneNumber-->" + response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.Principal[0].PhoneNumber"]); //TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.Principal[0].PhoneNumber-->3906541234
            Console.WriteLine("TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.Principal[0].AltPhoneNumber-->" + response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.Principal[0].AltPhoneNumber"]); //TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.Principal[0].AltPhoneNumber-->4567390234
            Console.WriteLine("TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.Principal[0].Address.Line1-->" + response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.Principal[0].Address.Line1"]); //TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.Principal[0].Address.Line1-->2200 SHEPLEY DRIVE
            Console.WriteLine("TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.Principal[0].Address.Line2-->" + response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.Principal[0].Address.Line2"]); //TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.Principal[0].Address.Line2-->SUITE 789
            Console.WriteLine("TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.Principal[0].Address.City-->" + response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.Principal[0].Address.City"]); //TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.Principal[0].Address.City-->BROWNSVILLE
            Console.WriteLine("TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.Principal[0].Address.CountrySubdivision-->" + response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.Principal[0].Address.CountrySubdivision"]); //TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.Principal[0].Address.CountrySubdivision-->MO
            Console.WriteLine("TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.Principal[0].Address.PostalCode-->" + response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.Principal[0].Address.PostalCode"]); //TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.Principal[0].Address.PostalCode-->89022
            Console.WriteLine("TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.Principal[0].Address.Country-->" + response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.Principal[0].Address.Country"]); //TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.Principal[0].Address.Country-->USA
            Console.WriteLine("TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.Principal[0].DriversLicense.Number-->" + response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.Principal[0].DriversLicense.Number"]); //TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.Principal[0].DriversLicense.Number-->*****
            Console.WriteLine("TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.Principal[0].DriversLicense.CountrySubdivision-->" + response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.Principal[0].DriversLicense.CountrySubdivision"]); //TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.Principal[0].DriversLicense.CountrySubdivision-->MS
            Console.WriteLine("TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.Principal[0].DriversLicense.Country-->" + response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.Principal[0].DriversLicense.Country"]); //TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.Principal[0].DriversLicense.Country-->USA
            Console.WriteLine("TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.UrlGroup[0].NoMatchUrls.Url[0]-->" + response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.UrlGroup[0].NoMatchUrls.Url[0]"]); //TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.UrlGroup[0].NoMatchUrls.Url[0]-->WWW.TESTJJ.COM
            Console.WriteLine("TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.UrlGroup[0].NoMatchUrls.Url[1]-->" + response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.UrlGroup[0].NoMatchUrls.Url[1]"]); //TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.UrlGroup[0].NoMatchUrls.Url[1]-->WWW.JNLTESTJJ.COM
            Console.WriteLine("TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.TerminationReasonCode-->" + response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.TerminationReasonCode"]); //TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].Merchant.TerminationReasonCode-->04
            Console.WriteLine("TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].MerchantMatch.Name-->" + response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].MerchantMatch.Name"]); //TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].MerchantMatch.Name-->M01
            Console.WriteLine("TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].MerchantMatch.DoingBusinessAsName-->" + response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].MerchantMatch.DoingBusinessAsName"]); //TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].MerchantMatch.DoingBusinessAsName-->M02
            Console.WriteLine("TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].MerchantMatch.Address-->" + response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].MerchantMatch.Address"]); //TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].MerchantMatch.Address-->M00
            Console.WriteLine("TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].MerchantMatch.PhoneNumber-->" + response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].MerchantMatch.PhoneNumber"]); //TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].MerchantMatch.PhoneNumber-->M00
            Console.WriteLine("TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].MerchantMatch.AltPhoneNumber-->" + response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].MerchantMatch.AltPhoneNumber"]); //TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].MerchantMatch.AltPhoneNumber-->M00
            Console.WriteLine("TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].MerchantMatch.CountrySubdivisionTaxId-->" + response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].MerchantMatch.CountrySubdivisionTaxId"]); //TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].MerchantMatch.CountrySubdivisionTaxId-->M00
            Console.WriteLine("TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].MerchantMatch.NationalTaxId-->" + response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].MerchantMatch.NationalTaxId"]); //TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].MerchantMatch.NationalTaxId-->M00
            Console.WriteLine("TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].MerchantMatch.ServiceProvLegal-->" + response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].MerchantMatch.ServiceProvLegal"]); //TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].MerchantMatch.ServiceProvLegal-->M00
            Console.WriteLine("TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].MerchantMatch.ServiceProvDBA-->" + response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].MerchantMatch.ServiceProvDBA"]); //TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].MerchantMatch.ServiceProvDBA-->M00
            Console.WriteLine("TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].MerchantMatch.PrincipalMatch[0].Name-->" + response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].MerchantMatch.PrincipalMatch[0].Name"]); //TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].MerchantMatch.PrincipalMatch[0].Name-->M00
            Console.WriteLine("TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].MerchantMatch.PrincipalMatch[0].Address-->" + response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].MerchantMatch.PrincipalMatch[0].Address"]); //TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].MerchantMatch.PrincipalMatch[0].Address-->M00
            Console.WriteLine("TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].MerchantMatch.PrincipalMatch[0].PhoneNumber-->" + response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].MerchantMatch.PrincipalMatch[0].PhoneNumber"]); //TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].MerchantMatch.PrincipalMatch[0].PhoneNumber-->M00
            Console.WriteLine("TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].MerchantMatch.PrincipalMatch[0].AltPhoneNumber-->" + response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].MerchantMatch.PrincipalMatch[0].AltPhoneNumber"]); //TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].MerchantMatch.PrincipalMatch[0].AltPhoneNumber-->M00
            Console.WriteLine("TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].MerchantMatch.PrincipalMatch[0].NationalId-->" + response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].MerchantMatch.PrincipalMatch[0].NationalId"]); //TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].MerchantMatch.PrincipalMatch[0].NationalId-->M00
            Console.WriteLine("TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].MerchantMatch.PrincipalMatch[0].DriversLicense-->" + response["TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].MerchantMatch.PrincipalMatch[0].DriversLicense"]); //TerminationInquiry.PossibleMerchantMatches[0].TerminatedMerchant[1].MerchantMatch.PrincipalMatch[0].DriversLicense-->M00


            // This sample shows looping through TerminationInquiry.PossibleMerchantMatches
            List<Dictionary<String, Object>> list = (List<Dictionary<String, Object>>)response["TerminationInquiry.PossibleMerchantMatches"];
            for(var i = 0; i < list.Count; i++) {
                Console.WriteLine("index: " + i);
                Console.WriteLine("TotalLength: [ " + list[i]["TotalLength"] + " ]");
                Console.WriteLine("index: " + i);
                Console.WriteLine("TerminatedMerchant: [ " + list[i]["TerminatedMerchant"] + " ]");

            }
        }
    }
}
