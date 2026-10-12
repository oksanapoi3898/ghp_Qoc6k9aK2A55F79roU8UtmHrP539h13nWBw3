using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// Owns the three cards the run can raise. The template's own pops carry another
/// game's wording, a grey body and a close button with no icon assigned - which
/// Unity draws as a plain white square. So every child of a pop body is switched
/// off and this game builds its own card inside it: header, illustration, two
/// metric lines, two captioned actions and a real close glyph taken from a
/// serialized sprite (rule C.3).
///
/// Each button is built explicitly with its own caption, so a caption can never
/// land on the close cross the way an index-ordered pass would put it there
/// (rule C.17).
public sealed class _0x5a871410 : MonoBehaviour
{
    public void _0x2a39bb1a(bool _0x53fd6009, int _0x78c1cce4, int _0x4f8b930a, int _0x1cc56375)
    {
        this._0xa1163fee(Lose, _0x53fd6009 ? _0xda4f2ed1._0x5f68c598(new byte[10] { 23, 10, 14, 6, 99, 10, 16, 99, 22, 19 }, 67) : _0xda4f2ed1._0x5f68c598(new byte[11] { 44, 35, 60, 47, 74, 57, 58, 35, 38, 38, 57 }, 106), _0xda4f2ed1._0x5f68c598(new byte[26] { 113, 109, 96, 5, 102, 106, 112, 119, 113, 5, 105, 96, 100, 115, 96, 118, 5, 113, 109, 96, 5, 113, 100, 103, 105, 96 }, 37), _0xda4f2ed1._0x5f68c598(new byte[14] { 179, 174, 184, 185, 174, 175, 220, 186, 181, 176, 176, 185, 184, 220 }, 252) + _0x78c1cce4 + _0xda4f2ed1._0x5f68c598(new byte[3] { 38, 41, 38 }, 6) + _0x4f8b930a, _0xda4f2ed1._0x5f68c598(new byte[13] { 155, 156, 138, 141, 249, 138, 156, 139, 144, 156, 138, 249, 161 }, 217) + _0x1cc56375);
    }

    public Button _0xfb648f99
    {
        get
        {
            return this._0xede53928[Win];
        }
    }

    private readonly TextMeshProUGUI[] _0xf23c3790 = new TextMeshProUGUI[3];
    private const int Win = 0;
    public void FillWin(int _0x720d1658, int _0x2e56d633)
    {
        this._0xa1163fee(Win, _0xda4f2ed1._0x5f68c598(new byte[14] { 198, 215, 202, 210, 203, 165, 198, 202, 200, 213, 201, 192, 209, 192 }, 133), _0xda4f2ed1._0x5f68c598(new byte[26] { 176, 189, 189, 209, 183, 190, 164, 163, 209, 190, 163, 181, 180, 163, 162, 209, 176, 163, 180, 209, 183, 184, 189, 189, 180, 181 }, 241), _0xda4f2ed1._0x5f68c598(new byte[13] { 248, 255, 233, 238, 154, 233, 255, 232, 243, 255, 233, 154, 194 }, 186) + _0x720d1658, _0xda4f2ed1._0x5f68c598(new byte[10] { 48, 45, 41, 33, 68, 40, 33, 34, 48, 68 }, 100) + _0x2e56d633 + _0xda4f2ed1._0x5f68c598(new byte[1] { 63 }, 108));
    }

    [SerializeField]
    private Sprite _plateSprite;
    private readonly Button[] _0x5c335209 = new Button[3];
    public Button _0xc2f9b9ba
    {
        get
        {
            return this._0x5c335209[Pause];
        }
    }

    private readonly TextMeshProUGUI[] _0xfa221011 = new TextMeshProUGUI[3];
    [SerializeField]
    private Sprite _closeIcon;
    public void _0x90826f9a()
    {
        _0xaeb67229 _0x871e4b33 = _0x87a6397f.Instance._0x42f91743(_0xd21d76d7._0xdc6ccd34.WIN);
        if (_0x871e4b33 == null)
        {
            return;
        }

        _0x87a6397f.Instance._0x69f99dba(_0xd21d76d7._0xdc6ccd34.WIN);
    }

    public Button _0xbe7c4140
    {
        get
        {
            return this._0xede53928[Lose];
        }
    }

