# Rating Control for .NET MAUI
A Rating Control for .NET MAUI using an icon font.


## Setup

Available on NuGet: [RatingControl.MAUI](https://www.nuget.org/packages/pankaj.util.RatingControl)

Just add the package to your .NET MAUI application.


## API Usage

Initialize the package by calling `UseRatingControl()` on `MauiProgram`:
```CSHARP
var builder = MauiApp.CreateBuilder();

builder
	.UseMauiApp<App>()
	.UseRatingControl()

    // other configurations

return builder.Build();
```
