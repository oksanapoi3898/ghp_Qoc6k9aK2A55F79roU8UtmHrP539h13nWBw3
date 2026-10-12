using TMPro;
using UnityEngine;

/// Outline and layout discipline for every label this game builds in code.
///
/// The shared font material carries ONE outline colour for the whole app, so a
/// label whose face is close to that colour turns into a blob. Reading
/// fontMaterial creates a per-label instance, which lets each label pick a rim
/// against its own face while the shared asset stays untouched (rule C.10/C.14).
///
/// Word wrap is off and every break is an explicit escape inside the string:
/// autowrap gives a different number of lines per device, and the layout under it
/// moves. Autosize is always on, with its floor at the readability minimum - that
/// floor is the size that really ships, because a line that does not fit shrinks
/// to exactly it (rule C.12).
public static class _0x838bc0a6
{
    /// Readability floor in canvas reference pixels.
    public const float UiFontFloor = 32f;
    public static void ApplyOutline(TMP_Text _0xc6107ef6, Color _0x2ed0a565)
    {
        if (_0xc6107ef6 == null)
        {
            return;
        }

        _0xc6107ef6.color = _0x2ed0a565;
        float _0x84c19a8f = (0.299f * _0x2ed0a565.r) + (0.587f * _0x2ed0a565.g) + (0.114f * _0x2ed0a565.b);
        Color _0xed865480 = _0x84c19a8f < 0.5f ? _0xa8c1dd53.Cream : _0xa8c1dd53.Ink;
        Material _0x0075b779 = _0xc6107ef6.fontMaterial;
        if (_0x0075b779 == null)
        {
            return;
        }

        _0x0075b779.EnableKeyword(ShaderUtilities.Keyword_Outline);
        _0x0075b779.SetColor(ShaderUtilities.ID_OutlineColor, _0xed865480);
        _0x0075b779.SetFloat(ShaderUtilities.ID_OutlineWidth, 0.22f);
        _0x0075b779.SetFloat(ShaderUtilities.ID_FaceDilate, 0.18f);
    }

    public static void ApplyLayout(TMP_Text _0x2d61a3ec, float _0x7cc2d37c)
    {
        if (_0x2d61a3ec == null)
        {
            return;
        }

        _0x2d61a3ec.textWrappingMode = TextWrappingModes.NoWrap;
        _0x2d61a3ec.overflowMode = TextOverflowModes.Overflow;
        _0x2d61a3ec.enableAutoSizing = true;
        _0x2d61a3ec.fontSizeMin = UiFontFloor;
        _0x2d61a3ec.fontSizeMax = Mathf.Max(UiFontFloor, _0x7cc2d37c);
        _0x2d61a3ec.fontSize = Mathf.Max(UiFontFloor, _0x7cc2d37c);
    }
}