using MorphicLiteAutomation.Objects;

namespace MorphicLiteAutomation
{
    class Program
    {
        static void Main()
        {

            Install install = new Install();
            install.InstallMorphic();

            SetUp setUp = new SetUp();
            setUp.Initialize();

            TextSize textSize = new TextSize();
            textSize.TestIncreaseTextSize();
            textSize.TestDecreaseTextSize();


            Magnifier magnifier = new Magnifier();
            magnifier.CheckMagnifierShow();
            magnifier.CheckMagnifierHide();

            ScreenReader screenReader = new ScreenReader();
            screenReader.CheckScreenReaderShow();
            screenReader.CheckScreenReaderHide();

            Volume volume = new Volume();
            volume.TestMute();
            volume.TestVolumeUp();
            volume.TestVolumeDown();



            Contrast highContrast = new Contrast();
            highContrast.CheckHighContrastOn();
            highContrast.CheckHighContrastOff();

            LogoButton logoButton = new LogoButton();
            logoButton.CheckLogoButton();

            Uninstall uninstall = new Uninstall();
            uninstall.UninstallMorphic();
        }
    }
}
