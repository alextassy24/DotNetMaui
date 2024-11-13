namespace FitnessTracker.Styles
{
    public static class TailwindStyles
    {
        // Colors
        public static readonly Color Primary = Color.FromArgb("#1E40AF"); // Tailwind's blue-500
        public static readonly Color Secondary = Color.FromArgb("#10B981"); // Tailwind's green-500
        public static readonly Color Danger = Color.FromArgb("#EF4444"); // Tailwind's red-500
        public static readonly Color Warning = Color.FromArgb("#22C55E"); // Tailwind's yellow-500

        // Padding
        public static readonly Thickness P1 = new(4);
        public static readonly Thickness P2 = new(8);
        public static readonly Thickness P4 = new(16);
        public static readonly Thickness P6 = new(24);
        public static readonly Thickness P8 = new(32);

        // Margin
        public static readonly Thickness M1 = new(4);
        public static readonly Thickness M2 = new(8);
        public static readonly Thickness M4 = new(16);
        public static readonly Thickness M6 = new(24);
        public static readonly Thickness M8 = new(32);

        // Text Sizes
        public static readonly double TextSm = 12;
        public static readonly double TextBase = 14;
        public static readonly double TextLg = 18;
        public static readonly double TextXl = 20;
        public static readonly double Text2Xl = 24;
        public static readonly double Text3Xl = 30;

        // Border Radius
        public static readonly CornerRadius RoundedSm = new(4);
        public static readonly CornerRadius RoundedMd = new(8);
        public static readonly CornerRadius RoundedLg = new(12);

        // Shadows
        public static readonly Shadow ShadowSm = new() { Opacity = 0.2f, Offset = new Point(0, 1), Radius = 1 };
        public static readonly Shadow ShadowMd = new() { Opacity = 0.4f, Offset = new Point(0, 4), Radius = 6 };

        // Example reusable style for buttons
        public static Style PrimaryButton => new(typeof(Button))
        {
            Setters =
            {
                new Setter { Property = Button.BackgroundColorProperty, Value = Primary },
                new Setter { Property = Button.TextColorProperty, Value = Colors.White },
                new Setter { Property = Button.CornerRadiusProperty, Value = 8 },
                new Setter { Property = Button.PaddingProperty, Value = P4 }
            }
        };

        public static Style SecondaryButton => new(typeof(Button))
        {
            Setters =
            {
                new Setter { Property = Button.BackgroundColorProperty, Value = Secondary },
                new Setter { Property = Button.TextColorProperty, Value = Colors.White },
                new Setter { Property = Button.CornerRadiusProperty, Value = 8 },
                new Setter { Property = Button.PaddingProperty, Value = P4 }
            }
        };

        public static Style DangerButton => new(typeof(Button))
        {
            Setters =
            {
                new Setter { Property = Button.BackgroundColorProperty, Value = Danger },
                new Setter { Property = Button.TextColorProperty, Value = Colors.White },
                new Setter { Property = Button.CornerRadiusProperty, Value = 8 },
                new Setter { Property = Button.PaddingProperty, Value = P4 }
            }
        };
    }
}
