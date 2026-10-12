using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// The readout and the controls of a run, built inside the template's own panel
/// body. Everything is placed in the canvas reference resolution (1242 x 2688).
///
/// The two columns of indicators never share an x band with a label: the spill pips
/// stop at x 354 and the series readout starts at x 893, with the fruit lane between
/// them (rule C.25). The tap band that turns the platter is a single surface in the
/// middle of the screen, built FIRST, so every button placed after it wins the
/// raycast over it and no control is ever stolen.
public sealed class _0x6ec8a977 : MonoBehaviour
{
    private Button BuildTurnButton(Transform _0x380ff932, string _0x7aa7d369, float _0xf7aea031, Sprite _0x6f86e3e9, string _0xb0fff174, Sprite _0xdeb8454a, TMP_FontAsset _0xf1d0846c)
    {
        Button _0xd829a7de = _0x1685b31d.Action(_0x380ff932, _0x7aa7d369, new Vector2(_0xf7aea031, TurnRow), Vector2.zero, new Vector2(TurnSide, TurnSide), _0xdeb8454a, _0xa8c1dd53.WithAlpha(_0xa8c1dd53.Surface, 0.96f), string.Empty, _0x838bc0a6.UiFontFloor, _0xa8c1dd53.Cream, null);
        _0x1685b31d.Plate(_0xd829a7de.transform, _0x7aa7d369 + _0x02e2298a._0x3a718410(new byte[5] { 94, 115, 104, 111, 102 }, 1), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(TurnSide - 18f, TurnSide - 18f), _0xdeb8454a, _0xa8c1dd53.WithAlpha(_0xa8c1dd53.Gold, 0.9f));
        _0x1685b31d.Plate(_0xd829a7de.transform, _0x7aa7d369 + _0x02e2298a._0x3a718410(new byte[5] { 5, 60, 59, 57, 63 }, 90), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(TurnSide - 34f, TurnSide - 34f), _0xdeb8454a, _0xa8c1dd53.Surface);
        _0x1685b31d.Picture(_0xd829a7de.transform, _0x7aa7d369 + _0x02e2298a._0x3a718410(new byte[6] { 187, 131, 136, 157, 148, 140 }, 228), new Vector2(0.5f, 0.5f), new Vector2(0f, 24f), new Vector2(108f, 108f), _0x6f86e3e9, _0xa8c1dd53.Gold);
        _0x1685b31d.Caption(_0xd829a7de.transform, _0x7aa7d369 + _0x02e2298a._0x3a718410(new byte[8] { 199, 251, 249, 232, 236, 241, 247, 246 }, 152), new Vector2(0.5f, 0.5f), new Vector2(0f, -72f), new Vector2(TurnSide - 40f, 56f), _0xb0fff174, 32f, _0xa8c1dd53.Cream, TextAlignmentOptions.Center, _0xf1d0846c);
        return _0xd829a7de;
    }

    /// An empty readout is worse than no readout, so the series label only exists
    /// on screen once there is a series to show.
    public void _0xf0bbb856(int _0x6172b895)
    {
        if (this._0xb5bf0ff1 == null)
        {
            return;
        }

        bool _0x59a9b234 = _0x6172b895 > 1;
        _0x1685b31d.SetVisible(this._0xb5bf0ff1, _0x59a9b234);
        if (_0x59a9b234)
        {
            this._0xb5bf0ff1.text = _0x02e2298a._0x3a718410(new byte[8] { 223, 201, 222, 197, 201, 223, 172, 244 }, 140) + _0x6172b895;
            this._0xb5bf0ff1.transform.DOComplete();
            this._0xb5bf0ff1.transform.DOPunchScale(Vector3.one * 0.14f, 0.26f, 5, 0.6f);
        }
    }

    private const float GaugeRow = 0.868f;
    private readonly Image[] _0xbf292606 = new Image[_0x8b743421.CourtColours];
    private const float HintRow = 0.152f;
    private const float GaugePitch = 288f;
    private Button _0x21acb640;
    private readonly Image[] _0xe07fd8a5 = new Image[_0x8b743421.CourtColours];
    public _0x85bace7c _0x83934d6f
    {
        get
        {
            return this._0x04d7cdad;
        }
    }

    public void _0x929f4021()
    {
        if (this._0xbae7dc0b == null)
        {
            return;
        }

        this._0xbae7dc0b.transform.DOComplete();
        this._0xbae7dc0b.transform.DOPunchScale(Vector3.one * 0.12f, 0.3f, 6, 0.6f);
    }

