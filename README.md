# Despatch Bay API examples in C# #

Simple C# implementation of the Despatch Bay Pro API, this implementation is not to be considered be production safe, so be warned.

I would recommend checking this out and seeing if it will compile without updating the Web References, 

These examples were built using Visual Studio 2019 using DBP API v15 


### How do I get set up? ###

The solution contains four projects: 

* Tracking Api project
* Addressing Api project 
* Shipping Api project.
* Accounts Api project.

Checkout the repo update the configuration files and build all should work, you WILL need a DBP account and an apiuser and an apikey. It won't run with out those.

Each project requires a configuration.xml file, there is a configuration.xml-template in each project.
plug the apiuser, apikey and apiendpoint in each configuration file.

For example this is a sample shipping configuration.xml


```
<configuration>
	<apiuser>MyApiUser</apiuser>
	<apikey>MyApiKey</apikey>
</configuration>
```


It's VERY basic, and there is little to no error handling.

Despatch Bay's API documentation can be found here https://github.com/despatchbay/api.v15/wiki

Despatch Bay now have API rate limiting so during development expect the odd issue as you will probably breach them, you can ask them to up the limit and they'll do it for you.

My advice is to set up a demo account and try the shipping example, a nice feature of the shipping API is that it will return a label url, somthing like https://api.despatchbay.com/documents/v1/labels/ds2IumDG2AlqVU
which you can then either curl or pop straight in to a browser. (for more information see https://github.com/despatchbay/despatchbay-api-v15/wiki/Documents-API)

If that works, use the tracking API to track the shipment you just made, Despatch Bay's demo mode will fake the tracking for you to test.

The try the Addressing API, bare in mind safe guards have been put in place in Demo mode to prevent abuse. Addressing API will return random addresses and only two Demo couriers are available, but it's enough to get you going.

Finally take a look at the Accounts API, this gives you usefull information about your account, like balance information and collections addresses.

I don't work for Despatch Bay so please don't ask any account related questions because I won't be able to help. If you have any questions related to the API examples I'll try to help where I can. 
