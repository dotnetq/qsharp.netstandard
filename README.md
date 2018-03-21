# qsharp.standard
qsharp ported to .NET Standard

<!-- img src="http://www.devnet.de/fileadmin/images/DEVnet_Logo2014.png" width="150px" height="150px"/-->

qSharp 2.3 (Unofficial port to .NET Standard)
==========

The q/kdb+ interface is implemented as a set of C# classes and provides:
- Simple to use API
- Support for synchronous and asynchronous queries
- Convenient asynchronous callbacks mechanism
- Support for kdb+ protocol and types: v3.0, v2.6, v<=2.5
- Uncompression of the IPC data stream
- Target framework: .NET Standard 2.0 (.NET Core 2.0 + .NET 4.7.1 compatible)


For more details please refer to the [documentation](doc/Readme.md)

Installation
============

To install qSharp from [NuGet Gallery](http://www.nuget.org/packages/qSharp/):

``nuget install qSharp``