    private const float TurnRow = 0.085f;
    public Button _0x939ed87a
    {
        get
        {
            return this._0x16d7212a;
        }
    }

    private TextMeshProUGUI _0xbae7dc0b;
    private readonly Image[] _0x8053c189 = new Image[PipCount];
    private void _0x378ab845()
    {
        if (this._0xb9c03c43 == null)
        {
            return;
        }

        this._0xb9c03c43.alpha = 1f;
        this._0xb9c03c43.gameObject.SetActive(false);
    }

    private void BuildGauges(Transform _0x7b57e048, TMP_FontAsset _0xaf96f57b, Sprite _0x5816d7a1, Sprite _0x4cb08841, Sprite _0x97b29668, int[] _0x70024972)
    {
        RectTransform _0xb0dcf199 = _0x1685b31d.Node(_0x7b57e048, _0x02e2298a._0x3a718410(new byte[11] { 198, 251, 237, 236, 251, 206, 232, 252, 238, 236, 250 }, 137), new Vector2(0.5f, GaugeRow), Vector2.zero, new Vector2(1180f, 190f));
        for (int _0xaeebfe9b = 0; _0xaeebfe9b < _0x8b743421.CourtColours; _0xaeebfe9b++)
        {
            float _0x52624dc8 = (_0xaeebfe9b - 1.5f) * GaugePitch;
            RectTransform _0xb2971164 = _0x1685b31d.Node(_0xb0dcf199, _0x02e2298a._0x3a718410(new byte[5] { 193, 231, 243, 225, 227 }, 134) + _0xaeebfe9b, new Vector2(0.5f, 0.5f), new Vector2(_0x52624dc8, 0f), new Vector2(272f, 190f));
            this._0xbf292606[_0xaeebfe9b] = _0x1685b31d.Plate(_0xb2971164, _0x02e2298a._0x3a718410(new byte[10] { 254, 216, 204, 222, 220, 255, 203, 216, 212, 220 }, 185), new Vector2(0.5f, 0.5f), new Vector2(0f, 44f), new Vector2(264f, 60f), _0x5816d7a1, _0xa8c1dd53.WithAlpha(_0xa8c1dd53.SurfaceEdge, 0.98f));
            this._0xe07fd8a5[_0xaeebfe9b] = _0x1685b31d.Bar(_0xb2971164, _0x02e2298a._0x3a718410(new byte[9] { 34, 4, 16, 2, 0, 35, 12, 9, 9 }, 101), new Vector2(0.5f, 0.5f), new Vector2(0f, 44f), new Vector2(246f, 42f), _0x4cb08841, _0x8b743421.Tint(_0xaeebfe9b));
            this._0x7f5076d7[_0xaeebfe9b] = _0x1685b31d.Picture(_0xb2971164, _0x02e2298a._0x3a718410(new byte[9] { 52, 18, 6, 20, 22, 39, 26, 16, 24 }, 115), new Vector2(0.5f, 0.5f), new Vector2(96f, 44f), new Vector2(44f, 44f), _0x97b29668, _0xa8c1dd53.Green);
            this._0x7f5076d7[_0xaeebfe9b].gameObject.SetActive(false);
            int _0xf2f132b2 = _0x70024972 != null && _0xaeebfe9b < _0x70024972.Length ? _0x70024972[_0xaeebfe9b] : 0;
            this._0xe7f7b26b[_0xaeebfe9b] = _0x1685b31d.Caption(_0xb2971164, _0x02e2298a._0x3a718410(new byte[10] { 12, 42, 62, 44, 46, 8, 36, 62, 37, 63 }, 75), new Vector2(0.5f, 0.5f), new Vector2(0f, -36f), new Vector2(264f, 64f), _0x02e2298a._0x3a718410(new byte[2] { 189, 162 }, 141) + _0xf2f132b2, 34f, _0x8b743421.Readable(_0xaeebfe9b), TextAlignmentOptions.Center, _0xaf96f57b);
        }
    }

