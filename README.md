# Serilog.Sinks.WinForms

[![NuGet version](https://badge.fury.io/nu/Serilog.WinForms.svg)](https://badge.fury.io/nu/Serilog.WinForms) ![Build Status](https://travis-ci.org/umairsyed613/Serilog.Sinks.WinForms.svg?branch=master) ![Nuget](https://img.shields.io/nuget/dt/Serilog.Sinks.WinForms)

Writes [Serilog](https://serilog.net) events to Winforms TextBox control from anywhere in your application.

### Getting started

Install the [Serilog.Sinks.WinForms](https://www.nuget.org/packages/Serilog.Sinks.WinForms/) package from NuGet:

```powershell
Install-Package Serilog.Sinks.WinForms
```

To configure the sink in C# code, call `WriteToSimpleTextBox()` or `WriteToJsonTextBox()` during logger configuration:

##### Simple Text Formatted Log

SimpleLogTextBox can be used from visual studio toolbox once the package is added to the project.

```csharp
Log.Logger = new LoggerConfiguration()
                        .WriteToSimpleTextBox()
                        .CreateLogger();
```

##### Json Formatted Log

JsonLogTextBox can be used from visual studio toolbox once the package is added to the project.

```csharp
Log.Logger = new LoggerConfiguration()
                        .WriteToJsonTextBox()
                        .CreateLogger();
```

### Sample Code

Find the sample running application [here](https://github.com/umairsyed613/Serilog.Sinks.WinForms/tree/master/Sample/TestApplication/)

![Sample](https://github.com/umairsyed613/Serilog.Sinks.WinForms/blob/master/sample.gif)
