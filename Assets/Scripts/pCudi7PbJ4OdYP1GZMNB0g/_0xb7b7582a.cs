using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;

/// One trip to the royal table. The chute releases a fruit on the schedule the
/// generator proved, the player turns the platter to put the matching bowl under
/// it, and the four orders fill up.
///
/// Length is arithmetic, not hope: the schedule places the fifth let-through fruit
/// past seventy-two seconds, and the clock itself runs ninety-five to a hundred and
/// ten, so a player who never touches the screen is still playing well past the
/// sixty second floor a review capture needs (rule C.5). Both result cards and the
/// pause card release themselves after a few seconds, so no capture can ever park
/// on a card.
public sealed class _0xb7b7582a : MonoBehaviour
{
    private void OnDestroy()
    {
        if (this._0x560d9234 != null)
        {
            this._0x560d9234.Kill();
        }

        if (this._0x88b4b5ec != null)
        {
            this._0x88b4b5ec.Kill();
        }
    }

    [SerializeField]
    private Sprite _pauseIcon;
    private int _0x95225912;
    private void Start()
    {
        _0x45ccd1e4.BlankUnusedPages();
        int _0x71d3add7 = this._0x1f08c58c._0x7fbf72ca;
        int _0x9814beed = this._0x1f08c58c._0x2b1da208();
        this._0xf65c292b = this._0x61c7f1ca._0xa33b9e6a(_0x71d3add7, _0x9814beed);
        Transform _0x3ff0059a = _0x45ccd1e4.PanelBody(_0xd21d76d7._0xc4101fb1.DEFAULT);
        if (_0x3ff0059a == null)
        {
            return;
        }

        _0x45ccd1e4.ClearPanelBody(_0xd21d76d7._0xc4101fb1.DEFAULT);
        if (this._ring != null)
        {
            this._ring._0xd87126eb(this._0xf65c292b.ColourAtRing, this._0xf65c292b.StartCatchIndex);
        }

        this._0x2ea4bc94 = new int[_0x8b743421.CourtColours];
        this._0xf37653ba = _0x8b743421.Order(_0x71d3add7).ClockSeconds;
        this._0xda8563be = Mathf.CeilToInt(this._0xf37653ba);
        if (this._hud != null)
        {
            this._hud._0xc52700ee(_0x3ff0059a, this._font, this._plateSprite, this._gaugeFillSprite, this._tickSprite, this._backIcon, this._pauseIcon, this._arrowLeft, this._arrowRight, this._spillSprite, this._0xf65c292b.TargetByColour);
            this._hud._0x65684da9(this._0xf37653ba);
            this._hud._0x159005c9(0);
            this._hud._0xf0bbb856(0);
            for (int _0x0cc87f14 = 0; _0x0cc87f14 < _0x8b743421.CourtColours; _0x0cc87f14++)
            {
                this._hud._0x9557dc85(_0x0cc87f14, 0, this._0xf65c292b.TargetByColour[_0x0cc87f14]);
            }

            if (this._hud._0x83934d6f != null)
            {
                this._hud._0x83934d6f._0x8279fe50(_0x2112d68e => this._0x38b2c086(_0x2112d68e));
            }

            if (this._hud._0xc34d022c != null)
            {
                this._hud._0xc34d022c.onClick.AddListener(() => this._0x38b2c086(-1));
            }

            if (this._hud._0xb709b019 != null)
            {
                this._hud._0xb709b019.onClick.AddListener(() => this._0x38b2c086(1));
            }

            if (this._hud._0x3c3416fe != null)
            {
                this._hud._0x3c3416fe.onClick.AddListener(() => this._0x30b88876());
            }

            if (this._hud._0x939ed87a != null)
            {
                this._hud._0x939ed87a.onClick.AddListener(() => this._0xdb09d5d9());
            }
        }

        if (this._pops != null)
        {
            this._pops._0x9c75a458();
            if (this._pops._0x14c26d9d != null)
            {
                this._pops._0x14c26d9d.onClick.AddListener(() => this._0x044417e8());
            }

            if (this._pops._0x65fe8263 != null)
            {
                this._pops._0x65fe8263.onClick.AddListener(() => this._0x044417e8());
            }

            if (this._pops._0xc2f9b9ba != null)
            {
                this._pops._0xc2f9b9ba.onClick.AddListener(() => this._0x30b88876());
            }

            if (this._pops._0x3b2a3b0a != null)
            {
                this._pops._0x3b2a3b0a.onClick.AddListener(() => this._0xd1e2e6ad());
            }

            if (this._pops._0x2ed405f4 != null)
            {
                this._pops._0x2ed405f4.onClick.AddListener(() => this._0x30b88876());
            }

            if (this._pops._0xfb648f99 != null)
            {
                this._pops._0xfb648f99.onClick.AddListener(() => this._0x30b88876());
            }

            if (this._pops._0x53a18113 != null)
            {
                this._pops._0x53a18113.onClick.AddListener(() => this._0x81531ba8());
            }

            if (this._pops._0xdc777523 != null)
            {
                this._pops._0xdc777523.onClick.AddListener(() => this._0x30b88876());
            }

            if (this._pops._0xbe7c4140 != null)
            {
                this._pops._0xbe7c4140.onClick.AddListener(() => this._0x30b88876());
            }
        }

        this._0x4b10947c = true;
        {
#if B_LOGS
            {
                Debug.Log(_0xb129b16f._0x021308dd(new byte[13] { 187, 146, 143, 149, 142, 132, 189, 192, 147, 133, 133, 132, 221 }, 224) + this._0xf65c292b.Seed + _0xb129b16f._0x021308dd(new byte[7] { 104, 39, 58, 44, 45, 58, 117 }, 72) + _0x71d3add7 + _0xb129b16f._0x021308dd(new byte[9] { 57, 120, 109, 109, 124, 116, 105, 109, 36 }, 25) + _0x9814beed + _0xb129b16f._0x021308dd(new byte[10] { 154, 220, 219, 214, 214, 216, 219, 217, 209, 135 }, 186) + this._0xf65c292b.IsFallback + _0xb129b16f._0x021308dd(new byte[12] { 217, 137, 152, 138, 138, 144, 143, 156, 188, 151, 157, 196 }, 249) + this._0xf65c292b.PassiveEndSeconds + _0xb129b16f._0x021308dd(new byte[11] { 44, 107, 126, 105, 105, 104, 117, 91, 101, 98, 49 }, 12) + this._0xf65c292b.GreedyWinSeconds);
            }
#endif
        }
    }

