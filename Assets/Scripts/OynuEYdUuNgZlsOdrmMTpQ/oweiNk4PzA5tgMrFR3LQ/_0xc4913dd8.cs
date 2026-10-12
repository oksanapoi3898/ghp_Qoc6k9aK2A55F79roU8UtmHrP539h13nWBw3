using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static _0xd21d76d7;

public class _0xc4913dd8 : MonoBehaviour
{
    [HideInInspector]
    public GameObject RootGameObject; // tag - "Root"
    public int _0x5870edf8 => SceneManager.GetActiveScene().buildIndex;
    private static _0xc6c47b7b _0x599ae66b => _0xc6c47b7b.ALL_SCENES_SETTING_SINGLETONS[0];

    private static void MakeGrid(List<RectTransform> _0xa77fd60d, AspectRatioFitter _0xe63d74e6, float _0xd689df38, int _0xdf52ae11, int _0x07917220)
    {
        _0xe63d74e6.aspectMode = AspectRatioFitter.AspectMode.WidthControlsHeight;
        _0xe63d74e6.aspectRatio = _0xd689df38;
        foreach (RectTransform _0x62f39cf6 in _0xa77fd60d)
        {
            int _0x093e2354 = _0x62f39cf6.transform.GetSiblingIndex();
            _0x62f39cf6.anchorMin = new Vector3(Mathf.FloorToInt((float)_0x093e2354 % _0xdf52ae11) * (1f / _0xdf52ae11), (_0x07917220 - (Mathf.FloorToInt((float)_0x093e2354 / _0xdf52ae11) % _0x07917220 + 1f)) * (1f / _0x07917220));
            _0x62f39cf6.anchorMax = new Vector3(Mathf.FloorToInt((float)_0x093e2354 % _0xdf52ae11 + 1f) * (1f / _0xdf52ae11), (_0x07917220 - Mathf.FloorToInt((float)_0x093e2354 / _0xdf52ae11) % _0x07917220) * (1f / _0x07917220));
            _0x62f39cf6.offsetMin = Vector2.zero;
            _0x62f39cf6.offsetMax = Vector2.zero;
        }
    }

    public static _0xc4913dd8 Instance;
    public Transform EnvironmentWithTweensToToggle;
    public void LoadSceneByIndex(int _0x4210febb)
    {
        //if (SceneManager.GetActiveScene().buildIndex == sceneIndex)
        //    AdsInitializer.Instance?.ShowAd();
        this.StartCoroutine(this._0xbdd2d542(_0x4210febb));
    }

    public static _0xc6c47b7b _0x8519e350 => _0xc6c47b7b.ALL_SCENES_SETTING_SINGLETONS[Instance._0x5870edf8];

    public void _0x42aee5a6()
    {
        this.LoadSceneByIndex(SceneManager.GetActiveScene().buildIndex);
    }

    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0xc4913dd8>();
        this.RootGameObject = GameObject.FindWithTag(_0x06831400._0xe026ff33(new byte[4] { 29, 32, 32, 59 }, 79));
        if (this._0x5870edf8 == _0x550bdfca.SCENE_0)
            this._0xb5e7cd29(true);
        else
            this._0xb5e7cd29(false);
        this.MoneyCountContainers = this.RootGameObject.GetComponentsInChildren<_0x7f613695>(true).ToList();
    }

    public Button ShowResetTutorialButton;
    private void _0x8979d577()
    {
        IsAfterLevelComplete = true;
        Instance.LoadSceneByIndex(_0x550bdfca.SCENE_0);
    }

    public void _0x0aa59b50()
    {
        _0x8519e350._0xa535c4cb = true;
    }

    public Transform Environment;
    private void _0xd4a1fbb4(Transform _0xcf11c3ab)
    {
        Transform[] _0xa53b8a97 = _0xcf11c3ab.GetComponentsInChildren<Transform>();
        foreach (Transform _0xb9cba349 in _0xa53b8a97)
            if (_0xb9cba349 != null && DOTween.IsTweening(_0xb9cba349))
            {
                if (this._0xc7a506c8)
                    DOTween.Play(_0xb9cba349);
                else
                    DOTween.Pause(_0xb9cba349);
            }
    }

    private void Start()
    {
        if (this._0x5870edf8 != _0x550bdfca.SCENE_0)
            Screen.orientation = ScreenOrientation.Portrait;
        this.DeleteProgressDataButton?.onClick.AddListener(() =>
        {
            PlayerPrefs.DeleteAll();
            //AudioController.Instance.UpdateMusics();
            //AudioController.Instance.UpdateSfxes();
            Instance.LoadSceneByIndex(_0x550bdfca.SCENE_0);
        });
        this.ShowResetTutorialButton?.onClick.AddListener(() =>
        {
            _0x8519e350._0xa535c4cb = false;
            _0x87a6397f.Instance._0x3b04cfaa();
            _0x3fe52430.Instance._0xe43ad4df(_0xc4101fb1.TUTORIAL0);
        });
    }

    public static bool IsAfterLevelFailed = false;
    private void _0x080dbeaa(bool _0x42466a75)
    {
        Rigidbody2D[] _0x1b5282ed = this.RootGameObject.GetComponentsInChildren<Rigidbody2D>(true);
        foreach (Rigidbody2D _0x4c009942 in _0x1b5282ed)
            if (_0x42466a75)
                _0x4c009942.constraints = RigidbodyConstraints2D.FreezeAll;
            else
                _0x4c009942.constraints = RigidbodyConstraints2D.None;
    }

    private IEnumerator _0x4c3874b5(string _0x8cbda325)
    {
        _0x3fe52430.Instance._0xe43ad4df(_0xc4101fb1.SPLASH);
        //AudioController.Instance.SaveLastMusicTimes();
        AsyncOperation _0xb87fb791 = SceneManager.LoadSceneAsync(_0x8cbda325);
        while (!_0xb87fb791.isDone)
            yield return null;
    }

    public static bool IsAfterLevelComplete;
    [HideInInspector]
    public List<_0x7f613695> MoneyCountContainers = new();
    private static void ExitGame()
    {
        Application.Quit();
    }

    public void _0xb5e7cd29(bool _0xf1e5e13c)
    {
        this._0xc7a506c8 = _0xf1e5e13c;
        this._0x080dbeaa(!this._0xc7a506c8);
        Physics2D.simulationMode = this._0xc7a506c8 ? SimulationMode2D.FixedUpdate : SimulationMode2D.Script;
        if (this.EnvironmentWithTweensToToggle != null)
            this._0xd4a1fbb4(this.EnvironmentWithTweensToToggle);
    }

    public bool _0xc7a506c8 { get; private set; }

    public Canvas MainCanvas;
    private IEnumerator _0xbdd2d542(int _0x1c3bbb89)
    {
        _0x3fe52430.Instance._0xe43ad4df(_0xc4101fb1.SPLASH);
        AsyncOperation _0x152cb6b2 = SceneManager.LoadSceneAsync(_0x1c3bbb89);
        while (!_0x152cb6b2.isDone)
            yield return null;
    }

    public void _0xcc72031c()
    {
        foreach (_0x7f613695 _0x1367a139 in this.MoneyCountContainers)
            _0x1367a139._0x2ce7c99e();
    }

    public Button DeleteProgressDataButton;
    private static _0xc6c47b7b GAME_INDEX_SETTINGS(int _0xb0488ca8)
    {
        return _0xc6c47b7b.ALL_SCENES_SETTING_SINGLETONS[_0xb0488ca8];
    }
}

internal static class _0x06831400
{
    internal static string _0xe026ff33(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}