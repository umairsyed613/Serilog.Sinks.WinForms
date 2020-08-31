# Serilog.Sinks.WinForms

[![NuGet version](https://badge.fury.io/nu/Serilog.Sinks.WinForms.png)](https://badge.fury.io/nu/Serilog.Sinks.WinForms) ![Build Status](https://travis-ci.org/umairsyed613/Serilog.Sinks.WinForms.svg?branch=master) ![Nuget](https://img.shields.io/nuget/dt/Serilog.Sinks.WinForms)

Writes [Serilog](https://serilog.net) events to Winforms TextBox control from anywhere in your application.

### Getting started

Install the [Serilog.Sinks.WinForms](https://www.nuget.org/packages/Serilog.Sinks.WinForms/) package from NuGet:

```powershell
Install-Package Serilog.Sinks.WinForms
```

To configure the sink in C# code, call `WriteTo.Sink()` during logger configuration:

##### Simple Text Formatted Log
```csharp
Log.Logger = new LoggerConfiguration()
                        .WriteTo.Sink(WindFormsSink.SimpleTextBoxSink)
                        .CreateLogger();
```

##### Json Formatted Log

```csharp
Log.Logger = new LoggerConfiguration()
                        .WriteTo.Sink(WindFormsSink.JsonTextBoxSink)
                        .CreateLogger();
```

### Sample Code

Find the sample running application [here](https://github.com/umairsyed613/Serilog.Sinks.WinForms/tree/master/Sample/TestApplication/)

![Sample](https://github.com/umairsyed613/Serilog.Sinks.WinForms/blob/master/sample.gif)
