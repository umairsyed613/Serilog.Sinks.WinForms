# Serilog.WinForms

Writes [Serilog](https://serilog.net) events to Winforms TextBox control from anywhere in your application.

### Getting started

Install the [Serilog.WinForms](https://www.nuget.org/packages/Serilog.Sinks.File/) package from NuGet:

```powershell
Install-Package Serilog.WinForms
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

Find the sample running application [here](https://github.com/umairsyed613/Serilog.WinForms/tree/master/Sample/TestApplication/)

![Sample](https://github.com/umairsyed613/Serilog.WinForms/blob/master/sample.gif)
