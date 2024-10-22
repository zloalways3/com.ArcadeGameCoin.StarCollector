using System;
using System.Collections.Generic;
using System.Threading;
using Cysharp.Threading.Tasks;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using ZeroSDK.UIBuilder.AddOns.Button;
using ZeroSDK.UIBuilder.Core.UIElements;

namespace _project.Scripts
{
    public sealed class ererhreherhe : thygtfrdsd
    {
        [SerializeField] private RectTransform skyshipNavigator;
        [SerializeField] private TextMeshProUGUI cosmicScoreDisplay;
        [SerializeField] private RectTransform aetherCollectiblePrefab;
        [SerializeField] private RectTransform enemyEntityPrefab;
        [SerializeField] private RectTransform celestialPlayspace;
        [SerializeField] private TextMeshProUGUI health;
        [SerializeField] private TextMeshProUGUI levelText;
        [SerializeField] private rewgrehtrn menuButton;
        [SerializeField] private rewgrehtrn nextButton;
        [SerializeField] private TextMeshProUGUI balanceText0;
        [SerializeField] private TextMeshProUGUI balanceText1;
        [SerializeField] private TextMeshProUGUI hpTextWin;
        [SerializeField] private rewgrehtrn retryButton;
        [SerializeField] private rewgrehtrn menu2Button;
        [SerializeField] private rewgrehtrn menu3Button;
        [SerializeField] private kiujyhtgrfedw gameView;
        [SerializeField] private kiujyhtgrfedw winView;
        [SerializeField] private kiujyhtgrfedw loseView;

        private readonly List<RectTransform> hmhhmmftnrtn = new List<RectTransform>();
        private readonly List<RectTransform> herherherhreh = new List<RectTransform>();
        private CancellationTokenSource herherherherh;
        private float herherherhe = 500f;
        private float ewgrehtrn = 100f;
        private int reherherherh;
        private float gerhreherh = 100f;
        private Vector2 nrtnrtnrtnrtn;
        private bool ewrehtrntbg;
        private bool gwgwegwegweg;
        private ewgwegwegewgw egwgwegwegwew;


        public static int gwgwegwegwegwgweg = 0;
        public static int mtytmtmtym = 1;
        public event Action herheh43h34h;
        public event Action hehere34h34;
        public event Action<ewgwegwegewgw> herhehe4h343h34h34;
        public event Action herhrerheh34h3;
        public event Action<ewgwegwegewgw> herhehreheh64j454;

        private void Awake()
        {
            menuButton.hehreherh += () => herheh43h34h?.Invoke();
            menu2Button.hehreherh += () => hehere34h34?.Invoke();
            menu3Button.hehreherh += () => hehere34h34?.Invoke();

            retryButton.hehreherh += () => herhehreheh64j454?.Invoke(egwgwegwegwew);
            nextButton.hehreherh += () => herhrerheh34h3?.Invoke();
            
            gerherherherh();
        }

        private void gerherherherh()
        {
            jrtjrttrnrtnrt();
        }

        private void jrtjrttrnrtnrt()
        {
            var ewegewgweg = celestialPlayspace.gameObject.AddComponent<Image>();
            ewegewgweg.color = new Color(0, 0, 0, 0);

            // Add event handlers for touch/mouse input
            ewegewgweg.gameObject.AddComponent<UnityEngine.EventSystems.EventTrigger>();
            var gwegwegwegwegwegwegw = ewegewgweg.GetComponent<UnityEngine.EventSystems.EventTrigger>();

            var mnbgrfsegrthng = new UnityEngine.EventSystems.EventTrigger.Entry();
            mnbgrfsegrthng.eventID = UnityEngine.EventSystems.EventTriggerType.Drag;
            mnbgrfsegrthng.callback.AddListener((data) => {
                var eventData = (UnityEngine.EventSystems.PointerEventData)data;
                ethrynrhtgrfwfwef(eventData);
            });
            gwegwegwegwegwegwegw.triggers.Add(mnbgrfsegrthng);

            var gwrherherhehr = new UnityEngine.EventSystems.EventTrigger.Entry();
            gwrherherhehr.eventID = UnityEngine.EventSystems.EventTriggerType.BeginDrag;
            gwrherherhehr.callback.AddListener((data) => {
                ewrehtrntbg = true;
                var eventData = (UnityEngine.EventSystems.PointerEventData)data;
                nrtnrtnrtnrtn = eventData.position;
            });
            gwegwegwegwegwegwegw.triggers.Add(gwrherherhehr);

            var reherherhehreh = new UnityEngine.EventSystems.EventTrigger.Entry();
            reherherhehreh.eventID = UnityEngine.EventSystems.EventTriggerType.EndDrag;
            reherherhehreh.callback.AddListener((data) => {
                ewrehtrntbg = false;
            });
            gwegwegwegwegwegwegw.triggers.Add(reherherhehreh);
        }

