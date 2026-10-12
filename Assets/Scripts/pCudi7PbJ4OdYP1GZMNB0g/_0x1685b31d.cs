using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// Construction helpers for the UGUI both scenes build at runtime. Every number is
/// written in the canvas reference resolution (1242 x 2688), so one set of
/// coordinates reads the same on every device.
///
/// Inside a canvas the draw order IS the sibling order, so each helper adds its
/// fill FIRST and its glyph or caption afterwards: a background can never cover
/// its own label (rule C.13 / E.1).
public static class _0x1685b31d
{
    public const float RefHeight = 2688f;
    public static TextMeshProUGUI Caption(Transform _0xc8580443, string _0x5a8ca032, Vector2 _0x4cf52782, Vector2 _0x852b7d36, Vector2 _0x95a74c81, string _0x1bf7b7da, float _0x56f9e4bd, Color _0xae95b350, TextAlignmentOptions _0x0cef0681, TMP_FontAsset _0xd7e01b1b)
    {
        RectTransform _0x01fb932d = Node(_0xc8580443, _0x5a8ca032, _0x4cf52782, _0x852b7d36, _0x95a74c81);
        TextMeshProUGUI _0x3561cc08 = _0x01fb932d.gameObject.AddComponent<TextMeshProUGUI>();
        if (_0xd7e01b1b != null)
        {
            _0x3561cc08.font = _0xd7e01b1b;
        }

        _0x3561cc08.text = _0x1bf7b7da;
        _0x3561cc08.alignment = _0x0cef0681;
        _0x3561cc08.raycastTarget = false;
        _0x838bc0a6.ApplyLayout(_0x3561cc08, _0x56f9e4bd);
        _0x838bc0a6.ApplyOutline(_0x3561cc08, _0xae95b350);
        return _0x3561cc08;
    }

    public static void SetVisible(Component _0x6047feeb, bool _0x1f4bcb46)
    {
        if (_0x6047feeb != null && _0x6047feeb.gameObject.activeSelf != _0x1f4bcb46)
        {
            _0x6047feeb.gameObject.SetActive(_0x1f4bcb46);
        }
    }

    /// A 9-sliced plate. Stretching is its purpose, so no aspect is preserved.
    public static Image Plate(Transform _0x1e1e3307, string _0xe4089f4f, Vector2 _0xd7756047, Vector2 _0x1076d960, Vector2 _0x5caa94b4, Sprite _0x5915fbbf, Color _0x93e5caab)
    {
        RectTransform _0x336c633d = Node(_0x1e1e3307, _0xe4089f4f, _0xd7756047, _0x1076d960, _0x5caa94b4);
        Image _0x89e6d403 = _0x336c633d.gameObject.AddComponent<Image>();
        _0x89e6d403.sprite = _0x5915fbbf;
        _0x89e6d403.type = _0x5915fbbf != null ? Image.Type.Sliced : Image.Type.Simple;
        _0x89e6d403.pixelsPerUnitMultiplier = SliceScale(_0x5caa94b4);
        _0x89e6d403.color = _0x93e5caab;
        _0x89e6d403.raycastTarget = false;
        return _0x89e6d403;
    }

    /// A rect stretched over its whole parent. A host made with new GameObject(...)
    /// starts 100x100, and every child would then resolve its anchors against
    /// 100x100 instead of the panel - so this runs immediately after parenting.
    public static RectTransform Stretch(Transform _0xb4a6f788, string _0x6c2b72ba)
    {
        GameObject _0x31121e0f = new GameObject(_0x6c2b72ba, typeof(RectTransform));
        RectTransform _0x0082e084 = _0x31121e0f.GetComponent<RectTransform>();
        _0x0082e084.SetParent(_0xb4a6f788, false);
        _0x0082e084.anchorMin = Vector2.zero;
        _0x0082e084.anchorMax = Vector2.one;
        _0x0082e084.offsetMin = Vector2.zero;
        _0x0082e084.offsetMax = Vector2.zero;
        _0x0082e084.localScale = Vector3.one;
        return _0x0082e084;
    }

