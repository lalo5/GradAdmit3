using System;
using System.Collections.Generic;
using System.Text;

namespace Shared
{
    public class Address
    {
        string  Street;
        string  Street2;
        string  City;
        string  State;
        int     zip;
        string  Country;

        public Address()
        {
            Street = "Not Entered";
            Street2 = "Not Entered";
            City = "Required";
            State = "Required";
            zip = 00000;
            Country = "Required";
        }//end Address()
        
        public Address(string Addr1, string Addr2, string CityIn, string StateIn, int zipIn, string CountryIn)
        {
            this.Street = Addr1;
            this.Street2 = Addr2;
            this.City = CityIn;
            this.State = StateIn;
            zip = zipIn;
            this.Country = CountryIn;
        }

        public Address(Address AddressIn)
        {
            this.Street = AddressIn.Street;
            this.Street2 = AddressIn.Street2;
            this.City = AddressIn.City;
            this.State = AddressIn.State;
            zip = AddressIn.zip;
            this.Country = AddressIn.Country;
        }//end Address(Address)

        public string GetStreet1()
        {
            return this.Street;
        }
        public string GetStreet2()
        {
            return this.Street2;
        }
        public string GetCity()
        {
            return this.City;
        }
        public string GetState()
        {
            return this.State;
        }
        public int GetZip()
        {
            return this.zip;
        }
        public string GetCountry()
        {
            return this.Country;
        }
    }//end Address
}