    private const int Pause = 2;
    public void _0x2918c325()
    {
        _0x87a6397f _0x563de727 = _0x87a6397f.Instance;
        if (_0x563de727 != null)
        {
            _0x563de727._0x3b04cfaa();
        }
    }

    public Button _0x3b2a3b0a
    {
        get
        {
            return this._0xeded58a9[Win];
        }
    }

    private readonly Button[] _0xeded58a9 = new Button[3];
    public void _0x72ce4ffe()
    {
        _0xaeb67229 _0x5fd7c363 = _0x87a6397f.Instance._0x42f91743(_0xd21d76d7._0xdc6ccd34.PAUSE);
        if (_0x5fd7c363 == null)
        {
            return;
        }

        _0x87a6397f.Instance._0x69f99dba(_0xd21d76d7._0xdc6ccd34.PAUSE);
    }

    public Button _0x14c26d9d
    {
        get
        {
            return this._0xeded58a9[Pause];
        }
    }

    public Button _0xdc777523
    {
        get
        {
            return this._0x5c335209[Lose];
        }
    }

    private void _0xc5da41ed(_0xaeb67229 _0x857e16a3, int _0x115a6bf4, string _0x54db1f47, Color _0x1014a453, string _0x63574208, string _0xd0fb059b)
    {
        if (_0x857e16a3 == null || _0x857e16a3.Content == null)
        {
            return;
        }

        Transform _0x03facb73 = _0x857e16a3.Content.transform;
        for (int _0xb96aff36 = _0x03facb73.childCount - 1; _0xb96aff36 >= 0; _0xb96aff36--)
        {
            _0x03facb73.GetChild(_0xb96aff36).gameObject.SetActive(false);
        }

        RectTransform _0x5cdc01ac = _0x1685b31d.Stretch(_0x03facb73, _0xda4f2ed1._0x5f68c598(new byte[8] { 137, 171, 184, 174, 130, 165, 185, 190 }, 202));
        Image _0xd06a9215 = _0x1685b31d.Plate(_0x5cdc01ac, _0xda4f2ed1._0x5f68c598(new byte[4] { 34, 0, 19, 5 }, 97), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(1000f, 1340f), this._plateSprite, _0xa8c1dd53.WithAlpha(_0xa8c1dd53.Gold, 0.98f));
        Image _0x1fd1d504 = _0x1685b31d.Plate(_0xd06a9215.transform, _0xda4f2ed1._0x5f68c598(new byte[8] { 138, 168, 187, 173, 139, 166, 173, 176 }, 201), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(964f, 1304f), this._plateSprite, _0xa8c1dd53.Surface);
        _0x1685b31d.Plate(_0x1fd1d504.transform, _0xda4f2ed1._0x5f68c598(new byte[8] { 77, 111, 124, 106, 89, 107, 98, 98 }, 14), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(932f, 1272f), this._plateSprite, _0xa8c1dd53.WithAlpha(_0xa8c1dd53.Night, 0.96f));
        _0x1685b31d.Picture(_0xd06a9215.transform, _0xda4f2ed1._0x5f68c598(new byte[9] { 165, 135, 148, 130, 165, 148, 131, 149, 146 }, 230), new Vector2(0.5f, 1f), new Vector2(0f, -240f), new Vector2(300f, 300f), this._crownSprite, _0xa8c1dd53.Gold);
        this._0xfa221011[_0x115a6bf4] = _0x1685b31d.Caption(_0xd06a9215.transform, _0xda4f2ed1._0x5f68c598(new byte[10] { 47, 13, 30, 8, 36, 9, 13, 8, 9, 30 }, 108), new Vector2(0.5f, 1f), new Vector2(0f, -500f), new Vector2(880f, 128f), _0x54db1f47, 72f, _0x1014a453, TextAlignmentOptions.Center, this._font);
        this._0x840b30be[_0x115a6bf4] = _0x1685b31d.Caption(_0xd06a9215.transform, _0xda4f2ed1._0x5f68c598(new byte[12] { 87, 117, 102, 112, 86, 123, 112, 109, 64, 113, 108, 96 }, 20), new Vector2(0.5f, 1f), new Vector2(0f, -636f), new Vector2(880f, 96f), string.Empty, 40f, _0xa8c1dd53.Muted, TextAlignmentOptions.Center, this._font);
        this._0x0d9ec03d[_0x115a6bf4] = _0x1685b31d.Caption(_0xd06a9215.transform, _0xda4f2ed1._0x5f68c598(new byte[10] { 248, 218, 201, 223, 246, 222, 207, 201, 210, 216 }, 187), new Vector2(0.5f, 1f), new Vector2(0f, -770f), new Vector2(880f, 92f), string.Empty, 44f, _0xa8c1dd53.Gold, TextAlignmentOptions.Center, this._font);
        this._0xf23c3790[_0x115a6bf4] = _0x1685b31d.Caption(_0xd06a9215.transform, _0xda4f2ed1._0x5f68c598(new byte[9] { 109, 79, 92, 74, 107, 86, 90, 92, 79 }, 46), new Vector2(0.5f, 1f), new Vector2(0f, -880f), new Vector2(880f, 88f), string.Empty, 40f, _0xa8c1dd53.PlumText, TextAlignmentOptions.Center, this._font);
        this._0xeded58a9[_0x115a6bf4] = _0x1685b31d.Action(_0xd06a9215.transform, _0xda4f2ed1._0x5f68c598(new byte[11] { 160, 130, 145, 135, 179, 145, 138, 142, 130, 145, 154 }, 227), new Vector2(0.5f, 0f), new Vector2(-240f, 150f), new Vector2(440f, 150f), this._plateSprite, _0xa8c1dd53.Gold, _0x63574208, 40f, _0xa8c1dd53.Night, this._font);
        this._0x5c335209[_0x115a6bf4] = _0x1685b31d.Action(_0xd06a9215.transform, _0xda4f2ed1._0x5f68c598(new byte[13] { 100, 70, 85, 67, 116, 66, 68, 72, 73, 67, 70, 85, 94 }, 39), new Vector2(0.5f, 0f), new Vector2(240f, 150f), new Vector2(440f, 150f), this._plateSprite, _0xa8c1dd53.Plum, _0xd0fb059b, 40f, _0xa8c1dd53.Cream, this._font);
        this._0xede53928[_0x115a6bf4] = _0x1685b31d.IconAction(_0xd06a9215.transform, _0xda4f2ed1._0x5f68c598(new byte[9] { 191, 157, 142, 152, 191, 144, 147, 143, 153 }, 252), new Vector2(1f, 1f), new Vector2(-84f, -84f), 100f, this._plateSprite, _0xa8c1dd53.WithAlpha(_0xa8c1dd53.SurfaceEdge, 0.98f), this._closeIcon, _0xa8c1dd53.Gold);
        _0xd06a9215.transform.localScale = Vector3.one;
    }

