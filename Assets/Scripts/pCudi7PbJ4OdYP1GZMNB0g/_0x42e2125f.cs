using UnityEngine;

/// One order of the royal table: how many fruits of each colour it asks for, how
/// fast the chute works and how long the court will wait.
public sealed class _0x42e2125f
{
    public int[] Targets;
    public float DropInterval;
    public float FallSeconds;
    public string Title;
    public string Subtitle;
    public float ClockSeconds;
}

/// The three orders the menu offers. Numbers are balance, so they live in one
/// place and both the menu preview and the run read them from here.
///
/// Every clock is well past the sixty second floor a review capture needs, and
/// the schedule generator proves the rest: a player who never touches the screen
/// still reaches the clock rather than the fifth spill (rule C.5).
public static class _0x8b743421
{
    /// The run has to stay alive for at least this long with no successful action
    /// at all. The schedule generator places the fifth let-through fruit past it.
    public const float SurvivalFloorSeconds = 72f;
    public const int PardonStreak = 6;
    /// The chute waits this long before the first fruit, so the opening frame of
    /// the run shows the board rather than a fruit already halfway down.
    public const float OpeningDelaySeconds = 1.2f;
    public static Color Readable(int _0x5aea12cc)
    {
        return _0xa8c1dd53.CourtText(_0x5aea12cc);
    }

    public static int Wrap(int _0xe47b6ec3)
    {
        return ((_0xe47b6ec3 % _0x0c900dba.Length) + _0x0c900dba.Length) % _0x0c900dba.Length;
    }

    /// How long a fruit is in the air. This is a DURATION, not a speed: the board
    /// divides its own measured drop height by it, so the balance holds on every
    /// aspect even though the distance in world units does not.
    public static float FallSeconds(int _0x59803288)
    {
        return Order(_0x59803288).FallSeconds;
    }

    public static Color Tint(int _0xbddcc9a7)
    {
        return _0xa8c1dd53.Court(_0xbddcc9a7);
    }

    private static readonly _0x42e2125f[] _0x0c900dba =
    {
        new _0x42e2125f
        {
            Title = _0x21b9a879._0x2bb5f17c(new byte[5] { 113, 125, 103, 96, 102 }, 50),
            Subtitle = _0x21b9a879._0x2bb5f17c(new byte[18] { 183, 184, 189, 189, 209, 197, 209, 190, 163, 181, 180, 163, 162, 209, 190, 183, 209, 197 }, 241),
            Targets = new[]
            {
                4,
                4,
                4,
                4
            },
            FallSeconds = 1.92f,
            DropInterval = 3.4f,
            ClockSeconds = 95f
        },
        new _0x42e2125f
        {
            Title = _0x21b9a879._0x2bb5f17c(new byte[5] { 65, 66, 70, 84, 83 }, 7),
            Subtitle = _0x21b9a879._0x2bb5f17c(new byte[18] { 6, 9, 12, 12, 96, 116, 96, 15, 18, 4, 5, 18, 19, 96, 15, 6, 96, 117 }, 64),
            Targets = new[]
            {
                5,
                5,
                5,
                5
            },
            FallSeconds = 1.65f,
            DropInterval = 3f,
            ClockSeconds = 100f
        },
        new _0x42e2125f
        {
            Title = _0x21b9a879._0x2bb5f17c(new byte[10] { 136, 132, 153, 132, 133, 138, 159, 130, 132, 133 }, 203),
            Subtitle = _0x21b9a879._0x2bb5f17c(new byte[24] { 182, 185, 188, 188, 208, 196, 208, 191, 162, 180, 181, 162, 163, 208, 191, 182, 208, 198, 208, 177, 190, 180, 208, 197 }, 240),
            Targets = new[]
            {
                6,
                6,
                5,
                5
            },
            FallSeconds = 1.44f,
            DropInterval = 2.7f,
            ClockSeconds = 110f
        }
    };
    public static int ClampColour(int _0xc4b8786e)
    {
        return Mathf.Clamp(_0xc4b8786e, 0, CourtColours - 1);
    }

    public static _0x42e2125f Order(int _0x3ae8bcff)
    {
        int _0xec6b0d90 = ((_0x3ae8bcff % _0x0c900dba.Length) + _0x0c900dba.Length) % _0x0c900dba.Length;
        return _0x0c900dba[_0xec6b0d90];
    }

    public const int CourtColours = 4;
    /// Catches in a row that earn more time, and the longer run that wipes a spill.
    public const int FavourStreak = 3;
    /// The name of a court colour, used by the gauges and the result cards.
    public static string ColourName(int _0xe7697852)
    {
        int _0x9f98877a = ((_0xe7697852 % CourtColours) + CourtColours) % CourtColours;
        if (_0x9f98877a == 0)
        {
            return _0x21b9a879._0x2bb5f17c(new byte[4] { 71, 91, 66, 90 }, 23);
        }

        if (_0x9f98877a == 1)
        {
            return _0x21b9a879._0x2bb5f17c(new byte[4] { 102, 115, 119, 100 }, 54);
        }

        if (_0x9f98877a == 2)
        {
            return _0x21b9a879._0x2bb5f17c(new byte[6] { 248, 243, 254, 233, 233, 226 }, 187);
        }

        return _0x21b9a879._0x2bb5f17c(new byte[4] { 250, 255, 251, 243 }, 182);
    }

    /// Spills allowed before the court leaves the table.
    public const int SpillBudget = 5;
    public const float FavourSeconds = 4f;
    public static int _0xeba19757
    {
        get
        {
            return _0x0c900dba.Length;
        }
    }

    public static int TotalFruits(int _0xd10b4541)
    {
        int[] _0xc7ff5483 = Order(_0xd10b4541).Targets;
        int _0xb0097050 = 0;
        for (int _0x73ebd954 = 0; _0x73ebd954 < _0xc7ff5483.Length; _0x73ebd954++)
        {
            _0xb0097050 += _0xc7ff5483[_0x73ebd954];
        }

        return _0xb0097050;
    }
}

internal static class _0x21b9a879
{
    internal static string _0x2bb5f17c(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}