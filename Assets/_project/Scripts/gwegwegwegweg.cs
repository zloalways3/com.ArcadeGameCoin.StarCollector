using System;
using System.Collections.Generic;
using UnityEngine;
using ZeroSDK.UIBuilder.AddOns.Button;
using ZeroSDK.UIBuilder.Core;
using ZeroSDK.UIBuilder.Core.UIElements;

namespace _project.Scripts
{
    public sealed class gwegwegwegweg : thygtfrdsd
    {
        [SerializeField] private rewgrehtrn exitButton;
        [SerializeField] private List<rewgrehtrn> levelButtons;

        public event Action iuyjtyhrtgrefsedsfregtrh
        {
            add => exitButton.hehreherh += value;
            remove => exitButton.hehreherh += value;
        }

        public event Action<int> hrereherherh;

        protected override void jrjrtrtnrbererv()
        {
            for (int i = 0; i < levelButtons.Count; i++)
            {
                var id = i;
                levelButtons[i].hehreherh += () => hrereherherh?.Invoke(id);
            }
        }

        public void hehreherherh(int levelsCount)
        {
            for (int i = 0; i < Mathf.Min(levelsCount+1, levelButtons.Count); i++)
            {
                var fadeValue = i < levelsCount+1 ? 1 : 0.16f;
                levelButtons[i].CG.alpha = fadeValue;
            }
        }
        
        protected override void ewregtrhnht() => qewrfegtrfhng.ewregtrh.ewregthrnhg<BackgroundScreen>().ShowBlur();
    }
}