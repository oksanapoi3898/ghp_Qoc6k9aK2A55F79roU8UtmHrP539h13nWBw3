using DG.Tweening;
using UnityEngine;

/// The board: the chute at the top, the turning platter at the bottom and the four
/// court bowls standing on it. Nothing here is a literal. The camera gives the half
/// height and the aspect, every placement is a fraction of those, and the sprites
/// carry their size in m_Size with their scale left at one, so a 512 px source can
/// never render six units wide (rule C.0).
///
/// Sorting orders are named, and all of them sit inside -19..-1: a Canvas and a
/// SpriteRenderer share one scale, so a positive order would draw the platter over
/// the result cards (rule C.21).
public sealed class _0x86d0f016 : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer _fruitPearPrefab;
    public SpriteRenderer _0x075e025f(int _0x8b8b4f52)
    {
        int _0xe3e3220e = ((_0x8b8b4f52 % _0x8b743421.CourtColours) + _0x8b743421.CourtColours) % _0x8b743421.CourtColours;
        if (_0xe3e3220e == 0)
        {
            return this._fruitPlumPrefab;
        }

        if (_0xe3e3220e == 1)
        {
            return this._fruitPearPrefab;
        }

        if (_0xe3e3220e == 2)
        {
            return this._fruitCherryPrefab;
        }

        return this._fruitLimePrefab;
    }

    private float _0xfa529fc7;
    private float _0x1c84aa99;
    public bool _0xcaf59ef7
    {
        get
        {
            return this._0xa775cfac;
        }
    }

    private const float ChuteHeightFraction = 0.51f;
    private Camera _0x436c4ae2;
    /// World distance a fruit travels from the chute mouth to the catching slot.
    /// The run divides it by the order's fall time, so the DURATION is the same on
    /// every aspect even though the distance is not.
    public float _0x08ae5ba7
    {
        get
        {
            return this._0xda621e97 - this._0xfa529fc7;
        }
    }

    [SerializeField]
    private SpriteRenderer _fruitLimePrefab;
    private float _0xda621e97;
    [SerializeField]
    private SpriteRenderer _chutePrefab;
    private readonly SpriteRenderer[] _0x82231609 = new SpriteRenderer[SplashPool];
    private const float RingCentreFraction = -0.26f;
    [SerializeField]
    private Sprite _bowlPlum;
    public Transform _0xf07245ed(int _0x8fd2d545)
    {
        int _0x6a6c4d70 = ((_0x8fd2d545 % _0x8b743421.CourtColours) + _0x8b743421.CourtColours) % _0x8b743421.CourtColours;
        return this._0x1190ce03[_0x6a6c4d70] != null ? this._0x1190ce03[_0x6a6c4d70].transform : null;
    }

    private void OnDestroy()
    {
        if (this._0x797b6981 != null)
        {
            this._0x797b6981.Kill();
        }
    }

    private readonly SpriteRenderer[] _0x1190ce03 = new SpriteRenderer[_0x8b743421.CourtColours];
    [SerializeField]
    private SpriteRenderer _fruitCherryPrefab;
    private int _0x1352c226;
    public int _0x6fbf2bcd
    {
        get
        {
            return this._0x2e70b784;
        }
    }

    private Transform _0x604ee2e8;
    [SerializeField]
    private Sprite _bowlCherry;
    private bool _0xa775cfac;
    public SpriteRenderer _0xcc9bb3ae(int _0xacae055f)
    {
        SpriteRenderer _0xe78f40e9 = this._0x075e025f(_0xacae055f);
        if (_0xe78f40e9 == null)
        {
            return null;
        }

        SpriteRenderer _0x5285fa07 = Instantiate(_0xe78f40e9, this.transform);
        _0x5285fa07.transform.position = new Vector3(0f, this._0xda621e97, 0f);
        _0x5285fa07.transform.localScale = Vector3.one;
        return _0x5285fa07;
    }

    private Tween _0x797b6981;
    public float _0x81f81a73
    {
        get
        {
            return this._0xda621e97;
        }
    }

    private Sprite _0x63a0ab9c(int _0x88c70217)
    {
        int _0xf1bbf238 = ((_0x88c70217 % _0x8b743421.CourtColours) + _0x8b743421.CourtColours) % _0x8b743421.CourtColours;
        if (_0xf1bbf238 == 0)
        {
            return this._bowlPlum;
        }

        if (_0xf1bbf238 == 1)
        {
            return this._bowlPear;
        }

        if (_0xf1bbf238 == 2)
        {
            return this._bowlCherry;
        }

        return this._bowlLime;
    }

    public Camera _0xb3b5fcbf
    {
        get
        {
            return this._0x436c4ae2;
        }
    }

    public void _0x96bc720d()
    {
        Transform _0xfccf1f0a = this._0xf07245ed(this._0x2e70b784);
        if (_0xfccf1f0a == null)
        {
            return;
        }

        _0xfccf1f0a.DOComplete();
        _0xfccf1f0a.DOPunchScale(Vector3.one * 0.14f, 0.24f, 6, 0.6f);
    }

    [SerializeField]
    private SpriteRenderer _platterPrefab;
    private const float TurnSeconds = 0.22f;
    private const float RingRadiusFraction = 0.285f;
    /// Turns the platter one quarter. The bowls counter-turn by the same amount in
    /// the same time, so every bowl keeps its mouth up while the platter spins.
    public void _0x01bd23df(int _0xa4a2d2c1)
    {
        if (!this._0xa775cfac)
        {
            return;
        }

        this._0x2e70b784 = ((this._0x2e70b784 + _0xa4a2d2c1) % _0x8b743421.CourtColours + _0x8b743421.CourtColours) % _0x8b743421.CourtColours;
        float _0x87f44b35 = this._0x070099cc - (90f * _0xa4a2d2c1);
        if (this._0x797b6981 != null)
        {
            this._0x797b6981.Kill();
        }

        this._0x797b6981 = DOTween.To(() => this._0x070099cc, _0xb0bfeffb => this._0x9af25d8a(_0xb0bfeffb), _0x87f44b35, TurnSeconds).SetEase(Ease.OutBack);
    }

    private const float SpawnHeightFraction = 0.4f;
    [SerializeField]
    private Sprite _bowlLime;
    private float _0x070099cc;
    public void _0x92afcdf7(Vector3 _0x82dd822b, Color _0x31273b1f)
    {
        SpriteRenderer _0x9aeb2fd0 = this._0x82231609[this._0x1352c226];
        this._0x1352c226 = (this._0x1352c226 + 1) % SplashPool;
        if (_0x9aeb2fd0 == null)
        {
            return;
        }

        _0x9aeb2fd0.transform.position = _0x82dd822b;
        _0x9aeb2fd0.transform.localScale = Vector3.one;
        _0x9aeb2fd0.DOKill();
        _0x9aeb2fd0.color = _0xa8c1dd53.WithAlpha(_0x31273b1f, 0.95f);
        _0x9aeb2fd0.transform.DOPunchScale(Vector3.one * 0.3f, SplashSeconds, 5, 0.7f);
        _0x9aeb2fd0.DOFade(0f, SplashSeconds);
    }

    [SerializeField]
    private Sprite _bowlPear;
    public void _0xd87126eb(int[] _0x109b9b9d, int _0x37a58df1)
    {
        if (this._0xa775cfac)
        {
            return;
        }

        this._0xa775cfac = true;
        this._0x436c4ae2 = Camera.main;
        float _0x5831248e = this._0x436c4ae2 != null ? this._0x436c4ae2.orthographicSize : 5f;
        float _0x9f4aa0d8 = _0x5831248e * (this._0x436c4ae2 != null ? this._0x436c4ae2.aspect : 0.4615f);
        this._0x1c84aa99 = 2f * _0x9f4aa0d8 * RingRadiusFraction;
        float _0x1e9d74f7 = _0x5831248e * RingCentreFraction;
        this._0xda621e97 = _0x5831248e * SpawnHeightFraction;
        this._0xfa529fc7 = _0x1e9d74f7 - this._0x1c84aa99;
        if (this._chutePrefab != null)
        {
            SpriteRenderer _0x6a62057a = Instantiate(this._chutePrefab, this.transform);
            _0x6a62057a.transform.position = new Vector3(0f, _0x5831248e * ChuteHeightFraction, 0f);
        }

        GameObject _0x2053c536 = new GameObject(_0x13f20b5b._0x9dcdea10(new byte[7] { 86, 106, 103, 114, 114, 99, 116 }, 6));
        this._0x604ee2e8 = _0x2053c536.transform;
        this._0x604ee2e8.SetParent(this.transform, false);
        this._0x604ee2e8.position = new Vector3(0f, _0x1e9d74f7, 0f);
        if (this._platterPrefab != null)
        {
            SpriteRenderer _0x25c418ec = Instantiate(this._platterPrefab, this._0x604ee2e8);
            _0x25c418ec.transform.localPosition = Vector3.zero;
        }

        for (int _0x2be5db4b = 0; _0x2be5db4b < _0x8b743421.CourtColours; _0x2be5db4b++)
        {
            SpriteRenderer _0x3642707e = Instantiate(this._bowlPrefab, this._0x604ee2e8);
            float _0x14245456 = (_0x2be5db4b * 90f) * Mathf.Deg2Rad;
            _0x3642707e.transform.localPosition = new Vector3(Mathf.Sin(_0x14245456) * this._0x1c84aa99, -Mathf.Cos(_0x14245456) * this._0x1c84aa99, 0f);
            _0x3642707e.transform.localScale = Vector3.one;
            _0x3642707e.sprite = this._0x63a0ab9c(_0x109b9b9d[_0x2be5db4b]);
            this._0x1190ce03[_0x2be5db4b] = _0x3642707e;
        }

        for (int _0x4e5b25f7 = 0; _0x4e5b25f7 < SplashPool; _0x4e5b25f7++)
        {
            SpriteRenderer _0x649f2c50 = Instantiate(this._splashPrefab, this.transform);
            _0x649f2c50.color = _0xa8c1dd53.WithAlpha(Color.white, 0f);
            this._0x82231609[_0x4e5b25f7] = _0x649f2c50;
        }

        this._0x2e70b784 = ((_0x37a58df1 % _0x8b743421.CourtColours) + _0x8b743421.CourtColours) % _0x8b743421.CourtColours;
        this._0x070099cc = -90f * this._0x2e70b784;
        this._0x9af25d8a(this._0x070099cc);
    }

    private const int SplashPool = 4;
    private void _0x9af25d8a(float _0x6c784173)
    {
        this._0x070099cc = _0x6c784173;
        if (this._0x604ee2e8 != null)
        {
            this._0x604ee2e8.localRotation = Quaternion.Euler(0f, 0f, _0x6c784173);
        }

        for (int _0x32daf44e = 0; _0x32daf44e < this._0x1190ce03.Length; _0x32daf44e++)
        {
            if (this._0x1190ce03[_0x32daf44e] != null)
            {
                this._0x1190ce03[_0x32daf44e].transform.localRotation = Quaternion.Euler(0f, 0f, -_0x6c784173);
            }
        }
    }

    [SerializeField]
    private SpriteRenderer _splashPrefab;
    [SerializeField]
    private SpriteRenderer _fruitPlumPrefab;
    public float _0xae220722
    {
        get
        {
            return this._0xfa529fc7;
        }
    }

    private const float SplashSeconds = 0.5f;
    private int _0x2e70b784;
    [SerializeField]
    private SpriteRenderer _bowlPrefab;
}

internal static class _0x13f20b5b
{
    internal static string _0x9dcdea10(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}