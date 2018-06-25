// ---------------------------------------------------------
// Copyrights (c) 2014-2018 LeafyDev 🍂 All rights reserved.
// ---------------------------------------------------------

using System.Drawing;
using System.Globalization;

// ReSharper disable UnusedMember.Global

namespace DiscordWebhook
{
    public static class Extensions
    {
        public static int ToRgb(this Color color) =>
            int.Parse(ColorTranslator.ToHtml(Color.FromArgb(color.ToArgb())).Replace("#", ""), NumberStyles.HexNumber);
    }
}