    private const float IconSide = 128f;
    private const int PipCount = _0x8b743421.SpillBudget;
    private readonly TextMeshProUGUI[] _0xe7f7b26b = new TextMeshProUGUI[_0x8b743421.CourtColours];
    private Button _0x0e5f1142;
    private const float TurnSide = 240f;
    public void _0xc52700ee(Transform _0x2fc20ffb, TMP_FontAsset _0x2bafe7d0, Sprite _0x6c38525d, Sprite _0xa6453989, Sprite _0x6fa67501, Sprite _0x7b09813f, Sprite _0x0bbe6f2a, Sprite _0x38134412, Sprite _0xea28712a, Sprite _0x6cb3c6f3, int[] _0xefd284e1)
    {
        if (this._0xb473b284 || _0x2fc20ffb == null)
        {
            return;
        }

        this._0xb473b284 = true;
        RectTransform _0x79e9d66e = _0x1685b31d.Stretch(_0x2fc20ffb, _0x02e2298a._0x3a718410(new byte[6] { 220, 251, 224, 198, 251, 234 }, 142));
        // Built first and therefore under everything else: a tap in the open middle
        // of the screen turns the platter, a tap on a control reaches the control.
        RectTransform _0x38689528 = _0x1685b31d.Node(_0x79e9d66e, _0x02e2298a._0x3a718410(new byte[8] { 234, 203, 204, 208, 252, 223, 208, 218 }, 190), new Vector2(0.5f, 0.52f), Vector2.zero, new Vector2(_0x1685b31d.RefWidth, 1505f));
        Image _0x3b14d886 = _0x38689528.gameObject.AddComponent<Image>();
        _0x3b14d886.color = new Color(0f, 0f, 0f, 0.004f);
        _0x3b14d886.raycastTarget = true;
        _0x3b14d886.canvasRenderer.cullTransparentMesh = false;
        this._0x04d7cdad = _0x38689528.gameObject.AddComponent<_0x85bace7c>();
        _0x1685b31d.Plate(_0x79e9d66e, _0x02e2298a._0x3a718410(new byte[8] { 180, 143, 144, 176, 140, 129, 148, 133 }, 224), new Vector2(0.5f, TopRow), Vector2.zero, new Vector2(1180f, 180f), _0x6c38525d, _0xa8c1dd53.WithAlpha(_0xa8c1dd53.Surface, 0.92f));
        this._0x21acb640 = _0x1685b31d.IconAction(_0x79e9d66e, _0x02e2298a._0x3a718410(new byte[8] { 230, 197, 199, 207, 247, 200, 203, 208 }, 164), new Vector2(0.075f, TopRow), Vector2.zero, IconSide, _0x6c38525d, _0xa8c1dd53.WithAlpha(_0xa8c1dd53.SurfaceEdge, 0.98f), _0x7b09813f, _0xa8c1dd53.Gold);
        this._0x16d7212a = _0x1685b31d.IconAction(_0x79e9d66e, _0x02e2298a._0x3a718410(new byte[9] { 213, 228, 240, 246, 224, 214, 233, 234, 241 }, 133), new Vector2(0.925f, TopRow), Vector2.zero, IconSide, _0x6c38525d, _0xa8c1dd53.WithAlpha(_0xa8c1dd53.SurfaceEdge, 0.98f), _0x0bbe6f2a, _0xa8c1dd53.Gold);
        this._0xbae7dc0b = _0x1685b31d.Caption(_0x79e9d66e, _0x02e2298a._0x3a718410(new byte[10] { 161, 142, 141, 129, 137, 174, 131, 128, 135, 142 }, 226), new Vector2(0.5f, TopRow), Vector2.zero, new Vector2(420f, 96f), _0x02e2298a._0x3a718410(new byte[4] { 83, 89, 83, 83 }, 99), 56f, _0xa8c1dd53.Cream, TextAlignmentOptions.Center, _0x2bafe7d0);
        this.BuildGauges(_0x79e9d66e, _0x2bafe7d0, _0x6c38525d, _0xa6453989, _0x6fa67501, _0xefd284e1);
        this.BuildMeters(_0x79e9d66e, _0x2bafe7d0, _0x6c38525d, _0x6cb3c6f3);
        _0x1685b31d.Caption(_0x79e9d66e, _0x02e2298a._0x3a718410(new byte[11] { 232, 196, 197, 223, 217, 196, 199, 227, 194, 197, 223 }, 171), new Vector2(0.5f, HintRow), Vector2.zero, new Vector2(1120f, 76f), _0x02e2298a._0x3a718410(new byte[35] { 41, 60, 45, 93, 49, 56, 59, 41, 93, 50, 47, 93, 47, 52, 58, 53, 41, 93, 41, 50, 93, 41, 40, 47, 51, 93, 41, 53, 56, 93, 63, 50, 42, 49, 46 }, 125), 34f, _0xa8c1dd53.Cream, TextAlignmentOptions.Center, _0x2bafe7d0);
        this._0x0e5f1142 = this.BuildTurnButton(_0x79e9d66e, _0x02e2298a._0x3a718410(new byte[8] { 189, 156, 155, 135, 165, 140, 143, 157 }, 233), 0.215f, _0x38134412, _0x02e2298a._0x3a718410(new byte[4] { 105, 96, 99, 113 }, 37), _0x6c38525d, _0x2bafe7d0);
        this._0xae1cd1f8 = this.BuildTurnButton(_0x79e9d66e, _0x02e2298a._0x3a718410(new byte[9] { 126, 95, 88, 68, 120, 67, 77, 66, 94 }, 42), 0.785f, _0xea28712a, _0x02e2298a._0x3a718410(new byte[5] { 178, 169, 167, 168, 180 }, 224), _0x6c38525d, _0x2bafe7d0);
        this._0xb9c03c43 = _0x1685b31d.Caption(_0x79e9d66e, _0x02e2298a._0x3a718410(new byte[11] { 57, 30, 9, 16, 10, 13, 57, 19, 30, 12, 23 }, 127), new Vector2(0.5f, 0.72f), Vector2.zero, new Vector2(700f, 110f), string.Empty, 60f, _0xa8c1dd53.Gold, TextAlignmentOptions.Center, _0x2bafe7d0);
        this._0xb9c03c43.gameObject.SetActive(false);
    }

