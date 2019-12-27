using System;
using System.Net;
using System.Xml;
using Addressing.com.despatchbaypro.api;

namespace Addressing
{
	class MainClass
	{
		private static string apiuser;
		private static string apikey;
		private static AddressingService Service;

		/// <summary>
		/// Gets the authorise service. Loads a XML configuration file, creates a 
		/// Basic Auth credentials object and applies to the Service we want to use
		/// </summary>
		/// <returns>The authorise service.</returns>
		private static AddressingService GetAuthoriseService()
		{
			// Set up some credentials
			NetworkCredential netCredential = new NetworkCredential(apiuser, apikey);
			// Create the service of type Addressing service
			Service = new AddressingService()
			{
				RequestEncoding = System.Text.Encoding.UTF8
			};
			Uri uri = new Uri(Service.Url);
			ICredentials credentials = netCredential.GetCredential(uri, "Basic");
			// Apply the credentials to the service
			Service.Credentials = credentials;
			return Service;
		}

		/// <summary>
		/// Loads the configuration file and sets some static variables
		/// </summary>
		private static void LoadConfiguration()
		{
			XmlDocument doc = new XmlDocument();
			doc.Load("configuration.xml");
			XmlNode node;
			try {
				node = doc.DocumentElement.SelectSingleNode("/configuration/apiuser");
				apiuser = node.InnerText;
				node = doc.DocumentElement.SelectSingleNode("/configuration/apikey");
				apikey = node.InnerText;
			} catch(System.IO.FileNotFoundException ex) {
				Console.WriteLine(ex.Message);
				throw;
			}
		}


		/// <summary>
		/// Finds the address method.
		/// </summary>
		/// <returns>The address method.</returns>
		/// <param name="postcode">Postcode.</param>
		/// <param name="place">Place.</param>
		private static AddressType FindAddressMethod(string postcode, string place)
        {
            AddressType Address = new AddressType();
            Service = GetAuthoriseService();
            try
            {
				// Call the GetDomesticAddressByKey soap service
				Address = Service.FindAddress(postcode, place);
            }
            catch(Exception soapEx)
            {
                Console.WriteLine("{0}", soapEx.Message);
				throw;
            }
            return Address;
        }

		/// <summary>
		/// Gets the domestic address by key method.
		/// </summary>
		/// <returns>The domestic address by key method.</returns>
		/// <param name="key">Key.</param>
		private static AddressType GetAddressByKeyMethod(string key)
		{
            AddressType Address = new AddressType();
			var Service = GetAuthoriseService();
			try {
				// Call the GetDomesticAddressByKey soap service
				Address = Service.GetAddressByKey(key);
			} catch(Exception soapEx) {
				Console.WriteLine("{0}", soapEx.Message);
				throw;
			}
			return Address;
		}

		/// <summary>
        /// Gets the domestic address keys by postcode method.
        /// </summary>
        /// <returns>The domestic address keys by postcode method.</returns>
        /// <param name="postcode">Postcode.</param>
        private static AddressKeyType[] GetAddressKeysByPostcodeMethod(string postcode)
		{
			AddressKeyType[] availableAddresses;
			Service = GetAuthoriseService();
			try {
				// Call the GetDomesticAddressKeysByPostcode soap service
                availableAddresses = Service.GetAddressKeysByPostcode(postcode);
			} catch(Exception soapEx) {
				Console.WriteLine("{0}", soapEx.Message);
				throw;
			}
			return availableAddresses;
		}

		public static void Main()
		{
            LoadConfiguration();
            /*
             * Demonstrate getting an address by Postcode and place name/number
             * 
             **/
            Console.WriteLine("\n\n\n============================================");
            Console.WriteLine("Calling FindAddressMethod by LN12EU and 7");
            AddressType AddressDetail;
            try
            {
				AddressDetail = FindAddressMethod("LN12EU", "7");
                Console.WriteLine("Address details as follows");
                Console.WriteLine(AddressDetail.CompanyName);
                Console.WriteLine(AddressDetail.Street);
                Console.WriteLine(AddressDetail.Locality);
                Console.WriteLine(AddressDetail.TownCity);
                Console.WriteLine(AddressDetail.County);
                Console.WriteLine(AddressDetail.CountryCode);
                Console.WriteLine(AddressDetail.PostalCode);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
				throw;
            }

			/*
			 * Demonstrate getting a single address by its key
			 * 
			 **/
			Console.WriteLine("\n\n\n============================================");
            Console.WriteLine("Calling GetAddressByKeyMethod on key 1007");
			AddressType KeyMethodAddress;
			try {
				KeyMethodAddress = GetAddressByKeyMethod("LN12EU1007");
				Console.WriteLine("Address details as follows");
				Console.WriteLine(KeyMethodAddress.CompanyName);
				Console.WriteLine(KeyMethodAddress.Street);
				Console.WriteLine(KeyMethodAddress.Locality);
				Console.WriteLine(KeyMethodAddress.TownCity);
				Console.WriteLine(KeyMethodAddress.County);
				Console.WriteLine(KeyMethodAddress.CountryCode);
				Console.WriteLine(KeyMethodAddress.PostalCode);
				
			} catch(Exception ex) {
				Console.WriteLine(ex.Message);
				throw;
			}

			/*
			 * Demonstrate getting a list of address keys by Postcode
			 * 
			 **/
			Console.WriteLine("\n\n\n============================================");
            Console.WriteLine("Calling GetAddressKeysByPostcodeMethod by LN12EU");
            AddressKeyType[] addressKeyArray = null;
			try {
                addressKeyArray = GetAddressKeysByPostcodeMethod("LN12EU");
                foreach(AddressKeyType key in addressKeyArray){
                   Console.WriteLine("Address details as follows");
                    Console.WriteLine(key.Key);
                    Console.WriteLine(key.Address);
                }
				
			} catch(Exception ex) {
				Console.WriteLine(ex.Message);
				throw;
			}
		}
	}
}