    [SerializeField]
    private TMP_FontAsset _font;
    private readonly _0x5791162a _0x1f08c58c = new _0x5791162a();
    [SerializeField]
    private Sprite _arrowLeft;
    private int _0xda8563be;
    private const float ResultHoldSeconds = 9f;
    private int _0x7ff84eba;
    private void _0x58b86e1d(_0x34e71ace _0xa6bac6e7, int _0xe2259972)
    {
        _0xa6bac6e7._0x37a3296e();
        if (this._ring != null)
        {
            this._ring._0x96bc720d();
        }

        this._0x95225912++;
        if (this._0x95225912 > this._0x7ff84eba)
        {
            this._0x7ff84eba = this._0x95225912;
        }

        int _0x62658bee = this._0xf65c292b.TargetByColour[_0xe2259972];
        if (this._0x2ea4bc94[_0xe2259972] < _0x62658bee)
        {
            this._0x2ea4bc94[_0xe2259972]++;
            if (this._0x2ea4bc94[_0xe2259972] >= _0x62658bee)
            {
                this._0x17c5ca25++;
            }

            if (this._hud != null)
            {
                this._hud._0x9557dc85(_0xe2259972, this._0x2ea4bc94[_0xe2259972], _0x62658bee);
            }
        }

        if (this._hud != null)
        {
            this._hud._0xf0bbb856(this._0x95225912);
        }

        if (this._0x95225912 % _0x8b743421.PardonStreak == 0 && this._0xe6c9ad05 > 0)
        {
            this._0xe6c9ad05--;
            if (this._hud != null)
            {
                this._hud._0x159005c9(this._0xe6c9ad05);
                this._hud._0x604f8ffa(_0xb129b16f._0x021308dd(new byte[12] { 120, 101, 115, 107, 102, 10, 122, 107, 120, 110, 101, 100 }, 42));
            }
        }
        else if (this._0x95225912 % _0x8b743421.FavourStreak == 0)
        {
            this._0xf37653ba += _0x8b743421.FavourSeconds;
            if (this._hud != null)
            {
                this._hud._0x65684da9(this._0xf37653ba);
                this._hud._0x604f8ffa(_0xb129b16f._0x021308dd(new byte[16] { 65, 92, 74, 82, 95, 51, 85, 82, 69, 92, 70, 65, 51, 56, 39, 64 }, 19));
            }
        }

        if (this._0x17c5ca25 >= _0x8b743421.CourtColours)
        {
            this._0x811453c7(true, false);
        }
    }