    /// Square icon button. The glyph is added after the fill, so it draws on top.
    public static Button IconAction(Transform _0x0c2dedb4, string _0x4be753c1, Vector2 _0x1e5fdc85, Vector2 _0xb9ded527, float _0x9c7bbafe, Sprite _0xfb0640fc, Color _0x6baa90ce, Sprite _0xd7ce9708, Color _0x2f835af1)
    {
        Button _0x71ac6ba5 = Action(_0x0c2dedb4, _0x4be753c1, _0x1e5fdc85, _0xb9ded527, new Vector2(_0x9c7bbafe, _0x9c7bbafe), _0xfb0640fc, _0x6baa90ce, string.Empty, _0x838bc0a6.UiFontFloor, _0xa8c1dd53.Cream, null);
        Picture(_0x71ac6ba5.transform, _0x4be753c1 + _0x64b5ff78._0x44aff708(new byte[6] { 101, 93, 86, 67, 74, 82 }, 58), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(_0x9c7bbafe * 0.52f, _0x9c7bbafe * 0.52f), _0xd7ce9708, _0x2f835af1);
        return _0x71ac6ba5;
    }

    public const float RefWidth = 1242f;
    /// Full-surface tap target. A fully transparent Image is culled by the
    /// raycaster, so it keeps a trace of alpha and its mesh alive.
    public static Image TapSurface(Transform _0x3c1c5182, string _0x937d7be1)
    {
        RectTransform _0x51ed1606 = Stretch(_0x3c1c5182, _0x937d7be1);
        Image _0x63e2091c = _0x51ed1606.gameObject.AddComponent<Image>();
        _0x63e2091c.color = new Color(0f, 0f, 0f, 0.004f);
        _0x63e2091c.raycastTarget = true;
        _0x63e2091c.canvasRenderer.cullTransparentMesh = false;
        return _0x63e2091c;
    }

    /// A bar that grows from nothing. Filled, not sliced: a 9-sliced fill whose
    /// width drops to zero collapses its own border into a smear.
    public static Image Bar(Transform _0x66e2a3f1, string _0x4b4d55bc, Vector2 _0x7a3e713a, Vector2 _0x796f1f3f, Vector2 _0x95217e85, Sprite _0x28a90ee6, Color _0x0dfc50bf)
    {
        RectTransform _0xcc5a7aaf = Node(_0x66e2a3f1, _0x4b4d55bc, _0x7a3e713a, _0x796f1f3f, _0x95217e85);
        Image _0x1ff9c3f3 = _0xcc5a7aaf.gameObject.AddComponent<Image>();
        _0x1ff9c3f3.sprite = _0x28a90ee6;
        _0x1ff9c3f3.type = Image.Type.Filled;
        _0x1ff9c3f3.fillMethod = Image.FillMethod.Horizontal;
        _0x1ff9c3f3.fillOrigin = 0;
        _0x1ff9c3f3.fillAmount = 0f;
        _0x1ff9c3f3.color = _0x0dfc50bf;
        _0x1ff9c3f3.raycastTarget = false;
        return _0x1ff9c3f3;
    }

    /// A rect whose anchors collapse to one point, so its size is exactly what is
    /// written here and is never inherited from a stretching parent.
    public static RectTransform Node(Transform _0x7b41efc8, string _0xfd6e2700, Vector2 _0x1b70c9aa, Vector2 _0x01ada113, Vector2 _0x50a7f02f)
    {
        GameObject _0x83263ba3 = new GameObject(_0xfd6e2700, typeof(RectTransform));
        RectTransform _0xf2ea5ac7 = _0x83263ba3.GetComponent<RectTransform>();
        _0xf2ea5ac7.SetParent(_0x7b41efc8, false);
        _0xf2ea5ac7.anchorMin = _0x1b70c9aa;
        _0xf2ea5ac7.anchorMax = _0x1b70c9aa;
        _0xf2ea5ac7.pivot = new Vector2(0.5f, 0.5f);
        _0xf2ea5ac7.anchoredPosition = _0x01ada113;
        _0xf2ea5ac7.sizeDelta = _0x50a7f02f;
        _0xf2ea5ac7.localScale = Vector3.one;
        return _0xf2ea5ac7;
    }