    private const int Lose = 1;
    private readonly TextMeshProUGUI[] _0x0d9ec03d = new TextMeshProUGUI[3];
    [SerializeField]
    private TMP_FontAsset _font;
    private readonly Button[] _0xede53928 = new Button[3];
    public Button _0x65fe8263
    {
        get
        {
            return this._0xede53928[Pause];
        }
    }

    public Button _0x53a18113
    {
        get
        {
            return this._0xeded58a9[Lose];
        }
    }

    private bool _0x1ec87f7b;
    public Button _0x2ed405f4
    {
        get
        {
            return this._0x5c335209[Win];
        }
    }

    public void FillPause(int _0x66903c00, int _0x68f6e0ac, int _0xef63d4ee)
    {
        this._0xa1163fee(Pause, _0xda4f2ed1._0x5f68c598(new byte[12] { 98, 110, 116, 115, 117, 1, 113, 96, 116, 114, 100, 101 }, 33), _0xda4f2ed1._0x5f68c598(new byte[15] { 135, 155, 150, 243, 149, 129, 134, 154, 135, 243, 132, 146, 154, 135, 128 }, 211), _0xda4f2ed1._0x5f68c598(new byte[14] { 253, 224, 246, 247, 224, 225, 146, 244, 251, 254, 254, 247, 246, 146 }, 178) + _0x66903c00 + _0xda4f2ed1._0x5f68c598(new byte[3] { 26, 21, 26 }, 58) + _0x68f6e0ac, _0xda4f2ed1._0x5f68c598(new byte[10] { 224, 253, 249, 241, 148, 248, 241, 242, 224, 148 }, 180) + _0xef63d4ee + _0xda4f2ed1._0x5f68c598(new byte[1] { 222 }, 141));
    }

