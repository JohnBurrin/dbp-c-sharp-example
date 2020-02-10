using System;
using System.Net;
using System.Xml;
using Accounts.com.despatchbay.api;

namespace Accounts
{
    class MainClass
    {
        private static string apiuser;
        private static string apikey;
        private static AccountService Service;

        /// <summary>
        /// Gets the authorise service. Loads a XML configuration file, creates a 
        /// Basic Auth credentials object and applies to the Service we want to use
        /// </summary>
        /// <returns>The authorise service.</returns>
        private static AccountService GetAuthoriseService()
        {
            // Set up some credentials
            NetworkCredential netCredential = new NetworkCredential(apiuser, apikey);
            // Create the service of type Tracking service
            Service = new AccountService()
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
            try
            {
                node = doc.DocumentElement.SelectSingleNode("/configuration/apiuser");
                apiuser = node.InnerText;
                node = doc.DocumentElement.SelectSingleNode("/configuration/apikey");
                apikey = node.InnerText;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
        public static void Main()
        {
            LoadConfiguration();

            AccountType MyAccount = new AccountType();
            MyAccount = GetAccount();
            Console.WriteLine("Account Details details as follows");
            Console.WriteLine("Account ID: {0}", MyAccount.AccountID);
            Console.WriteLine("Account Name: {0}", MyAccount.AccountName);
            Console.WriteLine("Account Balance: {0}", MyAccount.AccountBalance.Balance);
            Console.WriteLine("Account Available Balance: {0}", MyAccount.AccountBalance.AvailableBalance);
            Console.WriteLine("\n\n");

            SenderAddressType[] SendersAddresses;
            SendersAddresses = GetSenderAddresses();
            foreach (SenderAddressType key in SendersAddresses)
            {
                Console.WriteLine("Collection Address details as follows");
                Console.WriteLine("Sender Name: {0}", key.SenderName);
                Console.WriteLine("Sender Email: {0}", key.SenderEmail);
                Console.WriteLine("Sender Telephone: {0}", key.SenderTelephone);
                Console.WriteLine("Address details as follows");
                Console.WriteLine(key.SenderAddress.CompanyName);
                Console.WriteLine(key.SenderAddress.Street);
                Console.WriteLine(key.SenderAddress.Locality);
                Console.WriteLine(key.SenderAddress.TownCity);
                Console.WriteLine(key.SenderAddress.County);
                Console.WriteLine(key.SenderAddress.CountryCode);
                Console.WriteLine(key.SenderAddress.PostalCode);
                Console.WriteLine("\n");
            }

            PaymentMethodType[] PaymentMethods;
            PaymentMethods = GetPaymentMethods();
            foreach (PaymentMethodType key in PaymentMethods)
            {
                Console.WriteLine("Payment Method ID: {0}", key.PaymentMethodID);
                Console.WriteLine("Payment Method Description: {0}", key.Description);
            }
            Console.WriteLine("\n\n");

            ServiceType[] MyServices;
            MyServices = GetMyServices();
            foreach (ServiceType key in MyServices)
            {
                Console.WriteLine("Service ID: {0}, Courier: {1}, Service Name: {2}, Service Cost: {3}", key.ServiceID, key.Courier.CourierName, key.Name, key.Cost);
            }
            Console.WriteLine("\n\n");

            AccountBalanceType MyBalance;
            MyBalance = GetMyBalance();
            Console.WriteLine("Available Balance: {0}", MyBalance.AvailableBalance);
            Console.WriteLine("Balance: {0}", MyBalance.Balance);

        }

        /// <summary>
        /// The Account Service returns some basic information relating to your account
        /// </summary>
        /// <returns>AccountType</returns>
        private static AccountType GetAccount()
        {
            AccountType MyAccount = new AccountType();
            var Service = GetAuthoriseService();
            try
            {
                MyAccount = Service.GetAccount();
            }
            catch (Exception soapEx)
            {
                Console.WriteLine("{0}", soapEx.Message);
                throw;
            }
            return MyAccount;
        }

        /// <summary>
        /// Returns the Current and the Available Balance for the Account
        /// </summary>
        /// <returns>AccountBalanceType</returns>
        private static AccountBalanceType GetMyBalance()
        {
            AccountBalanceType MyBalance;
            var Service = GetAuthoriseService();
            try
            {
                MyBalance = Service.GetAccountBalance();
            }
            catch (Exception soapEx)
            {
                Console.WriteLine("{0}", soapEx.Message);
                throw;
            }

            return MyBalance;
        }

        /// <summary>
        /// Returns services available (allowed and enabled) for use
        /// </summary>
        /// <returns>ServiceType[]</returns>
        private static ServiceType[] GetMyServices()
        {
            ServiceType[] MyServices;
            var Service = GetAuthoriseService();
            try
            {
                MyServices = Service.GetServices();
            }
            catch (Exception soapEx)
            {
                Console.WriteLine("{0}", soapEx.Message);
                throw;
            }

            return MyServices;
        }

        /// <summary>
        /// Returns Registered payment methods
        /// </summary>
        /// <returns>PaymentMethodType[]</returns>
        private static PaymentMethodType[] GetPaymentMethods()
        {
            PaymentMethodType[] PaymentMethods;
            var Service = GetAuthoriseService();
            try
            {
                PaymentMethods = Service.GetPaymentMethods();
            }
            catch (Exception soapEx)
            {
                Console.WriteLine("{0}", soapEx.Message);
                throw;
            }

            return PaymentMethods;
        }

        /// <summary>
        /// Returns a list of sender addresses relating to the account.
        /// </summary>
        /// <returns>SenderAddressType[]</returns>
        private static SenderAddressType[] GetSenderAddresses()
        {
            SenderAddressType[] SendersAddresses;

            var Service = GetAuthoriseService();
            try
            {
                SendersAddresses = Service.GetSenderAddresses();
            }
            catch (Exception soapEx)
            {
                Console.WriteLine("{0}", soapEx.Message);
                throw;
            }

            return SendersAddresses;
        }
    }
}
