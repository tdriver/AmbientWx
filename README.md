# AmbientWx
## A .Net Core SDK for AmbientWeather.net API
This SDK allows a .Net Core developer to use the API provided by AmbientWeather.net to retrieve weather results from
their personal weather station.
To use this SDK, you must create a file named AmbientWx.config and place it in the folder with the AmbientWx.dll file.
The config file contents should look like this:
```xml
<?xml version="1.0" encoding="utf-8" ?>
<configuration>
  <appSettings>
    <add key="ApiKey" value="Your Api Key" />
    <add key="ApplicationKey" value="Your Application Key" />
    <add key="BaseUrl" value="https://api.ambientweather.net" />
  </appSettings>
</configuration>
```
Be sure to use your apiKey and applicationKey provided by AmbientWeather.net.  See their API documentation page 
[here](https://ambientweather.docs.apiary.io/#) for more information.

## How to use the API
Search for AmbientWx on Nuget, then install the package.  Since this is .Net Core, it is usable on Windows, MAcs and 
Linux platforms.
Example call:
First, ensure you're AmbientWx.config is in place.
Then, in your code, make this call:
```C#
List<UserDevice> request = UserDevicesRequest.GetUserDevices();
```
You can then iterate through your devices and the data for each one.
See the source code tests for usage as well.

## APIs implemented to date:
+ UserDevices

## APIs Coming Soon
+ Device Data
+ Real Time
