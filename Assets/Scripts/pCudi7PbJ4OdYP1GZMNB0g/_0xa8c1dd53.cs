using UnityEngine;

/// The single palette every screen reads from: splash, menu, run, result cards and
/// the world sprites. One place, so the menu and the run can never drift apart.
///
/// Fill colours and text colours are not interchangeable. Every label is drawn with
/// a dark rim (see TextReadability), so a dark face colour would sink into its own
/// outline: Plum is a fill only, and PlumText is the lightened stand-in used
/// wherever that colour has to be spelled out in words.
public static class _0xa8c1dd53
{
    /// #2A2150 - raised edge, empty gauge, loading track.
    public static readonly Color SurfaceEdge = new Color(0.165f, 0.129f, 0.314f, 1f);
    /// #F4C646 - the crown accent: frames, the primary action, the pear.
    public static readonly Color Gold = new Color(0.957f, 0.776f, 0.275f, 1f);
    /// The same four colours in their readable form, for counters and captions.
    public static Color CourtText(int _0x674164e8)
    {
        int _0xd0e75136 = ((_0x674164e8 % 4) + 4) % 4;
        if (_0xd0e75136 == 0)
        {
            return PlumText;
        }

        if (_0xd0e75136 == 1)
        {
            return Gold;
        }

        if (_0xd0e75136 == 2)
        {
            return Crimson;
        }

        return Green;
    }

    /// #FFF1DC - the default text colour.
    public static readonly Color Cream = new Color(1f, 0.945f, 0.863f, 1f);
    public static Color WithAlpha(Color _0xd875b4ac, float _0x16314dbe)
    {
        return new Color(_0xd875b4ac.r, _0xd875b4ac.g, _0xd875b4ac.b, _0x16314dbe);
    }

    /// #8742B7 - the plum bowl and the plum fruit. FILL ONLY, never a text colour.
    public static readonly Color Plum = new Color(0.529f, 0.259f, 0.718f, 1f);
    /// #221B3E - card and chip body.
    public static readonly Color Surface = new Color(0.133f, 0.106f, 0.243f, 1f);
    /// #64BA50 - the lime, and a gauge that has reached its order.
    public static readonly Color Green = new Color(0.392f, 0.729f, 0.314f, 1f);
    /// #E94D64 - the cherry, a spent spill pip, the closing seconds of the clock.
    public static readonly Color Crimson = new Color(0.914f, 0.302f, 0.392f, 1f);
    /// The four court colours, in the order the gauges and the ring use them.
    /// Index 0 plum, 1 gold, 2 crimson, 3 lime.
    public static Color Court(int _0xa93e303c)
    {
        int _0x62929278 = ((_0xa93e303c % 4) + 4) % 4;
        if (_0x62929278 == 0)
        {
            return Plum;
        }

        if (_0x62929278 == 1)
        {
            return Gold;
        }

        if (_0x62929278 == 2)
        {
            return Crimson;
        }

        return Green;
    }

    /// #9A8FC0 - secondary captions.
    public static readonly Color Muted = new Color(0.604f, 0.561f, 0.753f, 1f);
    /// The loading track: indigo at an alpha that is actually visible.
    public static readonly Color TrackDark = new Color(0.165f, 0.129f, 0.314f, 1f);
    /// #B98CE6 - lightened plum: the readable form of that colour.
    public static readonly Color PlumText = new Color(0.725f, 0.549f, 0.902f, 1f);
    /// #120F24 - the rim colour of every label, and the darkest surface.
    public static readonly Color Ink = new Color(0.071f, 0.059f, 0.141f, 1f);
    /// #1A1630 - deep royal indigo, the base of both scenes.
    public static readonly Color Night = new Color(0.102f, 0.086f, 0.188f, 1f);
}