    private int[] _0x2ea4bc94;
    private _0xf49241c8 _0xf65c292b;
    [SerializeField]
    private Sprite _tickSprite;
    private float _0xf37653ba;
    [SerializeField]
    private Sprite _plateSprite;
    private void _0xd1e2e6ad()
    {
        this._0x1f08c58c._0x7fbf72ca = this._0x1f08c58c._0x7fbf72ca + 1;
        this._0x81531ba8();
    }

    private void _0x30b88876()
    {
        _0xc4913dd8 _0x55f0465f = _0xc4913dd8.Instance;
        if (_0x55f0465f != null)
        {
            _0x55f0465f._0xb5e7cd29(true);
            _0x55f0465f.LoadSceneByIndex(_0xd21d76d7._0x550bdfca.SCENE_0);
        }
    }

    private void _0x29be8ffe(bool _0x094179b7)
    {
        for (int _0xaa8c85d0 = 0; _0xaa8c85d0 < this._0xe1d64a11.Count; _0xaa8c85d0++)
        {
            if (this._0xe1d64a11[_0xaa8c85d0] != null)
            {
                this._0xe1d64a11[_0xaa8c85d0]._0x7cb252e9(_0x094179b7);
            }
        }
    }

    private readonly List<_0x34e71ace> _0xe1d64a11 = new List<_0x34e71ace>();
    private Tween _0x88b4b5ec;
    private void _0x81531ba8()
    {
        _0xc4913dd8 _0xe1450d5a = _0xc4913dd8.Instance;
        if (_0xe1450d5a != null)
        {
            _0xe1450d5a._0xb5e7cd29(true);
            _0xe1450d5a.LoadSceneByIndex(_0xd21d76d7._0x550bdfca.SCENE_1);
        }
    }

    private void _0xdb09d5d9()
    {
        if (!this._0x4b10947c || this._0x0ed5b55d || this._0xebbf35fa)
        {
            return;
        }

        this._0x0ed5b55d = true;
        this._0x29be8ffe(true);
        _0xc4913dd8 _0x5dee5214 = _0xc4913dd8.Instance;
        if (_0x5dee5214 != null)
        {
            _0x5dee5214._0xb5e7cd29(false);
        }

        if (this._pops != null)
        {
            this._pops.FillPause(this._0x17c5ca25, _0x8b743421.CourtColours, Mathf.Max(0, Mathf.CeilToInt(this._0xf37653ba)));
            this._pops._0x72ce4ffe();
        }

        if (this._0x560d9234 != null)
        {
            this._0x560d9234.Kill();
        }

        this._0x560d9234 = DOVirtual.DelayedCall(PauseHoldSeconds, () => this._0x044417e8());
    }

