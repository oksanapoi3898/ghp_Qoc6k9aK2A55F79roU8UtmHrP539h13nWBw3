using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// The menu. It dresses the splash, empties the template pages this game never
/// opens and builds its own body inside the template's DEFAULT panel: the best
/// series so far, a living preview of the platter, the three orders to choose from,
/// the objective line, PLAY and HOW TO PLAY.
///
/// The order chooser lives here rather than on a screen of its own on purpose. A
/// mandatory screen between the menu and the run is a dead end for a review
/// capture; here PLAY always goes straight into the game with COURT preselected,
/// and picking another order is one optional tap.
///
/// PLAY is the template's own scene-loading control, re-dressed rather than
/// duplicated: the face is added as a CHILD of it, so UGUI passes the press up to
/// the button that already knows how to load the scene. This component never loads
/// a scene itself - that would fire the load twice.
public sealed class _0x9083b686 : MonoBehaviour
{
    private TextMeshProUGUI _0xe439996c;
    private readonly _0x5791162a _0xb38d3e6e = new _0x5791162a();
    private const float PreviewRow = 0.435f;
    [SerializeField]
    private Sprite _bowlPlum;
    private const float PlayWidth = 720f;
    private readonly TextMeshProUGUI[] _0x4f7e0312 = new TextMeshProUGUI[_0x8b743421.CourtColours];
    private const float BestRow = 0.93f;
    private readonly Image[] _0x5d725bc0 = new Image[3];
    [SerializeField]
    private Sprite _fruitPlum;
    [SerializeField]
    private Sprite _bowlLime;
    private void _0xc2bef4b5(int _0x4e033e14, bool _0x78afd0fe)
    {
        this._0x82295c5e = _0x8b743421.Wrap(_0x4e033e14);
        this._0xb38d3e6e._0x7fbf72ca = this._0x82295c5e;
        _0x42e2125f _0x32c9807f = _0x8b743421.Order(this._0x82295c5e);
        for (int _0xaab00ab6 = 0; _0xaab00ab6 < _0x8b743421._0xeba19757; _0xaab00ab6++)
        {
            bool _0xeff00601 = _0xaab00ab6 == this._0x82295c5e;
            if (this._0x5d725bc0[_0xaab00ab6] != null)
            {
                this._0x5d725bc0[_0xaab00ab6].color = _0xa8c1dd53.WithAlpha(_0xa8c1dd53.Gold, _0xeff00601 ? 1f : 0f);
            }

            if (this._0xd2754b50[_0xaab00ab6] != null)
            {
                this._0xd2754b50[_0xaab00ab6].color = _0xeff00601 ? _0xa8c1dd53.Surface : _0xa8c1dd53.WithAlpha(_0xa8c1dd53.Surface, 0.55f);
            }

            if (this._0x642312b0[_0xaab00ab6] != null)
            {
                this._0x642312b0[_0xaab00ab6].DOKill();
                this._0x642312b0[_0xaab00ab6].anchoredPosition = new Vector2((_0xaab00ab6 - 1) * ChipPitch, _0xeff00601 ? 10f : 0f);
                if (_0xeff00601 && _0x78afd0fe)
                {
                    this._0x642312b0[_0xaab00ab6].DOPunchScale(Vector3.one * 0.12f, 0.25f, 6, 0.6f);
                }
            }
        }

        for (int _0x1aa0b716 = 0; _0x1aa0b716 < _0x8b743421.CourtColours; _0x1aa0b716++)
        {
            if (this._0x4f7e0312[_0x1aa0b716] != null)
            {
                int _0xe7361c7d = _0x1aa0b716 < _0x32c9807f.Targets.Length ? _0x32c9807f.Targets[_0x1aa0b716] : 0;
                this._0x4f7e0312[_0x1aa0b716].text = _0xe7361c7d.ToString();
            }
        }

        if (this._0xe439996c != null)
        {
            this._0xe439996c.text = _0x32c9807f.Subtitle + _0xd4e27ff3._0xd04c0aa0(new byte[35] { 16, 78, 79, 72, 84, 58, 78, 82, 95, 58, 88, 85, 77, 86, 73, 54, 58, 89, 91, 78, 89, 82, 58, 95, 76, 95, 72, 67, 58, 89, 85, 86, 85, 79, 72 }, 26);
        }

        if (this._0x7b5dc7c9 != null)
        {
            this._0x7b5dc7c9.text = _0xd4e27ff3._0xd04c0aa0(new byte[6] { 92, 91, 77, 74, 62, 102 }, 30) + this._0xb38d3e6e._0x3124f0c2;
        }
    }

