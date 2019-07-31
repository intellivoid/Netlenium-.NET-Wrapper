# Netlenium .NET Wrapper

This is a .NET Wrapper for Netlenium, this does not contain the
executable files for Netlenium or any of the actual functionalities
that Netlenium Provides.

You are required to install Netlenium on your preferred system
and make sure it's running before using this library. If you are
using a remote server that's hosting Netlenium, you don't need
Netlenium to be installed on your machine. You can specify the
remote address to connect to.

---------------------------------------------------------------------

## How to setup

This library does not require any special tools to build or use
with your project. You can either build from source or use the
already publicly available Nuget Package that's on Nuget.org


Using the package manager
```
Install-Package Netlenium
```

.NET CLI
```
dotnet add package Netlenium
```

Packet CLI
```
paket add Netlenium
```

If you lack the Netlenium installation on your system, you can
head over to [netlenium.intellivoid.info](https://netlenium.intellivoid.info/) to download the correct binary/setup for
your system. Note that if you want Netlenium to use Chrome, Firefox
or any of the browsers that it supports, those browsers needs
to be installed on your system too. Different variants are also
supported, for example; Firefox Developer Edition.


## Example Usage

You can construct a new session with the default driver.
```csharp
var browser = new Intellivoid.Netlenium.Client();

// Send a request to Netlenium to start the session
browser.Start();
```

If you need to specify the remote endpoint if Netlenium is not
running on your machine, it can simply be done like this
```csharp
var browser = new Intellivoid.Netlenium.Client("http://localhost:8080");

// Send a request to Netlenium to start the session
browser.Start();
```

Or if you want to specify what type of driver you intend on using
```csharp
var browser = new Intellivoid.Netlenium.Client(Intellivoid.Netlenium.DriverType.firefox);

// Send a request to Netlenium to start the session
browser.Start();
```


Netlenium can be configured to require authentication, you can
provide your authentication like this
```csharp
var browser = new Intellivoid.Netlenium.Client(
    targetDriver: Intellivoid.Netlenium.DriverType.auto,
    authenticationPassword: "Password123"
);

// Send a request to Netlenium to start the session
browser.Start();
```

Multiple arguments can be used including the ability to tell
Netlenium to start the driver using a proxy, so the Web Browser
would create connections through your proxy.
```csharp
var browser = new Intellivoid.Netlenium.Client(
    targetDriver: Intellivoid.Netlenium.DriverType.auto,
    proxyConfiguration: new Intellivoid.Netlenium.Proxy
    {
        Enabled = true,
        Host = "127.0.0.1",
        Port = 8080,
        Scheme = Intellivoid.Netlenium.ProxyScheme.https,
        AuthenticationRequired  = true,
        Username = "anonymous" ,
        Password = "anonyomus"
    }
);

// Send a request to Netlenium to start the session
browser.Start();
```

This example below demonstrates how you can use Netlenium to
automate a browser completely. This demo loads Google, types
into the search box, submits the form and waits for the page
to finish loading. Then goes through the search results and
prints out the text of all the results.

```csharp
Console.WriteLine("Navigating to Google");
browser.LoadUrl("https://google.com/");

Console.WriteLine("Typing into search box");
browser.GetElement(Intellivoid.Netlenium.By.Name, "q").SendKeys("Netlenium");

Console.WriteLine("Searching for results");
browser.GetElement(Intellivoid.Netlenium.By.Name, "q").Submit();

foreach(Intellivoid.Netlenium.Element element in browser.GetElements(Intellivoid.Netlenium.By.ClassName, "g"))
{
    // Go through each element and prints out the
    // "innerText" property.
    Console.WriteLine(element.InnerText);
    Console.WriteLine();
}

Console.WriteLine("Closing session");
browser.Stop();

Console.WriteLine("Done");
Console.ReadLine();
```