# OpenCVSharpWebDemo
This sample follows the [OpenCVSharp](https://github.com/shimat/opencvsharp) instruction article [http://schima.hatenablog.com/entry/2014/01/22/203026](http://schima.hatenablog.com/entry/2014/01/22/203026).

The Post-build event makes copy opencv-related dll files into `\bin` directory in order to fix `TypeInitializationException`. As such, if you want to deploy it to Azure or other remote host, you have to copy all files in `\bin\dll\x86` to `\bin`.

- OpenCVSharp nuget: https://www.nuget.org/packages/OpenCvSharp-AnyCPU/
- Version used: 2.4.10.20150820
- ASP.NET 4 MVC
- Visual Studio 2015
- Tested on IISExpress
- Tested on Azure WebApp (formerly called AzureWebsites)