    /// A preview of what the chosen order asks of each bowl. It changes with the
    /// chip, so the choice is visible in three places at once: the chip lifts and
    /// gains a gold frame, the objective line is rewritten, and these four numbers
    /// move (rule C.7).
    private void BuildPreview(Transform _0xd9e0893e)
    {
        RectTransform _0xdcd69527 = _0x1685b31d.Node(_0xd9e0893e, _0xd4e27ff3._0xd04c0aa0(new byte[12] { 127, 66, 84, 85, 66, 96, 66, 85, 70, 89, 85, 71 }, 48), new Vector2(0.5f, PreviewRow), Vector2.zero, new Vector2(900f, 96f));
        for (int _0xb21bc728 = 0; _0xb21bc728 < _0x8b743421.CourtColours; _0xb21bc728++)
        {
            float _0xd8f77d10 = (_0xb21bc728 - 1.5f) * 196f;
            _0x1685b31d.Plate(_0xdcd69527, _0xd4e27ff3._0xd04c0aa0(new byte[10] { 211, 241, 230, 245, 234, 230, 244, 211, 234, 243 }, 131) + _0xb21bc728, new Vector2(0.5f, 0.5f), new Vector2(_0xd8f77d10, 0f), new Vector2(168f, 76f), this._plateSprite, _0xa8c1dd53.WithAlpha(_0x8b743421.Tint(_0xb21bc728), 0.22f));
            this._0x4f7e0312[_0xb21bc728] = _0x1685b31d.Caption(_0xdcd69527, _0xd4e27ff3._0xd04c0aa0(new byte[12] { 112, 82, 69, 86, 73, 69, 87, 99, 79, 85, 78, 84 }, 32) + _0xb21bc728, new Vector2(0.5f, 0.5f), new Vector2(_0xd8f77d10, 0f), new Vector2(160f, 70f), _0xd4e27ff3._0xd04c0aa0(new byte[1] { 251 }, 203), 36f, _0x8b743421.Readable(_0xb21bc728), TextAlignmentOptions.Center, this._font);
        }
    }

    private void BuildBest(Transform _0xd8149405)
    {
        RectTransform _0xcf16edcc = _0x1685b31d.Node(_0xd8149405, _0xd4e27ff3._0xd04c0aa0(new byte[8] { 242, 213, 195, 196, 227, 220, 223, 196 }, 176), new Vector2(0.5f, BestRow), Vector2.zero, new Vector2(460f, 118f));
        _0x1685b31d.Plate(_0xcf16edcc, _0xd4e27ff3._0xd04c0aa0(new byte[9] { 9, 46, 56, 63, 27, 39, 42, 63, 46 }, 75), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(460f, 118f), this._plateSprite, _0xa8c1dd53.WithAlpha(_0xa8c1dd53.Surface, 0.94f));
        _0x1685b31d.Plate(_0xcf16edcc, _0xd4e27ff3._0xd04c0aa0(new byte[8] { 61, 26, 12, 11, 58, 27, 24, 26 }, 127), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(432f, 92f), this._plateSprite, _0xa8c1dd53.WithAlpha(_0xa8c1dd53.Night, 0.9f));
        this._0x7b5dc7c9 = _0x1685b31d.Caption(_0xcf16edcc, _0xd4e27ff3._0xd04c0aa0(new byte[9] { 121, 94, 72, 79, 119, 90, 89, 94, 87 }, 59), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(410f, 80f), _0xd4e27ff3._0xd04c0aa0(new byte[6] { 17, 22, 0, 7, 115, 43 }, 83) + this._0xb38d3e6e._0x3124f0c2, 42f, _0xa8c1dd53.Gold, TextAlignmentOptions.Center, this._font);
    }

