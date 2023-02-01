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


You must add this namespace to your `xaml` files:

```XML
xmlns:controls="http://www.pankaj_singh_apps.de/maui/controls"
```

Now you can use the `SimpleRatingControl` from this namespace:
```XML

<controls:RatingControl Amount="5" 
                        CurrentValue="1" 
                        AccentColor="Gold" 
                        FontSize="36"/>
```


## Available Properties

| Property       | Type          | Description                                              | Default Value |
|----------------|---------------|----------------------------------------------------------|---------------|
| `CurrentValue` | `double`      | Sets the value which should be used as the rating.       | `0`           |
| `Amount`       | `double`      | Sets the maximum amount                                  | `5`           |
| `FontSize`     | `double`      | Sets the size of each element.                           | `24`          |
| `AccentColor`  | `Color`       | Sets the color of the element.                           | `Gold`        |		


```- Listed on [nuget.org](https://www.nuget.org/packages/pankaj.util.RatingControl)		