    public void _0x9c75a458()
    {
        if (this._0x1ec87f7b)
        {
            return;
        }

        _0x87a6397f _0xc12911bc = _0x87a6397f.Instance;
        if (_0xc12911bc == null || _0xc12911bc.Pops == null)
        {
            return;
        }

        _0xaeb67229 _0xaec40f50 = _0x87a6397f.Instance._0x42f91743(_0xd21d76d7._0xdc6ccd34.WIN);
        _0xaeb67229 _0xa9732167 = _0x87a6397f.Instance._0x42f91743(_0xd21d76d7._0xdc6ccd34.LOSE);
        _0xaeb67229 _0x5fa62c65 = _0x87a6397f.Instance._0x42f91743(_0xd21d76d7._0xdc6ccd34.PAUSE);
        this._0xc5da41ed(_0xaec40f50, Win, _0xda4f2ed1._0x5f68c598(new byte[14] { 226, 243, 238, 246, 239, 129, 226, 238, 236, 241, 237, 228, 245, 228 }, 161), _0xa8c1dd53.Gold, _0xda4f2ed1._0x5f68c598(new byte[10] { 53, 62, 35, 47, 91, 52, 41, 63, 62, 41 }, 123), _0xda4f2ed1._0x5f68c598(new byte[4] { 181, 189, 182, 173 }, 248));
        this._0xc5da41ed(_0xa9732167, Lose, _0xda4f2ed1._0x5f68c598(new byte[11] { 154, 149, 138, 153, 252, 143, 140, 149, 144, 144, 143 }, 220), _0xa8c1dd53.Crimson, _0xda4f2ed1._0x5f68c598(new byte[9] { 48, 54, 61, 68, 37, 35, 37, 45, 42 }, 100), _0xda4f2ed1._0x5f68c598(new byte[4] { 123, 115, 120, 99 }, 54));
        this._0xc5da41ed(_0x5fa62c65, Pause, _0xda4f2ed1._0x5f68c598(new byte[12] { 200, 196, 222, 217, 223, 171, 219, 202, 222, 216, 206, 207 }, 139), _0xa8c1dd53.Cream, _0xda4f2ed1._0x5f68c598(new byte[6] { 102, 113, 103, 97, 121, 113 }, 52), _0xda4f2ed1._0x5f68c598(new byte[4] { 225, 233, 226, 249 }, 172));
        this._0x1ec87f7b = true;
    }

    private readonly TextMeshProUGUI[] _0x840b30be = new TextMeshProUGUI[3];
    public void _0x8c484e4b()
    {
        _0xaeb67229 _0x92cc1b21 = _0x87a6397f.Instance._0x42f91743(_0xd21d76d7._0xdc6ccd34.LOSE);
        if (_0x92cc1b21 == null)
        {
            return;
        }

        _0x87a6397f.Instance._0x69f99dba(_0xd21d76d7._0xdc6ccd34.LOSE);
    }

    [SerializeField]
    private Sprite _crownSprite;
    private void _0xa1163fee(int _0xc6de4a0f, string _0x5587da23, string _0xd05b437b, string _0x35fc5460, string _0x5b30b72c)
    {
        if (this._0xfa221011[_0xc6de4a0f] != null)
        {
            this._0xfa221011[_0xc6de4a0f].text = _0x5587da23;
        }

        if (this._0x840b30be[_0xc6de4a0f] != null)
        {
            this._0x840b30be[_0xc6de4a0f].text = _0xd05b437b;
        }

        if (this._0x0d9ec03d[_0xc6de4a0f] != null)
        {
            this._0x0d9ec03d[_0xc6de4a0f].text = _0x35fc5460;
        }

        if (this._0xf23c3790[_0xc6de4a0f] != null)
        {
            this._0xf23c3790[_0xc6de4a0f].text = _0x5b30b72c;
        }
    }
}

internal static class _0xda4f2ed1
{
    internal static string _0x5f68c598(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}