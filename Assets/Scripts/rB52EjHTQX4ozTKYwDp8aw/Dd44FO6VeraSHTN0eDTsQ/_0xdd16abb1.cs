using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Canvas))]
public class _0xdd16abb1 : MonoBehaviour
{
    private static void OrientationChanged()
    {
        _0xb95be4d6 = Screen.orientation;
        _0xb84d6b6f.x = Screen.width;
        _0xb84d6b6f.y = Screen.height;
        _0x882017c4.Invoke();
    }

    private void OnDestroy()
    {
        if (_0xc6d32fb4 != null && _0xc6d32fb4.Contains(this))
            _0xc6d32fb4.Remove(this);
    }

    private RectTransform _0xca13490e;
    private void Update()
    {
        if (_0xc6d32fb4[0] != this)
            return;
        if (Application.isMobilePlatform && Screen.orientation != _0xb95be4d6)
            OrientationChanged();
        if (Screen.safeArea != _0xd40ffaa2)
            SafeAreaChanged();
        if (Screen.width != _0xb84d6b6f.x || Screen.height != _0xb84d6b6f.y)
            ResolutionChanged();
    }

    private RectTransform _0x35f2c788;
    private void _0x9c0fab7e()
    {
        if (this._0x35f2c788 == null)
            return;
        Rect _0x718482b4 = Screen.safeArea;
        Vector2 _0x9ccdca76 = _0x718482b4.position;
        Vector2 _0x455c77b7 = _0x718482b4.position + _0x718482b4.size;
        _0x9ccdca76.x /= this._0xfc830174.pixelRect.width;
        _0x9ccdca76.y /= this._0xfc830174.pixelRect.height;
        _0x455c77b7.x /= this._0xfc830174.pixelRect.width;
        _0x455c77b7.y /= this._0xfc830174.pixelRect.height;
        this._0x35f2c788.anchorMin = _0x9ccdca76;
        this._0x35f2c788.anchorMax = _0x455c77b7;
    }

    private static ScreenOrientation _0xb95be4d6 = ScreenOrientation.LandscapeLeft;
    private void Awake()
    {
        if (!_0xc6d32fb4.Contains(this))
            _0xc6d32fb4.Add(this);
        this._0xfc830174 = this.GetComponent<Canvas>();
        this._0xca13490e = this.GetComponent<RectTransform>();
        this._0x35f2c788 = this.transform.Find(_0x7823e09c._0xabc33e32(new byte[8] { 71, 117, 114, 113, 85, 102, 113, 117 }, 20)) as RectTransform;
        if (!_0x93f4f14d)
        {
            _0xb95be4d6 = Screen.orientation;
            _0xb84d6b6f.x = Screen.width;
            _0xb84d6b6f.y = Screen.height;
            _0xd40ffaa2 = Screen.safeArea;
            _0x93f4f14d = true;
        }

        this._0x9c0fab7e();
    }

    private static Rect _0xd40ffaa2 = Rect.zero;
    private static void ResolutionChanged()
    {
        _0xb84d6b6f.x = Screen.width;
        _0xb84d6b6f.y = Screen.height;
        _0x882017c4.Invoke();
    }

    private static UnityEvent _0x882017c4 = new();
    private static void SafeAreaChanged()
    {
        _0xd40ffaa2 = Screen.safeArea;
        for (int _0x63f84242 = 0; _0x63f84242 < _0xc6d32fb4.Count; _0x63f84242++)
            _0xc6d32fb4[_0x63f84242]._0x9c0fab7e();
    }

    private Canvas _0xfc830174;
    private static Vector2 _0xb84d6b6f = Vector2.zero;
    private static bool _0x93f4f14d;
    private static readonly List<_0xdd16abb1> _0xc6d32fb4 = new();
}

internal static class _0x7823e09c
{
    internal static string _0xabc33e32(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}