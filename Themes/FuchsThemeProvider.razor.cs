using System.Text;
using Microsoft.AspNetCore.Components;

namespace FuchsBlazor
{
    /// <summary>
    /// Provides the colour themes for the components.
    /// </summary>
    public partial class FuchsThemeProvider : ComponentBase
    {
        private FuchsTheme? _theme = new FuchsTheme();

        [Parameter]
        public FuchsTheme? Theme { get => _theme; set => _theme = value; }

        protected override void OnInitialized()
        {
            _theme = Theme ?? new FuchsTheme();
            base.OnInitialized();
        }

        protected override void OnParametersSet()
        {
            if (Theme is not null)
                if (!ReferenceEquals(_theme, Theme))
                    _theme = Theme;
            base.OnParametersSet();
        }

        protected string BuildTheme()
        {
            _theme = Theme ?? new FuchsTheme();
            var theme = new StringBuilder();
            theme.AppendLine("<style>");
            theme.Append(_theme.PseudoCss.Scope);
            theme.AppendLine("{");
            GenerateTheme(theme);
            theme.AppendLine("}");
            theme.AppendLine("</style>");

            return theme.ToString();
        }

        private void GenerateTheme(StringBuilder theme)
        {
            theme.AppendLine($"--fuchs__bg-color: {_theme.BgColor}");
            theme.AppendLine($"--fuchs__bg-color-dark: {_theme.BgColorDark}");
            theme.AppendLine($"--fuchs__bg-color-darker: {_theme.BgColorDarker}");
            theme.AppendLine($"--fuchs__bg-color-darkest: {_theme.BgColorDarkest}");
            theme.AppendLine($"--fuchs__txt-color: {_theme.TxtColor}");
            theme.AppendLine($"--fuchs__txt-color-light: {_theme.TxtColorLight}");
            theme.AppendLine($"--fuchs__txt-color-dark: {_theme.TxtColorDark}");
            theme.AppendLine($"--fuchs__txt-color-inverted: {_theme.TxtColorInverted}");
            theme.AppendLine($"--fuchs__heading-color: {_theme.HeadingColor}");
            theme.AppendLine($"--fuchs__color-blue-primary: {_theme.ColorBluePrimary}");
            theme.AppendLine($"--fuchs__color-blue-light: {_theme.ColorBlueLight}");
            theme.AppendLine($"--fuchs__color-blue-dark: {_theme.ColorBlueDark}");
            theme.AppendLine($"--fuchs__color-blue-darker: {_theme.ColorBlueDarker}");
            theme.AppendLine($"--fuchs__color-green-primary: {_theme.ColorGreenPrimary}");
            theme.AppendLine($"--fuchs__color-green-light: {_theme.ColorGreenLight}");
            theme.AppendLine($"--fuchs__color-green-dark: {_theme.ColorGreenDark}");
            theme.AppendLine($"--fuchs__color-green-darker: {_theme.ColorGreenDarker}");
            theme.AppendLine($"--fuchs__color-yellow-primary: {_theme.ColorYellowPrimary}");
            theme.AppendLine($"--fuchs__color-yellow-light: {_theme.ColorYellowLight}");
            theme.AppendLine($"--fuchs__color-yellow-dark: {_theme.ColorYellowDark}");
            theme.AppendLine($"--fuchs__color-yellow-darker: {_theme.ColorYellowDarker}");
            theme.AppendLine($"--fuchs__color-orange-primary: {_theme.ColorOrangePrimary}");
            theme.AppendLine($"--fuchs__color-orange-light: {_theme.ColorOrangeLight}");
            theme.AppendLine($"--fuchs__color-orange-dark: {_theme.ColorOrangeDark}");
            theme.AppendLine($"--fuchs__color-orange-darker: {_theme.ColorOrangeDarker}");
            theme.AppendLine($"--fuchs__color-red-primary: {_theme.ColorRedPrimary}");
            theme.AppendLine($"--fuchs__color-red-light: {_theme.ColorRedLight}");
            theme.AppendLine($"--fuchs__color-red-dark: {_theme.ColorRedDark}");
            theme.AppendLine($"--fuchs__color-red-darker: {_theme.ColorRedDarker}");
            theme.AppendLine($"--fuchs__color-pink-primary: {_theme.ColorPinkPrimary}");
            theme.AppendLine($"--fuchs__color-pink-light: {_theme.ColorPinkLight}");
            theme.AppendLine($"--fuchs__color-pink-dark: {_theme.ColorPinkDark}");
            theme.AppendLine($"--fuchs__color-pink-darker: {_theme.ColorPinkDarker}");
            theme.AppendLine($"--fuchs__color-purple-primary: {_theme.ColorPurplePrimary}");
            theme.AppendLine($"--fuchs__color-purple-light: {_theme.ColorPurpleLight}");
            theme.AppendLine($"--fuchs__color-purple-dark: {_theme.ColorPurpleDark}");
            theme.AppendLine($"--fuchs__color-purple-darker: {_theme.ColorPurpleDarker}");
            theme.AppendLine($"--fuchs__color-accent-primary: {_theme.ColorAccentPrimary}");
            theme.AppendLine($"--fuchs__color-accent-light: {_theme.ColorAccentLight}");
            theme.AppendLine($"--fuchs__color-accent-dark: {_theme.ColorAccentDark}");
            theme.AppendLine($"--fuchs__color-accent-darker: {_theme.ColorAccentDarker}");
            theme.AppendLine($"--fuchs__color-success-primary: {_theme.ColorSuccessPrimary}");
            theme.AppendLine($"--fuchs__color-success-light: {_theme.ColorSuccessLight}");
            theme.AppendLine($"--fuchs__color-success-dark: {_theme.ColorSuccessDark}");
            theme.AppendLine($"--fuchs__color-success-darker: {_theme.ColorSuccessDarker}");
            theme.AppendLine($"--fuchs__color-info-primary: {_theme.ColorInfoPrimary}");
            theme.AppendLine($"--fuchs__color-info-light: {_theme.ColorInfoLight}");
            theme.AppendLine($"--fuchs__color-info-dark: {_theme.ColorInfoDark}");
            theme.AppendLine($"--fuchs__color-info-darker: {_theme.ColorInfoDarker}");
            theme.AppendLine($"--fuchs__color-warning-primary: {_theme.ColorWarningPrimary}");
            theme.AppendLine($"--fuchs__color-warning-light: {_theme.ColorWarningLight}");
            theme.AppendLine($"--fuchs__color-warning-dark: {_theme.ColorWarningDark}");
            theme.AppendLine($"--fuchs__color-warning-darker: {_theme.ColorWarningDarker}");
            theme.AppendLine($"--fuchs__color-danger-primary: {_theme.ColorDangerPrimary}");
            theme.AppendLine($"--fuchs__color-danger-light: {_theme.ColorDangerLight}");
            theme.AppendLine($"--fuchs__color-danger-dark: {_theme.ColorDangerDark}");
            theme.AppendLine($"--fuchs__color-danger-darker: {_theme.ColorDangerDarker}");
            theme.AppendLine($"--fuchs__color-light-primary: {_theme.ColorLightPrimary}");
            theme.AppendLine($"--fuchs__color-light-light: {_theme.ColorLightLight}");
            theme.AppendLine($"--fuchs__color-light-dark: {_theme.ColorLightDark}");
            theme.AppendLine($"--fuchs__color-light-darker: {_theme.ColorLightDarker}");
            theme.AppendLine($"--fuchs__color-dark-primary: {_theme.ColorDarkPrimary}");
            theme.AppendLine($"--fuchs__color-dark-light: {_theme.ColorDarkLight}");
            theme.AppendLine($"--fuchs__color-dark-dark: {_theme.ColorDarkDark}");
            theme.AppendLine($"--fuchs__color-dark-darker: {_theme.ColorDarkDarker}");
            theme.AppendLine($"--fuchs__tap-highlight-color: {_theme.TapHighlightColor}");
            theme.AppendLine($"--fuchs__link-color: {_theme.LinkColor}");
            theme.AppendLine($"--fuchs__link-color__hover: {_theme.LinkColorHover}");
            theme.AppendLine($"--fuchs__link-color__focus: {_theme.LinkColorFocus}");
        }
    }
}