    private _0x85bace7c _0x04d7cdad;
    private TextMeshProUGUI _0xb9c03c43;
    private const float TopRow = 0.964f;
    private const float MeterRow = 0.61f;
    public void _0x65684da9(float _0xa37c4097)
    {
        if (this._0xbae7dc0b == null)
        {
            return;
        }

        int _0xb4cf0d5b = Mathf.Max(0, Mathf.CeilToInt(_0xa37c4097));
        int _0xe7a8ad0b = _0xb4cf0d5b / 60;
        int _0x320872ff = _0xb4cf0d5b % 60;
        this._0xbae7dc0b.text = _0xe7a8ad0b + _0x02e2298a._0x3a718410(new byte[1] { 207 }, 245) + (_0x320872ff < 10 ? _0x02e2298a._0x3a718410(new byte[1] { 145 }, 161) + _0x320872ff : _0x320872ff.ToString());
        bool _0x2ee818bc = _0xb4cf0d5b <= 10;
        _0x838bc0a6.ApplyOutline(this._0xbae7dc0b, _0x2ee818bc ? _0xa8c1dd53.Crimson : _0xa8c1dd53.Cream);
    }

    private void BuildMeters(Transform _0x8b163534, TMP_FontAsset _0x0d7ced86, Sprite _0xdfa61b23, Sprite _0x0256722c)
    {
        RectTransform _0x0d436ff0 = _0x1685b31d.Node(_0x8b163534, _0x02e2298a._0x3a718410(new byte[9] { 161, 130, 155, 158, 158, 162, 155, 130, 129 }, 242), new Vector2(0.16f, MeterRow), Vector2.zero, new Vector2(330f, 76f));
        for (int _0x8f1c331a = 0; _0x8f1c331a < PipCount; _0x8f1c331a++)
        {
            float _0x42cd1fa6 = -124f + (_0x8f1c331a * 62f);
            Image _0x28fa9768 = _0x1685b31d.Plate(_0x0d436ff0, _0x02e2298a._0x3a718410(new byte[8] { 16, 51, 42, 47, 47, 19, 42, 51 }, 67) + _0x8f1c331a, new Vector2(0.5f, 0.5f), new Vector2(_0x42cd1fa6, 0f), new Vector2(52f, 52f), _0xdfa61b23, _0xa8c1dd53.SurfaceEdge);
            this._0x8053c189[_0x8f1c331a] = _0x28fa9768;
        }

        _0x1685b31d.Picture(_0x0d436ff0, _0x02e2298a._0x3a718410(new byte[9] { 60, 31, 6, 3, 3, 34, 14, 29, 4 }, 111), new Vector2(0.5f, 0.5f), new Vector2(0f, 54f), new Vector2(40f, 40f), _0x0256722c, _0xa8c1dd53.WithAlpha(_0xa8c1dd53.Crimson, 0.9f));
        this._0xb5bf0ff1 = _0x1685b31d.Caption(_0x8b163534, _0x02e2298a._0x3a718410(new byte[11] { 145, 167, 176, 171, 167, 177, 142, 163, 160, 167, 174 }, 194), new Vector2(0.84f, MeterRow), Vector2.zero, new Vector2(300f, 84f), string.Empty, 44f, _0xa8c1dd53.Gold, TextAlignmentOptions.Center, _0x0d7ced86);
        this._0xb5bf0ff1.gameObject.SetActive(false);
    }