    [SerializeField]
    private Sprite _crownSprite;
    [SerializeField]
    private TMP_FontAsset _font;
    private const float PlayHeight = 168f;
    [SerializeField]
    private Sprite _closeIcon;
    [SerializeField]
    private Sprite _bowlCherry;
    private const float ChipRow = 0.5f;
    private const float HeroRow = 0.715f;
    [SerializeField]
    private Sprite _bowlPear;
    /// The hero: the crown mark over the four court bowls, with three fruits
    /// drifting above them. Nothing here is interactive, so nothing takes a ray.
    private void BuildHero(Transform _0xdab21331)
    {
        RectTransform _0xf39a7e14 = _0x1685b31d.Node(_0xdab21331, _0xd4e27ff3._0xd04c0aa0(new byte[4] { 207, 226, 245, 232 }, 135), new Vector2(0.5f, HeroRow), Vector2.zero, new Vector2(1000f, 760f));
        _0x1685b31d.Picture(_0xf39a7e14, _0xd4e27ff3._0xd04c0aa0(new byte[9] { 87, 122, 109, 112, 92, 109, 112, 104, 113 }, 31), new Vector2(0.5f, 0.5f), new Vector2(0f, 230f), new Vector2(320f, 320f), this._crownSprite, _0xa8c1dd53.Gold);
        Sprite[] _0xbc600187 =
        {
            this._bowlPlum,
            this._bowlPear,
            this._bowlCherry,
            this._bowlLime
        };
        for (int _0xc3c6515f = 0; _0xc3c6515f < _0xbc600187.Length; _0xc3c6515f++)
        {
            float _0xb2431f84 = (_0xc3c6515f - 1.5f) * 192f;
            _0x1685b31d.Picture(_0xf39a7e14, _0xd4e27ff3._0xd04c0aa0(new byte[8] { 22, 59, 44, 49, 28, 49, 41, 50 }, 94) + _0xc3c6515f, new Vector2(0.5f, 0.5f), new Vector2(_0xb2431f84, -232f), new Vector2(176f, 176f), _0xbc600187[_0xc3c6515f], Color.white);
        }

        Sprite[] _0xd9ff4078 =
        {
            this._fruitPlum,
            this._fruitPear,
            this._fruitCherry,
            this._fruitLime
        };
        float[] _0x774b2656 =
        {
            -280f,
            -94f,
            94f,
            280f
        };
        float[] _0xbef71768 =
        {
            -40f,
            24f,
            24f,
            -40f
        };
        for (int _0x839f28c6 = 0; _0x839f28c6 < _0xd9ff4078.Length; _0x839f28c6++)
        {
            Image _0xdbb0c2c6 = _0x1685b31d.Picture(_0xf39a7e14, _0xd4e27ff3._0xd04c0aa0(new byte[9] { 143, 162, 181, 168, 129, 181, 178, 174, 179 }, 199) + _0x839f28c6, new Vector2(0.5f, 0.5f), new Vector2(_0x774b2656[_0x839f28c6], _0xbef71768[_0x839f28c6]), new Vector2(132f, 132f), _0xd9ff4078[_0x839f28c6], Color.white);
            RectTransform _0x6e97637d = _0xdbb0c2c6.rectTransform;
            _0x6e97637d.DOAnchorPosY(_0x6e97637d.anchoredPosition.y + 16f, 2.4f).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo).SetDelay(_0x839f28c6 * 0.3f);
        }
    }

    [SerializeField]
    private Sprite _plateSprite;
    private const float HowToRow = 0.155f;
    private void Start()
    {
        _0x45ccd1e4.BlankUnusedPages();
        _0x45ccd1e4.DressSplash(this._font, this._crownSprite, this._plateSprite);
        Transform _0x4323d2cb = _0x45ccd1e4.PanelBody(_0xd21d76d7._0xc4101fb1.DEFAULT);
        if (_0x4323d2cb == null)
        {
            return;
        }

        Transform _0xe92ad7c7 = this._playSlot != null ? this._playSlot.transform : null;
        _0x45ccd1e4.ClearPanelBody(_0xd21d76d7._0xc4101fb1.DEFAULT, _0xe92ad7c7);
        RectTransform _0x22fdcce9 = _0x1685b31d.Stretch(_0x4323d2cb, _0xd4e27ff3._0xd04c0aa0(new byte[8] { 125, 85, 94, 69, 114, 95, 84, 73 }, 48));
        this.BuildBest(_0x22fdcce9);
        this.BuildHero(_0x22fdcce9);
        this.BuildChips(_0x22fdcce9);
        this.BuildPreview(_0x22fdcce9);
        this._0xe439996c = _0x1685b31d.Caption(_0x22fdcce9, _0xd4e27ff3._0xd04c0aa0(new byte[9] { 246, 219, 211, 220, 218, 205, 208, 207, 220 }, 185), new Vector2(0.5f, ObjectiveRow), Vector2.zero, new Vector2(1100f, 88f), _0xd4e27ff3._0xd04c0aa0(new byte[48] { 56, 57, 62, 34, 76, 56, 36, 41, 76, 46, 35, 59, 32, 63, 66, 76, 47, 45, 56, 47, 36, 76, 41, 58, 41, 62, 53, 76, 42, 62, 57, 37, 56, 76, 37, 34, 76, 37, 56, 63, 76, 47, 35, 32, 35, 57, 62, 66 }, 108), 36f, _0xa8c1dd53.Cream, TextAlignmentOptions.Center, this._font);
        this._0xbbf14009();
        Button _0x3e48337f = _0x1685b31d.Action(_0x22fdcce9, _0xd4e27ff3._0xd04c0aa0(new byte[9] { 239, 200, 208, 243, 200, 247, 203, 198, 222 }, 167), new Vector2(0.5f, HowToRow), Vector2.zero, new Vector2(520f, 120f), this._plateSprite, _0xa8c1dd53.WithAlpha(_0xa8c1dd53.Surface, 0.96f), _0xd4e27ff3._0xd04c0aa0(new byte[11] { 110, 105, 113, 6, 114, 105, 6, 118, 106, 103, 127 }, 38), 40f, _0xa8c1dd53.Gold, this._font);
        _0x3e48337f.onClick.AddListener(() => this._0x0a23cad7());
        if (this._howTo != null)
        {
            this._howTo._0x71ef9690(_0x4323d2cb, this._font, this._plateSprite, this._closeIcon, this._arrowLeft, this._arrowRight, this._bowlPear, this._fruitPlum, this._spillSprite);
        }

        this._0xc2bef4b5(this._0xb38d3e6e._0x7fbf72ca, false);
    }

    [SerializeField]
    private Sprite _arrowLeft;
    private void BuildChips(Transform _0x682d9ae1)
    {
        RectTransform _0xe01b12f9 = _0x1685b31d.Node(_0x682d9ae1, _0xd4e27ff3._0xd04c0aa0(new byte[10] { 132, 185, 175, 174, 185, 136, 163, 162, 187, 184 }, 203), new Vector2(0.5f, ChipRow), Vector2.zero, new Vector2(1140f, 240f));
        // A list that can be empty must say so rather than leave a hole in the
        // screen. This one is served from a fixed catalogue so it never is, but the
        // message is here because an empty area with no explanation is a defect.
        if (_0x8b743421._0xeba19757 <= 0)
        {
            _0x1685b31d.Plate(_0xe01b12f9, _0xd4e27ff3._0xd04c0aa0(new byte[13] { 195, 226, 194, 255, 233, 232, 255, 254, 221, 225, 236, 249, 232 }, 141), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(900f, 180f), this._plateSprite, _0xa8c1dd53.WithAlpha(_0xa8c1dd53.Surface, 0.92f));
            _0x1685b31d.Caption(_0xe01b12f9, _0xd4e27ff3._0xd04c0aa0(new byte[12] { 218, 251, 219, 230, 240, 241, 230, 231, 192, 241, 236, 224 }, 148), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(860f, 90f), _0xd4e27ff3._0xd04c0aa0(new byte[13] { 230, 231, 136, 231, 250, 236, 237, 250, 251, 136, 241, 237, 252 }, 168), 40f, _0xa8c1dd53.Muted, TextAlignmentOptions.Center, this._font);
            return;
        }

        for (int _0x58605f32 = 0; _0x58605f32 < _0x8b743421._0xeba19757; _0x58605f32++)
        {
            int _0xa3be79cd = _0x58605f32;
            _0x42e2125f _0x6424076d = _0x8b743421.Order(_0xa3be79cd);
            float _0x83e6abde = (_0xa3be79cd - 1) * ChipPitch;
            Button _0x7ab76030 = _0x1685b31d.Action(_0xe01b12f9, _0xd4e27ff3._0xd04c0aa0(new byte[9] { 134, 187, 173, 172, 187, 138, 161, 160, 185 }, 201) + _0xa3be79cd, new Vector2(0.5f, 0.5f), new Vector2(_0x83e6abde, 0f), new Vector2(340f, 230f), this._plateSprite, _0xa8c1dd53.WithAlpha(_0xa8c1dd53.Gold, 0f), string.Empty, _0x838bc0a6.UiFontFloor, _0xa8c1dd53.Cream, null);
            this._0x642312b0[_0xa3be79cd] = _0x7ab76030.GetComponent<RectTransform>();
            this._0x5d725bc0[_0xa3be79cd] = _0x7ab76030.GetComponent<Image>();
            this._0xd2754b50[_0xa3be79cd] = _0x1685b31d.Plate(_0x7ab76030.transform, _0xd4e27ff3._0xd04c0aa0(new byte[8] { 249, 210, 211, 202, 248, 213, 222, 195 }, 186), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(316f, 206f), this._plateSprite, _0xa8c1dd53.Surface);
            _0x1685b31d.Caption(_0x7ab76030.transform, _0xd4e27ff3._0xd04c0aa0(new byte[9] { 26, 49, 48, 41, 13, 48, 45, 53, 60 }, 89), new Vector2(0.5f, 0.5f), new Vector2(0f, 46f), new Vector2(300f, 76f), _0x6424076d.Title, 38f, _0xa8c1dd53.Cream, TextAlignmentOptions.Center, this._font);
            _0x1685b31d.Caption(_0x7ab76030.transform, _0xd4e27ff3._0xd04c0aa0(new byte[8] { 37, 14, 15, 22, 33, 9, 7, 10 }, 102), new Vector2(0.5f, 0.5f), new Vector2(0f, -22f), new Vector2(300f, 60f), _0x8b743421.TotalFruits(_0xa3be79cd) + _0xd4e27ff3._0xd04c0aa0(new byte[7] { 156, 250, 238, 233, 245, 232, 239 }, 188), 32f, _0xa8c1dd53.Gold, TextAlignmentOptions.Center, this._font);
            _0x1685b31d.Caption(_0x7ab76030.transform, _0xd4e27ff3._0xd04c0aa0(new byte[9] { 172, 135, 134, 159, 172, 131, 128, 140, 132 }, 239), new Vector2(0.5f, 0.5f), new Vector2(0f, -74f), new Vector2(300f, 56f), Mathf.RoundToInt(_0x6424076d.ClockSeconds) + _0xd4e27ff3._0xd04c0aa0(new byte[1] { 40 }, 123), 32f, _0xa8c1dd53.PlumText, TextAlignmentOptions.Center, this._font);
            _0x7ab76030.onClick.AddListener(() => this._0x1db936f9(_0xa3be79cd));
        }
    }

    [SerializeField]
    private Sprite _fruitPear;
    private const float ChipPitch = 360f;
    [SerializeField]
    private _0xdafc9083 _howTo;
    private readonly RectTransform[] _0x642312b0 = new RectTransform[3];
    [SerializeField]
    private _0xaed20021 _playSlot;
    private const float ObjectiveRow = 0.385f;
    private void _0x0a23cad7()
    {
        if (this._howTo != null)
        {
            this._howTo._0xcc4cd1e4();
        }
    }

    [SerializeField]
    private Sprite _fruitCherry;
    /// Dresses the template's scene-loading control instead of adding a second one.
    /// The face is a child of that button, so the press reaches the button itself.
    private void _0xbbf14009()
    {
        if (this._playSlot == null)
        {
            return;
        }

        RectTransform _0x992772ec = _0x1685b31d.Stretch(this._playSlot.transform, _0xd4e27ff3._0xd04c0aa0(new byte[8] { 33, 29, 16, 8, 55, 16, 18, 20 }, 113));
        Image _0x1d5d81e1 = _0x992772ec.gameObject.AddComponent<Image>();
        _0x1d5d81e1.sprite = this._plateSprite;
        _0x1d5d81e1.type = Image.Type.Sliced;
        _0x1d5d81e1.pixelsPerUnitMultiplier = _0x1685b31d.SliceScale(new Vector2(PlayWidth, PlayHeight));
        _0x1d5d81e1.color = _0xa8c1dd53.Gold;
        _0x1d5d81e1.raycastTarget = true;
        _0x1d5d81e1.canvasRenderer.cullTransparentMesh = false;
        _0x1685b31d.Plate(_0x992772ec, _0xd4e27ff3._0xd04c0aa0(new byte[8] { 178, 142, 131, 155, 167, 134, 133, 135 }, 226), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(PlayWidth - 20f, PlayHeight - 20f), this._plateSprite, _0xa8c1dd53.WithAlpha(_0xa8c1dd53.Gold, 1f));
        _0x1685b31d.Caption(_0x992772ec, _0xd4e27ff3._0xd04c0aa0(new byte[9] { 200, 244, 249, 225, 212, 249, 250, 253, 244 }, 152), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(PlayWidth - 80f, PlayHeight - 44f), _0xd4e27ff3._0xd04c0aa0(new byte[4] { 42, 54, 59, 35 }, 122), 60f, _0xa8c1dd53.Night, TextAlignmentOptions.Center, this._font);
        _0x992772ec.DOScale(1.04f, 1.1f).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo);
    }

    private readonly Image[] _0xd2754b50 = new Image[3];
    [SerializeField]
    private Sprite _arrowRight;
    private void _0x1db936f9(int _0x5847fbe5)
    {
        this._0xc2bef4b5(_0x5847fbe5, true);
    }

    [SerializeField]
    private Sprite _spillSprite;
    [SerializeField]
    private Sprite _fruitLime;
    private TextMeshProUGUI _0x7b5dc7c9;
    private int _0x82295c5e;
}

internal static class _0xd4e27ff3
{
    internal static string _0xd04c0aa0(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}