    private void _0x044417e8()
    {
        if (!this._0x0ed5b55d)
        {
            return;
        }

        if (this._0x560d9234 != null)
        {
            this._0x560d9234.Kill();
            this._0x560d9234 = null;
        }

        this._0x0ed5b55d = false;
        this._0x29be8ffe(false);
        if (this._pops != null)
        {
            this._pops._0x2918c325();
        }

        _0xc4913dd8 _0xd5dc97b6 = _0xc4913dd8.Instance;
        if (_0xd5dc97b6 != null)
        {
            _0xd5dc97b6._0xb5e7cd29(true);
        }
    }

    [SerializeField]
    private _0x86d0f016 _ring;
    private void _0x38b2c086(int _0x95d4ffe9)
    {
        if (!this._0x4b10947c || this._0x0ed5b55d || this._0xebbf35fa || this._ring == null)
        {
            return;
        }

        this._ring._0x01bd23df(_0x95d4ffe9);
    }

    private bool _0xebbf35fa;
    private int _0x17c5ca25;
    [SerializeField]
    private Sprite _backIcon;
    private const float PauseHoldSeconds = 7f;
    private float _0x6f4f4082;
    private void _0x656f59d0(_0x34e71ace _0x9845d075)
    {
        if (_0x9845d075 == null)
        {
            return;
        }

        this._0xe1d64a11.Remove(_0x9845d075);
        if (this._0xebbf35fa)
        {
            _0x9845d075._0x07301e04();
            return;
        }

        int _0xb0c2c26e = this._0xf65c292b._0x9c5ac2ed(this._ring._0x6fbf2bcd);
        if (_0x9845d075._0xc7f24287 == _0xb0c2c26e)
        {
            this._0x58b86e1d(_0x9845d075, _0xb0c2c26e);
        }
        else
        {
            this._0x83468036(_0x9845d075);
        }
    }

    private int _0xe6c9ad05;
    private void Update()
    {
        if (!this._0x4b10947c || this._0x0ed5b55d || this._0xf65c292b == null)
        {
            return;
        }

        float step = Time.deltaTime;
        this._0x6f4f4082 += step;
        this._0xf37653ba -= step;
        int _0x37df3b3b = Mathf.Max(0, Mathf.CeilToInt(this._0xf37653ba));
        if (_0x37df3b3b != this._0xda8563be)
        {
            this._0xda8563be = _0x37df3b3b;
            if (this._hud != null)
            {
                this._hud._0x65684da9(this._0xf37653ba);
                if (_0x37df3b3b <= 10)
                {
                    this._hud._0x929f4021();
                }
            }
        }

        while (this._0x14d686fd < this._0xf65c292b._0xce908f6b && this._0x6f4f4082 >= this._0xf65c292b.ReleaseAt[this._0x14d686fd])
        {
            this._0x2de7c0a4(this._0x14d686fd);
            this._0x14d686fd++;
        }

        if (this._0xf37653ba <= 0f)
        {
            this._0x811453c7(false, true);
        }
    }

