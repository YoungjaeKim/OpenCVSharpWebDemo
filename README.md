# OpenCVSharpWebDemo
This sample follows the [OpenCVSharp](https://github.com/shimat/opencvsharp) instruction article [http://schima.hatenablog.com/entry/2014/01/22/203026](http://schima.hatenablog.com/entry/2014/01/22/203026).

It copies opencv-related dll files into `\bin` directory as a Post-build event in order to fix `TypeInitializationException`.

- OpenCVSharp nuget: https://www.nuget.org/packages/OpenCvSharp-AnyCPU/
- Version used: 2.4.10.20150820
- ASP.NET 4 MVC
- Visual Studio 2015
- Tested on IISExpress
