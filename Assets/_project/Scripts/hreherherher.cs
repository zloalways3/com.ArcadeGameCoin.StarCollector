using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using ZeroSDK.UIBuilder.AddOns.Button;
using ZeroSDK.UIBuilder.Core.UIElements;

namespace _project.Scripts
{
    public sealed class hreherherher : thygtfrdsd
    {
        [SerializeField] private TextMeshProUGUI pointsText;
        [SerializeField] private List<rewgrehtrn> buttons;
        [SerializeField] private rewgrehtrn exitButton;

        
        [SerializeField] private List<int> costs = new List<int>()
        {
            300, 500, 1000, 1500, 2000, 3000
        };

        [SerializeField] private List<int> m = new List<int>()
        {
            2, 3, 4, 5, 10, 15
        };

        public event Action herherherherherhe
        {
            add => exitButton.hehreherh += value;
            remove => exitButton.hehreherh += value;
        }
        

        protected override void jrjrtrtnrbererv()
        {
            for (int i = 0; i < buttons.Count; i++)
            {
                var i1 = i;
                buttons[i].nethgwegweg += () =>
                {
                    if (buttons[i1].CG.alpha < 0.99)
                        return;
                    
                    if(costs[i1] > ererhreherhe.gwgwegwegwegwgweg)
                        return;

                    buttons[i1].CG.alpha = 0.5f;
                    ererhreherhe.gwgwegwegwegwgweg -= costs[i1];
                    ererhreherhe.mtytmtmtym = Mathf.Max(ererhreherhe.mtytmtmtym, m[i1]);
                    pointsText.text = $"POINTS: {ererhreherhe.gwgwegwegwegwgweg:00000}P";
                };
            }
        }

        protected override void ewregtrhnht() => pointsText.text = $"POINTS: {ererhreherhe.gwgwegwegwegwgweg:00000}P";
    }
}