    public Button _0xc34d022c
    {
        get
        {
            return this._0x0e5f1142;
        }
    }

    public Button _0x3c3416fe
    {
        get
        {
            return this._0x21acb640;
        }
    }

    public void _0x604f8ffa(string _0xd8f13964)
    {
        if (this._0xb9c03c43 == null)
        {
            return;
        }

        this._0xb9c03c43.text = _0xd8f13964;
        this._0xb9c03c43.gameObject.SetActive(true);
        RectTransform _0xb0d711c1 = this._0xb9c03c43.rectTransform;
        _0xb0d711c1.DOKill();
        _0xb0d711c1.anchoredPosition = Vector2.zero;
        _0xb0d711c1.DOAnchorPosY(120f, 0.9f).SetEase(Ease.OutCubic);
        DOTween.To(() => this._0xb9c03c43.alpha, _0xb0bfeffb => this._0xb9c03c43.alpha = _0xb0bfeffb, 0f, 0.9f).OnComplete(() => this._0x378ab845());
    }

    private TextMeshProUGUI _0xb5bf0ff1;
    public Button _0xb709b019
    {
        get
        {
            return this._0xae1cd1f8;
        }
    }

    private bool _0xb473b284;
    private Button _0x16d7212a;
    private Button _0xae1cd1f8;
    private readonly Image[] _0x7f5076d7 = new Image[_0x8b743421.CourtColours];
    public void _0x159005c9(int _0xc4f99b73)
    {
        for (int _0x4dbc29cc = 0; _0x4dbc29cc < this._0x8053c189.Length; _0x4dbc29cc++)
        {
            if (this._0x8053c189[_0x4dbc29cc] == null)
            {
                continue;
            }

            bool _0x104df0a6 = _0x4dbc29cc < _0xc4f99b73;
            this._0x8053c189[_0x4dbc29cc].color = _0x104df0a6 ? _0xa8c1dd53.Crimson : _0xa8c1dd53.SurfaceEdge;
            if (_0x104df0a6)
            {
                this._0x8053c189[_0x4dbc29cc].transform.DOComplete();
                this._0x8053c189[_0x4dbc29cc].transform.DOPunchScale(Vector3.one * 0.2f, 0.28f, 6, 0.6f);
            }
        }
    }

    public void _0x9557dc85(int _0xc62b9a92, int _0xd77ca63d, int _0x5882fb0c)
    {
        int _0xa88b62b0 = _0x8b743421.ClampColour(_0xc62b9a92);
        bool _0xf254fac9 = _0x5882fb0c > 0 && _0xd77ca63d >= _0x5882fb0c;
        if (this._0xe07fd8a5[_0xa88b62b0] != null)
        {
            float _0x20a73f1e = _0x5882fb0c > 0 ? Mathf.Clamp01((float)_0xd77ca63d / _0x5882fb0c) : 0f;
            this._0xe07fd8a5[_0xa88b62b0].DOKill();
            DOTween.To(() => this._0xe07fd8a5[_0xa88b62b0].fillAmount, _0xb0bfeffb => this._0xe07fd8a5[_0xa88b62b0].fillAmount = _0xb0bfeffb, _0x20a73f1e, 0.25f);
        }

        if (this._0xe7f7b26b[_0xa88b62b0] != null)
        {
            this._0xe7f7b26b[_0xa88b62b0].text = _0xd77ca63d + _0x02e2298a._0x3a718410(new byte[1] { 107 }, 68) + _0x5882fb0c;
        }

        if (this._0xbf292606[_0xa88b62b0] != null)
        {
            this._0xbf292606[_0xa88b62b0].color = _0xf254fac9 ? _0xa8c1dd53.WithAlpha(_0xa8c1dd53.Gold, 0.95f) : _0xa8c1dd53.WithAlpha(_0xa8c1dd53.SurfaceEdge, 0.98f);
        }

        _0x1685b31d.SetVisible(this._0x7f5076d7[_0xa88b62b0], _0xf254fac9);
        if (_0xf254fac9 && this._0xbf292606[_0xa88b62b0] != null)
        {
            this._0xbf292606[_0xa88b62b0].transform.DOComplete();
            this._0xbf292606[_0xa88b62b0].transform.DOPunchScale(Vector3.one * 0.1f, 0.3f, 5, 0.6f);
        }
    }
}

internal static class _0x02e2298a
{
    internal static string _0x3a718410(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}