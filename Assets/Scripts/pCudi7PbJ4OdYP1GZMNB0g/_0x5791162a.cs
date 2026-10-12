using UnityEngine;

/// The handful of values that outlive one run: which order the player picked, how
/// many attempts they have made (the schedule seed is built from it, so every
/// attempt differs) and the best series the court has seen.
///
/// The best series is kept in the template's own purse value, which is what the
/// BEST plate reads - one number, one place, no second store to drift out of sync.
public sealed class _0x5791162a
{
    public int _0x7fbf72ca
    {
        get
        {
            int _0x6ca9522d = PlayerPrefs.GetInt(OrderKey, 0);
            return _0x8b743421.Wrap(_0x6ca9522d);
        }

        set
        {
            PlayerPrefs.SetInt(OrderKey, _0x8b743421.Wrap(value));
            PlayerPrefs.Save();
        }
    }

    public int _0x3124f0c2
    {
        get
        {
            return _0xd21d76d7._0x80e81cfa._0xdd26d0ea;
        }
    }

    /// A fresh attempt number for the next run. Two runs of the same order never
    /// share a seed, so the colours never sit the same way twice (rule C.11).
    public int _0x2b1da208()
    {
        int _0x2edf1c13 = PlayerPrefs.GetInt(AttemptKey, 0) + 1;
        PlayerPrefs.SetInt(AttemptKey, _0x2edf1c13);
        PlayerPrefs.Save();
        return _0x2edf1c13;
    }

    public void _0x69e744a1(int _0xe76e58ec)
    {
        if (_0xe76e58ec > _0xd21d76d7._0x80e81cfa._0xdd26d0ea)
        {
            _0xd21d76d7._0x80e81cfa._0xdd26d0ea = _0xe76e58ec;
        }
    }

    private static readonly string AttemptKey = _0xa386ca2d._0xad642924(new byte[12] { 185, 136, 149, 141, 148, 187, 142, 142, 159, 151, 138, 142 }, 250);
    private static readonly string OrderKey = _0xa386ca2d._0xad642924(new byte[15] { 143, 190, 163, 187, 162, 131, 190, 168, 169, 190, 133, 162, 168, 169, 180 }, 204);
}

internal static class _0xa386ca2d
{
    internal static string _0xad642924(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}