    private int _0x14d686fd;
    /// Releases one scheduled fruit. A gift carries whatever colour is under the
    /// chute at this instant, so the player decides what the kitchen sends by
    /// parking the bowl they still need; an awkward fruit deliberately carries
    /// something else, and the platter has to be turned for it.
    private void _0x2de7c0a4(int _0x17b355a7)
    {
        if (this._ring == null || !this._ring._0xcaf59ef7)
        {
            return;
        }

        _0x690d41a8 _0x0b1a00d3 = this._0xf65c292b.Steps[_0x17b355a7];
        int _0x4ed9aba0 = this._0xf65c292b._0x9c5ac2ed(this._ring._0x6fbf2bcd);
        int _0x70aa2ab3 = _0x0b1a00d3.IsGift ? _0x4ed9aba0 : _0x1c98712e.ResolveChallenge(_0x0b1a00d3.PreferredColour, _0x4ed9aba0, this._0x2ea4bc94, this._0xf65c292b.TargetByColour);
        SpriteRenderer _0xf4c858c8 = this._ring._0xcc9bb3ae(_0x70aa2ab3);
        if (_0xf4c858c8 == null)
        {
            return;
        }

        _0x34e71ace _0x7191435b = _0xf4c858c8.gameObject.AddComponent<_0x34e71ace>();
        this._0xe1d64a11.Add(_0x7191435b);
        _0x7191435b._0xc04dd02a(_0x70aa2ab3, this._ring._0x81f81a73, this._ring._0xae220722, _0x8b743421.FallSeconds(this._0xf65c292b.OrderIndex), _0x94e8ba3f => this._0x656f59d0(_0x94e8ba3f));
    }

    [SerializeField]
    private _0x6ec8a977 _hud;
    private readonly _0x1c98712e _0x61c7f1ca = new _0x1c98712e();
    [SerializeField]
    private Sprite _arrowRight;
    private const float RejectSideways = 1.1f;
    [SerializeField]
    private Sprite _spillSprite;
    [SerializeField]
    private _0x5a871410 _pops;
    private bool _0x0ed5b55d;
    [SerializeField]
    private Sprite _gaugeFillSprite;
    private Tween _0x560d9234;
    private void _0x83468036(_0x34e71ace _0x0f41d73f)
    {
        Vector3 _0xedf3abe5 = _0x0f41d73f.transform.position;
        float _0xb2bd0609 = UnityEngine.Random.value < 0.5f ? -RejectSideways : RejectSideways;
        _0x0f41d73f._0x303341fe(_0xb2bd0609);
        if (this._ring != null)
        {
            this._ring._0x92afcdf7(_0xedf3abe5, _0x8b743421.Tint(_0x0f41d73f._0xc7f24287));
        }

        this._0xe6c9ad05++;
        this._0x95225912 = 0;
        if (this._hud != null)
        {
            this._hud._0xf0bbb856(0);
            this._hud._0x159005c9(this._0xe6c9ad05);
        }

        if (this._0xe6c9ad05 >= _0x8b743421.SpillBudget)
        {
            this._0x811453c7(false, false);
        }
    }

    private void _0x811453c7(bool _0xf950fdf4, bool _0x94805ac6)
    {
        if (this._0xebbf35fa)
        {
            return;
        }

        this._0xebbf35fa = true;
        this._0x4b10947c = false;
        for (int _0xf24f6305 = this._0xe1d64a11.Count - 1; _0xf24f6305 >= 0; _0xf24f6305--)
        {
            if (this._0xe1d64a11[_0xf24f6305] != null)
            {
                this._0xe1d64a11[_0xf24f6305]._0x07301e04();
            }
        }

        this._0xe1d64a11.Clear();
        this._0x1f08c58c._0x69e744a1(this._0x7ff84eba);
        if (this._pops != null)
        {
            if (_0xf950fdf4)
            {
                this._pops.FillWin(this._0x7ff84eba, Mathf.Max(0, Mathf.CeilToInt(this._0xf37653ba)));
                this._pops._0x90826f9a();
            }
            else
            {
                this._pops._0x2a39bb1a(_0x94805ac6, this._0x17c5ca25, _0x8b743421.CourtColours, this._0x7ff84eba);
                this._pops._0x8c484e4b();
            }
        }

        if (this._0x88b4b5ec != null)
        {
            this._0x88b4b5ec.Kill();
        }

        this._0x88b4b5ec = DOVirtual.DelayedCall(ResultHoldSeconds, () => this._0x81531ba8());
    }

    private bool _0x4b10947c;
}

internal static class _0xb129b16f
{
    internal static string _0x021308dd(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}