    /// Content art: the sprite keeps its own proportions whatever box it is given.
    public static Image Picture(Transform _0x6e968810, string _0xd2645bd4, Vector2 _0xc90f887c, Vector2 _0x0e707faf, Vector2 _0xe388aec4, Sprite _0xcf8d6826, Color _0x524fea58)
    {
        RectTransform _0xf705ab29 = Node(_0x6e968810, _0xd2645bd4, _0xc90f887c, _0x0e707faf, _0xe388aec4);
        Image _0x111ccf38 = _0xf705ab29.gameObject.AddComponent<Image>();
        _0x111ccf38.sprite = _0xcf8d6826;
        _0x111ccf38.type = Image.Type.Simple;
        _0x111ccf38.preserveAspect = true;
        _0x111ccf38.color = _0x524fea58;
        _0x111ccf38.raycastTarget = false;
        return _0x111ccf38;
    }

    /// Corner radius of a 9-sliced plate: the higher the multiplier the smaller the
    /// drawn border and the sharper the corner. The floor is size aware, so the two
    /// borders of a small plate never meet in its middle and smear it.
    public static float SliceScale(Vector2 _0xdc6405ab)
    {
        float _0x54913956 = Mathf.Max(1f, Mathf.Min(_0xdc6405ab.x, _0xdc6405ab.y));
        return Mathf.Max(1.5f, 230f / _0x54913956);
    }

    /// A pressable surface. The fill is both the press target and the visible face,
    /// so the button's colour tint actually shows; pointing the target graphic at a
    /// transparent hit layer would give no press feedback at all.
    public static Button Action(Transform _0xf8083948, string _0x87501479, Vector2 _0x68d4e416, Vector2 _0x3954a0db, Vector2 _0x1da24211, Sprite _0x61cc8c79, Color _0x874e8545, string _0x13f4da81, float _0x248c4dfd, Color _0x17762f80, TMP_FontAsset _0xb66e6be6)
    {
        RectTransform _0x3fbac6e6 = Node(_0xf8083948, _0x87501479, _0x68d4e416, _0x3954a0db, _0x1da24211);
        Image _0x243dd4d3 = _0x3fbac6e6.gameObject.AddComponent<Image>();
        _0x243dd4d3.sprite = _0x61cc8c79;
        _0x243dd4d3.type = _0x61cc8c79 != null ? Image.Type.Sliced : Image.Type.Simple;
        _0x243dd4d3.pixelsPerUnitMultiplier = SliceScale(_0x1da24211);
        _0x243dd4d3.color = _0x874e8545;
        _0x243dd4d3.raycastTarget = true;
        _0x243dd4d3.canvasRenderer.cullTransparentMesh = false;
        Button _0x206a78eb = _0x3fbac6e6.gameObject.AddComponent<Button>();
        _0x206a78eb.targetGraphic = _0x243dd4d3;
        ColorBlock _0x5821d551 = _0x206a78eb.colors;
        _0x5821d551.normalColor = Color.white;
        _0x5821d551.highlightedColor = Color.white;
        _0x5821d551.pressedColor = new Color(0.68f, 0.68f, 0.68f, 1f);
        _0x5821d551.selectedColor = Color.white;
        _0x5821d551.disabledColor = new Color(0.5f, 0.5f, 0.5f, 0.6f);
        _0x5821d551.colorMultiplier = 1f;
        _0x5821d551.fadeDuration = 0.08f;
        _0x206a78eb.colors = _0x5821d551;
        if (!string.IsNullOrEmpty(_0x13f4da81))
        {
            Caption(_0x3fbac6e6, _0x87501479 + _0x64b5ff78._0x44aff708(new byte[5] { 115, 88, 73, 84, 88 }, 44), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(_0x1da24211.x - 44f, _0x1da24211.y - 26f), _0x13f4da81, _0x248c4dfd, _0x17762f80, TextAlignmentOptions.Center, _0xb66e6be6);
        }

        return _0x206a78eb;
    }
}

internal static class _0x64b5ff78
{
    internal static string _0x44aff708(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}