        private void ethrynrhtgrfwfwef(UnityEngine.EventSystems.PointerEventData eventData)
        {
            if (!ewrehtrntbg) return;

            float egwegwgw = eventData.position.x - nrtnrtnrtnrtn.x;
            var gwgwegwegwegw = skyshipNavigator.anchoredPosition;
            gwgwegwegwegw.x += egwegwgw * Time.deltaTime * ewgrehtrn;
            gwgwegwegwegw.x = Mathf.Clamp(gwgwegwegwegw.x, -celestialPlayspace.rect.width / 2 + 40, celestialPlayspace.rect.width / 2 - 40);
            skyshipNavigator.anchoredPosition = gwgwegwegwegw;

            // Tilt based on movement direction
            float gwrgwgwgwegweg = Mathf.Clamp(egwegwgw * 0.1f, -15f, 15f);
            skyshipNavigator.rotation = Quaternion.Lerp(
                skyshipNavigator.rotation,
                Quaternion.Euler(0, 0, -gwrgwgwgwegweg),
                Time.deltaTime * 10f
            );

            nrtnrtnrtnrtn = eventData.position;
        }

        public void StopGame()
        {
            ConcludeCelestialVoyage();
        }

        public async UniTaskVoid grgwgwegwgwge(ewgwegwegewgw lvlgwegwegweg)
        {
            egwgwegwegwew = lvlgwegwegweg;
            herherherherh?.Cancel();
            herherherherh = new CancellationTokenSource();

            gameView.erhreherh();
            winView.ewegwegwegewg();
            loseView.ewegwegwegewg();
            
            reherherherh = 0;
            gerhreherh = 100f;
            ewegewgewgweg();
            rjrtjrtjrtjrt();
            
            // Update level display
            levelText.text = $"LEVEL {egwgwegwegwew.Id}";

            float spawnElapsed = 0;
            float enemySpawnElapsed = 0;
            float spawnInterval = 2f;
            float enemySpawnInterval = 3f;

            while (!herherherherh.Token.IsCancellationRequested)
            {
                await UniTask.Yield();
                spawnElapsed += Time.deltaTime;
                enemySpawnElapsed += Time.deltaTime;

                if (reherherherh >= egwgwegwegwew.TargetScore)
                {
                    herhehe4h343h34h34?.Invoke(egwgwegwegwew);
                    ConcludeCelestialVoyage();
                    gameView.ewegwegwegewg();
                    winView.erhreherh();
                    gwgwegwegwegwgweg += reherherherh;
                    return;
                }

                if (gerhreherh <= 0)
                {
                    ConcludeCelestialVoyage();
                    gameView.ewegwegwegewg();
                    loseView.erhreherh();
                    gwgwegwegwegwgweg += reherherherh;
                    return;
                }

                if (spawnElapsed >= spawnInterval)
                {
                    spawnElapsed = 0;
                    nteerherherherh();
                }

                if (enemySpawnElapsed >= enemySpawnInterval)
                {
                    enemySpawnElapsed = 0;
                    SpawnEnemyEntity();
                }
            }
        }

        private void nteerherherherh()
        {
            var celestialPosition = new Vector2(
                UnityEngine.Random.Range(-celestialPlayspace.rect.width / 2 + 75, celestialPlayspace.rect.width / 2 - 75),
                celestialPlayspace.rect.height + 10f
            );

            var aetherialForm = Instantiate(aetherCollectiblePrefab, celestialPlayspace);
            aetherialForm.anchoredPosition = celestialPosition;
            hmhhmmftnrtn.Add(aetherialForm);
        }

        private void SpawnEnemyEntity()
        {
            var position = new Vector2(
                UnityEngine.Random.Range(-celestialPlayspace.rect.width / 2 + 75, celestialPlayspace.rect.width / 2 - 75),
                celestialPlayspace.rect.height + 10f
            );

            var enemy = Instantiate(enemyEntityPrefab, celestialPlayspace);
            enemy.anchoredPosition = position;
            herherherhreh.Add(enemy);
        }

        private void Update()
        {
            HandleInput();
            OrchestrateCelestialCollisions();
            PropagateEntities();
        }

