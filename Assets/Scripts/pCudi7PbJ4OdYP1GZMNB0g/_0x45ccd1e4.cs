using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// Everything this game does TO the scene template: reaching a panel body by its
/// SETTINGS index, clearing the bodies it rebuilds itself, emptying the filler copy
/// on the pages it never opens, and dressing the splash with an abstract mark.
///
/// Panels are addressed by index and never by name: names do not survive
/// obfuscation, and the controllers index their pools anyway.
///
/// The loading bar is NOT touched from here. Its colours are set on the prefab, so
/// the bar is themed before a single frame is drawn and nothing has to run first.
public static class _0x45ccd1e4
{
    /// Every tutorial page the template declares. This game leaves
    /// SETUP_OBJECT.IsTutorialEnabled at 0 and explains its control on its own HOW
    /// TO PLAY sheet plus a standing hint in the run, so none of these pages is
    /// ever opened - but the template copy on them must not reach the build either.
    private static readonly int[] _0x83a9e3ec =
    {
        _0xd21d76d7._0xc4101fb1.TUTORIAL0,
        _0xd21d76d7._0xc4101fb1.TUTORIAL1,
        _0xd21d76d7._0xc4101fb1.TUTORIAL2,
        _0xd21d76d7._0xc4101fb1.TUTORIAL3,
        _0xd21d76d7._0xc4101fb1.TUTORIAL4,
        _0xd21d76d7._0xc4101fb1.TUTORIAL5,
        _0xd21d76d7._0xc4101fb1.TUTORIAL6,
    };
    public static Transform PanelBody(int _0x0eeddb06)
    {
        _0x3fe52430 _0x3b697208 = _0x3fe52430.Instance;
        if (_0x3b697208 == null || _0x3b697208.Panels == null)
        {
            return null;
        }

        if (_0x0eeddb06 < 0 || _0x0eeddb06 >= _0x3b697208.Panels.Count)
        {
            return null;
        }

        _0xfb6d93a0 _0xb40cbef2 = _0x3b697208.Panels[_0x0eeddb06];
        if (_0xb40cbef2 == null || _0xb40cbef2.Content == null)
        {
            return null;
        }

        return _0xb40cbef2.Content.transform;
    }

    /// Switches off whatever the template put into a panel body so this game can
    /// build its own. Two branches are spared: anything holding a Pop (those are
    /// addressed by index and must stay reachable) and the branch handed in, which
    /// is the template's own scene-loading control the menu re-dresses rather than
    /// duplicates.
    public static void ClearPanelBody(int _0xe459bab8, Transform _0x32245899)
    {
        Transform _0xf17bfdae = PanelBody(_0xe459bab8);
        if (_0xf17bfdae == null)
        {
            return;
        }

        for (int _0xde2cc50f = _0xf17bfdae.childCount - 1; _0xde2cc50f >= 0; _0xde2cc50f--)
        {
            Transform _0xade832ad = _0xf17bfdae.GetChild(_0xde2cc50f);
            if (_0xade832ad == null)
            {
                continue;
            }

            if (_0xade832ad.GetComponentInChildren<_0xaeb67229>(true) != null)
            {
                continue;
            }

            if (_0x32245899 != null && (_0xade832ad == _0x32245899 || _0x32245899.IsChildOf(_0xade832ad)))
            {
                continue;
            }

            _0xade832ad.gameObject.SetActive(false);
        }
    }

    /// Empties the filler strings from every template page this game does not dress
    /// itself. The page stays in the pool: the controller addresses panels by index
    /// and a removed page would break its navigation.
    public static void BlankUnusedPages()
    {
        for (int _0xd84c007b = 0; _0xd84c007b < _0x83a9e3ec.Length; _0xd84c007b++)
        {
            Transform _0xd7007cb7 = PanelBody(_0x83a9e3ec[_0xd84c007b]);
            if (_0xd7007cb7 == null)
            {
                continue;
            }

            TMP_Text[] _0x31113d2c = _0xd7007cb7.GetComponentsInChildren<TMP_Text>(true);
            for (int _0xdda3aa3e = 0; _0xdda3aa3e < _0x31113d2c.Length; _0xdda3aa3e++)
            {
                if (_0x31113d2c[_0xdda3aa3e] != null)
                {
                    _0x31113d2c[_0xdda3aa3e].text = string.Empty;
                }
            }
        }
    }

