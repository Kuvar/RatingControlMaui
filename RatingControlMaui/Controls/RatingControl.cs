using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatingControlMaui
{
    public partial class RatingControl : HorizontalStackLayout
    {
        public static readonly BindableProperty CurrentValueProperty = BindableProperty.Create(
            nameof(CurrentValue),
            typeof(double),
            typeof(RatingControl), 0d, BindingMode.TwoWay, propertyChanged: OnPropertyChanged);

        public static readonly BindableProperty AmountProperty = BindableProperty.Create(
                nameof(Amount),
                typeof(int),
                typeof(RatingControl), 5, BindingMode.TwoWay, propertyChanged: OnPropertyChanged);

        public static readonly BindableProperty FontSizeProperty = BindableProperty.Create(
                nameof(FontSize),
                typeof(double),
                typeof(RatingControl), 24d, BindingMode.TwoWay, propertyChanged: OnPropertyChanged);

        public static readonly BindableProperty AccentColorProperty = BindableProperty.Create(
        nameof(AccentColor),
        typeof(Color),
        typeof(RatingControl), Colors.Gold, BindingMode.TwoWay, propertyChanged: OnPropertyChanged);

        public double CurrentValue
        {
            get => (double)GetValue(CurrentValueProperty);
            set => SetValue(CurrentValueProperty, value);
        }

        public int Amount
        {
            get => (int)GetValue(AmountProperty);
            set => SetValue(AmountProperty, value);
        }

        public double FontSize
        {
            get => (double)GetValue(FontSizeProperty);
            set => SetValue(FontSizeProperty, value);
        }

        public Color AccentColor
        {
            get => (Color)GetValue(AccentColorProperty);
            set => SetValue(AccentColorProperty, value);
        }


        private static void OnPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var ctrl = (RatingControl)bindable;
            ctrl.UpdateLayout();
        }

        public RatingControl()
        {
            HorizontalOptions = LayoutOptions.Center;
            VerticalOptions = LayoutOptions.Center;

            UpdateLayout();
        }

        private void UpdateLayout()
        {
            Children.Clear();

            var intValue = (int)ClampValue(CurrentValue);
            var decimalPart = CurrentValue - intValue;
            bool isHalfStar = false;

            if (decimalPart > .25)
            {
                if (decimalPart > 0.25 && decimalPart <= .75)
                {
                    isHalfStar = true;
                }
                else
                {
                    intValue++;
                }
            }

            for (int i = 0; i < Amount; i++)
            {
                if (intValue > i)
                {
                    Add(CreateLabel(State.Full));
                }
                else if (intValue <= i && isHalfStar)
                {
                    Add(CreateLabel(State.Half));
                    isHalfStar = false;
                }
                else
                {
                    Add(CreateLabel(State.Empty));
                }
            }
        }

        private Label CreateLabel(State state)
        {
            return new Label
            {
                FontFamily = "MDI",
                TextColor = AccentColor,
                FontSize = FontSize,
                Text = state switch
                {
                    State.Empty => MaterialDesignIconsFont.StarOutline,
                    State.Half => MaterialDesignIconsFont.StarHalfFull,
                    State.Full => MaterialDesignIconsFont.Star,
                    _ => MaterialDesignIconsFont.StarOutline,
                }
            };
        }

        private double ClampValue(double value)
        {

            if (value < 0)
                return 0;

            if (value > Amount)
                return Amount;

            return value;
        }


    }

    internal enum State
    {
        Empty,
        Half,
        Full
    }

    internal class MaterialDesignIconsFont
    {
        public const string StarOutline = "\U000f04d2";
        public const string StarHalfFull = "\U000f04d0";
        public const string Star = "\U000f04ce";
    }
}
