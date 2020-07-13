using MorphicLiteAutomation.Objects;

namespace MorphicLiteAutomation
{
    class Program
    {
        static void Main()
        {
            SetUp setUp = new SetUp();
            setUp.Initialize();

            TextSize textSize = new TextSize();
            textSize.CheckTextSizePlus();
            textSize.CheckTextSizeMinus();


            Magnifier magnifier = new Magnifier();
            magnifier.CheckMagnifierShow();
            magnifier.CheckMagnifierHide();

            ScreenReader screenReader = new ScreenReader();
            screenReader.CheckScreenReaderShow();
            screenReader.CheckScreenReaderHide();

            Volume volume = new Volume();
            volume.CheckTurntheVolumeUp();
            volume.CheckTurntheVolumeDown();
            volume.CheckMuteAllSounds();


            HighContrast highContrast = new HighContrast();
            highContrast.CheckHighContrastOn();
            highContrast.CheckHighContrastOff();

            LogoButton logoButton = new LogoButton();
            logoButton.CheckLogoButton();
        }
    }
}