    /// The splash: a dark veil, an abstract crown mark whose points are bowls, and
    /// one functional line. Branding here is colour and shape - there is no name on
    /// screen, by design and by rule.
    ///
    /// The mark goes in as the FIRST child of the splash body, so the loading bar
    /// that already lives there keeps being drawn on top of it.
    public static void DressSplash(TMP_FontAsset _0xeba22819, Sprite _0x5aa90d79, Sprite _0x32582868)
    {
        Transform _0xcc314a06 = PanelBody(_0xd21d76d7._0xc4101fb1.SPLASH);
        if (_0xcc314a06 == null)
        {
            return;
        }

        RectTransform _0x038de25f = _0x1685b31d.Stretch(_0xcc314a06, _0x73a71780._0xebd3d7ad(new byte[10] { 32, 3, 31, 18, 0, 27, 62, 18, 1, 24 }, 115));
        _0x038de25f.SetAsFirstSibling();
        Image _0x520c4095 = _0x038de25f.gameObject.AddComponent<Image>();
        _0x520c4095.color = _0xa8c1dd53.WithAlpha(_0xa8c1dd53.Night, 0.88f);
        _0x520c4095.raycastTarget = false;
        RectTransform _0x0dfb6c5d = _0x1685b31d.Node(_0x038de25f, _0x73a71780._0xebd3d7ad(new byte[11] { 223, 252, 224, 237, 255, 228, 207, 254, 233, 255, 248 }, 140), new Vector2(0.5f, 0.5f), new Vector2(0f, 260f), new Vector2(640f, 640f));
        for (int _0xfcffd9f4 = 0; _0xfcffd9f4 < 16; _0xfcffd9f4++)
        {
            float _0x4e26035b = (360f / 16f) * _0xfcffd9f4;
            float _0x60c923e5 = _0x4e26035b * Mathf.Deg2Rad;
            Image _0xe7af5fad = _0x1685b31d.Plate(_0x0dfb6c5d, _0x73a71780._0xebd3d7ad(new byte[11] { 45, 14, 18, 31, 13, 22, 45, 14, 17, 21, 27 }, 126), new Vector2(0.5f, 0.5f), new Vector2(Mathf.Sin(_0x60c923e5) * 268f, Mathf.Cos(_0x60c923e5) * 268f), new Vector2(46f, 14f), _0x32582868, _0xa8c1dd53.WithAlpha(_0xfcffd9f4 % 4 == 0 ? _0xa8c1dd53.Gold : _0xa8c1dd53.Plum, 0.8f));
            _0xe7af5fad.rectTransform.localRotation = Quaternion.Euler(0f, 0f, -_0x4e26035b);
        }

        _0x1685b31d.Plate(_0x0dfb6c5d, _0x73a71780._0xebd3d7ad(new byte[10] { 115, 80, 76, 65, 83, 72, 104, 65, 76, 79 }, 32), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(430f, 430f), _0x32582868, _0xa8c1dd53.WithAlpha(_0xa8c1dd53.SurfaceEdge, 0.85f));
        _0x1685b31d.Picture(_0x0dfb6c5d, _0x73a71780._0xebd3d7ad(new byte[12] { 107, 72, 84, 89, 75, 80, 125, 85, 90, 84, 93, 85 }, 56), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(330f, 330f), _0x5aa90d79, _0xa8c1dd53.Gold);
        _0x1685b31d.Caption(_0x038de25f, _0x73a71780._0xebd3d7ad(new byte[10] { 177, 146, 142, 131, 145, 138, 174, 139, 140, 135 }, 226), new Vector2(0.5f, 0.5f), new Vector2(0f, -220f), new Vector2(840f, 86f), _0x73a71780._0xebd3d7ad(new byte[7] { 27, 24, 22, 19, 30, 25, 16 }, 87), 42f, _0xa8c1dd53.Cream, TextAlignmentOptions.Center, _0xeba22819);
        _0x1685b31d.Plate(_0x038de25f, _0x73a71780._0xebd3d7ad(new byte[10] { 152, 187, 167, 170, 184, 163, 153, 190, 167, 174 }, 203), new Vector2(0.5f, 0.5f), new Vector2(0f, -296f), new Vector2(420f, 8f), _0x32582868, _0xa8c1dd53.WithAlpha(_0xa8c1dd53.Gold, 0.9f));
    }

    public static void ClearPanelBody(int _0x85a01d0e)
    {
        ClearPanelBody(_0x85a01d0e, null);
    }
}

internal static class _0x73a71780
{
    internal static string _0xebd3d7ad(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}