using NUnit.Framework;
using System;
using System.IO;
using System.Threading;

namespace MorphicLiteAutomation.Objects
{
    class Volume : SetUp
    {

        public void CheckMuteAllSounds()
        {
            try
            {
                var defaultAudioEndpoint = Morphic.Windows.Native.AudioEndpoint.GetDefaultAudioOutputEndpoint();
                defaultAudioEndpoint.SetMasterMuteState(false);
                Assert.IsFalse(defaultAudioEndpoint.GetMasterMuteState());

                driver.FindElementByName("Mute All Sounds").Click();
                var muteStateTrue = defaultAudioEndpoint.GetMasterMuteState();
                Assert.IsTrue(muteStateTrue);

            }
            catch (IOException e)
            {
                Console.WriteLine($"The mute button on Volume was not found: '{e}'");
            }
        }
        public void CheckTurntheVolumeUp()
        {
            try
            {
                var defaultAudioEndpoint = Morphic.Windows.Native.AudioEndpoint.GetDefaultAudioOutputEndpoint();
                defaultAudioEndpoint.SetMasterVolumeLevel(0.5f);
                float beforeVolumeUp = defaultAudioEndpoint.GetMasterVolumeLevel();
                Assert.AreEqual(beforeVolumeUp, 0.5f);

                driver.FindElementByName("Turn the Volume Up").Click();
                float afterFirstVolumeUp = defaultAudioEndpoint.GetMasterVolumeLevel();
                Assert.AreEqual(afterFirstVolumeUp, 0.5f);

                driver.FindElementByName("Turn the Volume Up").Click();
                float afterSecondVolumeUp = defaultAudioEndpoint.GetMasterVolumeLevel();
                Assert.AreEqual(afterSecondVolumeUp, 0.6f);
            }
            catch (IOException e)
            {
                Console.WriteLine($"The plus button on Volume was not found: '{e}'");
            }
        }
        public void CheckTurntheVolumeDown()
        {
            try
            {
                var defaultAudioEndpoint = Morphic.Windows.Native.AudioEndpoint.GetDefaultAudioOutputEndpoint();
                float beforeVolumeDown = defaultAudioEndpoint.GetMasterVolumeLevel();
                Assert.AreEqual(beforeVolumeDown, 0.6f);

                driver.FindElementByName("Turn the Volume Down").Click();
                float afterFirstVolumeDown = defaultAudioEndpoint.GetMasterVolumeLevel();
                Assert.AreEqual(afterFirstVolumeDown, 0.5f);

                driver.FindElementByName("Turn the Volume Down").Click();
                float afterSecondVolumeDown = defaultAudioEndpoint.GetMasterVolumeLevel();
                Assert.AreEqual(afterSecondVolumeDown, 0.4f);
            }
            catch (IOException e)
            {
                Console.WriteLine($"The minus button on Volume was not found: '{e}'");
            }
        }


    }
}
