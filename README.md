# Rating Control for .NET MAUI
A Rating Control for .NET MAUI using an icon font.


## Setup

Available on NuGet: [RatingControl.MAUI](https://www.nuget.org/packages/pankaj.util.RatingControl)

[![NuGet](https://img.shields.io/nuget/v/SimpleRatingControl.MAUI.svg?label=NuGet&color=blue)](https://www.nuget.org/packages/pankaj.util.RatingControl)

Just add the package to your .NET MAUI application.


## API Usage

Initialize the package by calling `UseSimpleRatingControl()` on `MauiProgram`:
```CSHARP
var builder = MauiApp.CreateBuilder();

builder
	.UseMauiApp<App>()
	.UseSimpleRatingControl()

    // other configurations

return builder.Build();
```
