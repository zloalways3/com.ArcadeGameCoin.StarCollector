using System;
using UnityEngine;
using UnityEngine.UI;
using ZeroSDK.UIBuilder.AddOns.Button;
using ZeroSDK.UIBuilder.Core;
using ZeroSDK.UIBuilder.Core.UIElements;

namespace _project.Scripts
{
    public sealed class wgwegwgwegweg : thygtfrdsd
    {
        [SerializeField] private rewgrehtrn exitButton;
        [SerializeField] private rewgrehtrn musicOnButton;
        [SerializeField] private rewgrehtrn musicOffButton;
        [SerializeField] private rewgrehtrn soundOnButton;
        [SerializeField] private rewgrehtrn soundOffButton;

        public event Action OnExitButton
        {
            add => exitButton.hehreherh += value;
            remove => exitButton.hehreherh += value;
        }

        protected override void jrjrtrtnrbererv()
        {
            {
                var v = PlayerPrefs.GetFloat("Music", 1);
                yherh(v);
            }

            {
                var v = PlayerPrefs.GetFloat("Effects", 1);
                hetherhre(v);
            }

            soundOnButton.hehreherh += () =>
            {
                wgewgwgwegwegwe.ewregtrh.SetGameEffectsVolumeSync(1);
                hetherhre(1);
            };
            soundOffButton.hehreherh += () =>
            {
                wgewgwgwegwegwe.ewregtrh.SetGameEffectsVolumeSync(0);
                hetherhre(0);
            };
            musicOnButton.hehreherh += () =>
            {
                wgewgwgwegwegwe.ewregtrh.SetGameMusicVolumeSync(1);
                yherh(1);
            };
            musicOffButton.hehreherh += () =>
            {
                wgewgwgwegwegwe.ewregtrh.SetGameMusicVolumeSync(0);
                yherh(0);
            };
        }

        private void hetherhre(float v)
        {
            soundOnButton.CG.alpha = 1;
            soundOffButton.CG.alpha = 1;
            if (v > 0.5f)
                soundOffButton.CG.alpha = 0.5f;
            else
                soundOnButton.CG.alpha = 0.5f;
        }

        private void yherh(float v)
        {
            musicOnButton.CG.alpha = 1;
            musicOffButton.CG.alpha = 1;
            if (v > 0.5f)
                musicOffButton.CG.alpha = 0.5f;
            else
                musicOnButton.CG.alpha = 0.5f;
        }
    }
}