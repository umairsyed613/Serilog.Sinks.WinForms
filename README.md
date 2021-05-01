# Serilog.Sinks.WinForms

[![NuGet version](https://badge.fury.io/nu/Serilog.Sinks.WinForms.png)](https://badge.fury.io/nu/Serilog.Sinks.WinForms) ![Build Status](https://travis-ci.org/umairsyed613/Serilog.Sinks.WinForms.svg?branch=master) [![Nuget](https://img.shields.io/nuget/dt/Serilog.Sinks.WinForms)](https://www.nuget.org/packages/Serilog.Sinks.WinForms)

Writes [Serilog](https://serilog.net) events to Windows Froms Application TextBox or Datagridview control from anywhere in your application.

### Getting started

Install the [Serilog.Sinks.WinForms](https://www.nuget.org/packages/Serilog.Sinks.WinForms/) package from NuGet:

```powershell
Install-Package Serilog.Sinks.WinForms
```

To configure the sink in C# code, call `WriteToSimpleAndRichTextBox()` or `WriteToJsonTextBox()` or `WriteToGridView()` during logger configuration:

##### Simple Text Formatted Log And Rich TextBox Log Control

SimpleLogTextBox or RichTextBoxLogControl can be used from visual studio toolbox once the package is added to the project.

```csharp
Log.Logger = new LoggerConfiguration()
                        .WriteToSimpleAndRichTextBox()
                        .CreateLogger();
```

SimpleLogTextBox or RichTextBoxLogControl with custom Configuration. SimpleLogTextBox accepts [ITextFormatter](https://github.com/serilog/serilog/blob/dev/src/Serilog/Formatting/ITextFormatter.cs)

```csharp
Log.Logger = new LoggerConfiguration()
                        .WriteToSimpleAndRichTextBox(new MessageTemplateTextFormatter("{Timestamp} [{Level}] {Message} {Exception}"))
                        .CreateLogger();
```

##### Json Formatted Log

JsonLogTextBox can be used from visual studio toolbox once the package is added to the project.

```csharp
Log.Logger = new LoggerConfiguration()
                        .WriteToJsonTextBox()
                        .CreateLogger();
```

JsonLogTextBox with custom Configuration. JsonLogTextBox accepts [ITextFormatter](https://github.com/serilog/serilog/blob/dev/src/Serilog/Formatting/ITextFormatter.cs)

```csharp
Log.Logger = new LoggerConfiguration()
                        .WriteToJsonTextBox(new JsonFormatter())
                        .CreateLogger();
```

##### Datagridview Log

GridLog can be used from visual studio toolbox once the package is added to the project.

```csharp
Log.Logger = new LoggerConfiguration()
                        .WriteToGridView()
                        .CreateLogger();
```

#### Log For Context

SimpleLogTextBox, RichTextBoxLogControl or JsonLogTextBox can be configured to display log for specific ***Context***.
All of the controls have property **For Context** which can be configured with ***namespace.classname*** for example ***TestApplication.Form2*** you can find the sample here >> [Sample](https://github.com/umairsyed613/Serilog.Sinks.WinForms/blob/master/src/Sample/TestApplication/Form2.cs)

**Note:** Remember to configure Logger instance with ***Enrich.FromLogContext()***


#### Save and Clear Logs
SimpleLogTextBox, RichTextBoxLogControl or JsonLogTextBox have two method available for saving log to file or clear the log from the log control.
***ClearLogs()*** AND ***SaveLogToFile()***

Check the usage in sample application here [Sample](https://github.com/umairsyed613/Serilog.Sinks.WinForms/blob/master/src/Sample/TestApplication/Form2.cs)


### Sample Code

Find the sample running application [here](https://github.com/umairsyed613/Serilog.Sinks.WinForms/tree/master/Sample/TestApplication/)

![Sample](https://github.com/umairsyed613/Serilog.Sinks.WinForms/blob/master/SampleVideo.gif)
