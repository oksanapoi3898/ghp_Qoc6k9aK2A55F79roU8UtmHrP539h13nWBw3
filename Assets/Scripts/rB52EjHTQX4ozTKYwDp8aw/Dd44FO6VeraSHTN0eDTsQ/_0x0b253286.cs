using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Canvas))]
public class _0x0b253286 : MonoBehaviour
{
    private void Start()
    {
    }

    private static void SafeAreaChanged()
    {
        _0xa9c63e5d = Screen.safeArea;
        ApplySafeAreaToAll();
    }

    private static Vector2 _0xec535201 = Vector2.zero;
    private static UnityEvent _0xb041ef18 = new();
    private static bool _0x8c6b54f3;
    private RectTransform _0x6f657828;
    private CanvasScaler _0xec283ff0;
    private Vector2 _0x56e9bd6c;
    private void OnDestroy()
    {
        if (_0xda71bc37 != null && _0xda71bc37.Contains(this))
            _0xda71bc37.Remove(this);
    }

    private static Rect _0xa9c63e5d = Rect.zero;
    private RectTransform _0x0f4e2da7;
    private static readonly List<_0x0b253286> _0xda71bc37 = new();
    private static ScreenOrientation _0x6905bd8b = ScreenOrientation.LandscapeLeft;
    private static void ResolutionChanged()
    {
        _0xec535201.x = Screen.width;
        _0xec535201.y = Screen.height;
        _0xa9c63e5d = Screen.safeArea;
        ApplySafeAreaToAll();
        _0xb041ef18.Invoke();
    }

    private static void OrientationChanged()
    {
        _0x6905bd8b = Screen.orientation;
        _0xec535201.x = Screen.width;
        _0xec535201.y = Screen.height;
        _0xa9c63e5d = Screen.safeArea;
        ApplySafeAreaToAll();
        _0xb041ef18.Invoke();
    }

    private Canvas _0xf51c5cd3;
    private static void ApplySafeAreaToAll()
    {
        for (int _0xb8973a4b = 0; _0xb8973a4b < _0xda71bc37.Count; _0xb8973a4b++)
            _0xda71bc37[_0xb8973a4b]._0xc66887d9();
    }

    private void Awake()
    {
        if (!_0xda71bc37.Contains(this))
            _0xda71bc37.Add(this);
        this._0xf51c5cd3 = this.GetComponent<Canvas>();
        this._0xec283ff0 = this.GetComponent<CanvasScaler>();
        if (this._0xec283ff0 != null)
            this._0x56e9bd6c = this._0xec283ff0.referenceResolution;
        this._0x6f657828 = this.GetComponent<RectTransform>();
        this._0x0f4e2da7 = this.transform.Find(_0xb3e9478b._0x729cdac0(new byte[8] { 36, 22, 17, 18, 54, 5, 18, 22 }, 119)) as RectTransform;
        if (!_0x8c6b54f3)
        {
            _0x6905bd8b = Screen.orientation;
            _0xec535201.x = Screen.width;
            _0xec535201.y = Screen.height;
            _0xa9c63e5d = Screen.safeArea;
            _0x8c6b54f3 = true;
        }

        this._0xc66887d9();
    }

    private void Update()
    {
        if (_0xda71bc37.Count == 0 || _0xda71bc37[0] != this)
            return;
        if (Application.isMobilePlatform && Screen.orientation != _0x6905bd8b)
            OrientationChanged();
        if (Screen.safeArea != _0xa9c63e5d)
            SafeAreaChanged();
        if (Screen.width != _0xec535201.x || Screen.height != _0xec535201.y)
            ResolutionChanged();
    }

    private void _0xc66887d9()
    {
        if (this._0x0f4e2da7 == null)
            return;
        float screenWidth = Screen.width;
        float screenHeight = Screen.height;
        if (screenWidth <= 0f || screenHeight <= 0f)
            return;
        Rect _0x147a1beb = Screen.safeArea;
        Vector2 _0x79abbc89 = _0x147a1beb.position;
        Vector2 _0xf03a60c6 = _0x147a1beb.position + _0x147a1beb.size;
        _0x79abbc89.x /= screenWidth;
        _0x79abbc89.y /= screenHeight;
        _0xf03a60c6.x /= screenWidth;
        _0xf03a60c6.y /= screenHeight;
        this._0x0f4e2da7.anchorMin = _0x79abbc89;
        this._0x0f4e2da7.anchorMax = _0xf03a60c6;
        this._0x0f4e2da7.offsetMin = Vector2.zero;
        this._0x0f4e2da7.offsetMax = Vector2.zero;
        if (this._0xec283ff0 == null)
            return;
        Vector2 _0x63f24329 = _0xf03a60c6 - _0x79abbc89;
        float _0x5f1d9d1e = 2f - _0x63f24329.x;
        float _0x04104d8e = 2f - _0x63f24329.y;
        this._0xec283ff0.referenceResolution = this._0x56e9bd6c * new Vector2(_0x5f1d9d1e, _0x04104d8e);
    }
}

internal static class _0xb3e9478b
{
    internal static string _0x729cdac0(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}