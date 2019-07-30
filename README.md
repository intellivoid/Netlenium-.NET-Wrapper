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