        private void HandleInput()
        {
            if (Input.GetMouseButtonDown(0))
            {
                gwgwegwegweg = true;
                nrtnrtnrtnrtn = Input.mousePosition;
            }
            else if (Input.GetMouseButtonUp(0))
            {
                gwgwegwegweg = false;
            }

            if (gwgwegwegweg)
            {
                Vector2 currentTouchPosition = Input.mousePosition;
                float deltaX = currentTouchPosition.x - nrtnrtnrtnrtn.x;
                
                var currentPosition = skyshipNavigator.anchoredPosition;
                currentPosition.x += deltaX * Time.deltaTime * ewgrehtrn;
                currentPosition.x = Mathf.Clamp(currentPosition.x, -celestialPlayspace.rect.width / 2 + 40, celestialPlayspace.rect.width / 2 - 40);
                skyshipNavigator.anchoredPosition = currentPosition;

                // Наклон корабля на основе направления движения
                float tiltAngle = Mathf.Clamp(deltaX * 0.1f, -15f, 15f);
                skyshipNavigator.rotation = Quaternion.Lerp(
                    skyshipNavigator.rotation,
                    Quaternion.Euler(0, 0, -tiltAngle),
                    Time.deltaTime * 10f
                );

                nrtnrtnrtnrtn = currentTouchPosition;
            }
            else
            {
                // Возвращаем корабль в нормальное положение, когда нет ввода
                skyshipNavigator.rotation = Quaternion.Lerp(
                    skyshipNavigator.rotation,
                    Quaternion.identity,
                    Time.deltaTime * 5f
                );
            }
        }

        private void OrchestrateCelestialCollisions()
        {
            // Check collisions with collectibles
            for (int i = hmhhmmftnrtn.Count - 1; i >= 0; i--)
            {
                if (!hmhhmmftnrtn[i]) continue;

                if (Vector3.Distance(hmhhmmftnrtn[i].transform.position, skyshipNavigator.transform.position) < 1f)
                {
                    Destroy(hmhhmmftnrtn[i].gameObject);
                    hmhhmmftnrtn.RemoveAt(i);
                    reherherherh += 100 * mtytmtmtym;
                    ewegewgewgweg();
                }
            }

            // Check collisions with enemies
            for (int i = herherherhreh.Count - 1; i >= 0; i--)
            {
                if (!herherherhreh[i]) continue;

                if (Vector3.Distance(herherherhreh[i].transform.position, skyshipNavigator.transform.position) < 1f)
                {
                    Destroy(herherherhreh[i].gameObject);
                    herherherhreh.RemoveAt(i);
                    gerhreherh -= 10f;
                    rjrtjrtjrtjrt();
                }
            }
        }

        private void PropagateEntities()
        {
            // Move collectibles
            for (int i = hmhhmmftnrtn.Count - 1; i >= 0; i--)
            {
                if (!hmhhmmftnrtn[i]) continue;

                var position = hmhhmmftnrtn[i].anchoredPosition;
                position.y -= herherherhe * Time.deltaTime;
                hmhhmmftnrtn[i].anchoredPosition = position;

                if (position.y < -celestialPlayspace.rect.height / 2 - 20)
                {
                    Destroy(hmhhmmftnrtn[i].gameObject);
                    hmhhmmftnrtn.RemoveAt(i);
                }
            }

            // Move enemies
            for (int i = herherherhreh.Count - 1; i >= 0; i--)
            {
                if (!herherherhreh[i]) continue;

                var position = herherherhreh[i].anchoredPosition;
                position.y -= herherherhe * Time.deltaTime;
                herherherhreh[i].anchoredPosition = position;

                if (position.y < -celestialPlayspace.rect.height / 2 - 20)
                {
                    Destroy(herherherhreh[i].gameObject);
                    herherherhreh.RemoveAt(i);
                }
            }
        }

        private void ewegewgewgweg()
        {
            cosmicScoreDisplay.text = $"{reherherherh}/{egwgwegwegwew.TargetScore}";
            balanceText0.text = $"EARN {reherherherh}P";
            balanceText1.text = $"EARN {reherherherh}P";
        }

        private void rjrtjrtjrtjrt()
        {  
            health.text = $"{(int) gerhreherh}HP";
            hpTextWin.text = $"{(int) gerhreherh}HP";
        }

        private void ConcludeCelestialVoyage()
        {
            herherherherh?.Cancel();
            
            foreach (var aether in hmhhmmftnrtn)
            {
                if (aether) Destroy(aether.gameObject);
            }
            hmhhmmftnrtn.Clear();

            foreach (var enemy in herherherhreh)
            {
                if (enemy) Destroy(enemy.gameObject);
            }
            herherherhreh.Clear();
        }

        private void OnDestroy()
        {
            herherherherh?.Cancel();
        }
    }
}