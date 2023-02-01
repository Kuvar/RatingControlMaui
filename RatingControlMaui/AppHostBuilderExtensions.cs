namespace RatingControlMaui
{
    // All the code in this file is included in all platforms.
    public static class AppHostBuilderExtensions
    {
        public static MauiAppBuilder UseRatingControl(this MauiAppBuilder builder)
        {
            builder.ConfigureFonts(fonts =>
            {
                fonts.AddEmbeddedResourceFont(typeof(AppHostBuilderExtensions).Assembly, "materialdesignicons-webfont.ttf", "MDI");
            });
            return builder;
        }
    }
}