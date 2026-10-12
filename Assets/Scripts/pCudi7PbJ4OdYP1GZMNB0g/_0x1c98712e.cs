using UnityEngine;

/// Draws one attempt at an order and PROVES it before handing it over.
///
/// Two properties have to hold at once and neither is left to luck:
///   survivable - a player who never touches the screen reaches the clock, not the
///                fifth spill, because the awkward fruits are placed so the fifth
///                of them lands past the sixty-five second floor (rule C.5);
///   deliverable - a player who catches everything fills all four orders with time
///                to spare, so the goal is not unreachable by construction.
/// Both are measured by simulating the plan with exactly the rules the run uses -
/// the same ResolveChallenge method feeds the live round and both simulations, so
/// the length proved here is the length that ships.
public sealed class _0x1c98712e
{
    /// When a player who catches every fruit fills all four orders, or 0 if the
    /// order cannot be delivered inside its clock at all. The greedy player parks
    /// the bowl the order still needs most under the chute before each release.
    public float _0x47c51849(_0xf49241c8 _0x54a59c27)
    {
        _0x42e2125f _0x912e6cf5 = _0x8b743421.Order(_0x54a59c27.OrderIndex);
        float _0xb7867221 = _0x8b743421.FallSeconds(_0x54a59c27.OrderIndex);
        int[] _0x31fc03d8 = new int[_0x8b743421.CourtColours];
        int _0x15f1b85c = 0;
        int _0xa4ba5912 = 0;
        float _0x214397be = _0x912e6cf5.ClockSeconds;
        for (int _0xb3b27f10 = 0; _0xb3b27f10 < _0x54a59c27._0xce908f6b; _0xb3b27f10++)
        {
            float _0xc46a673c = _0x54a59c27.ReleaseAt[_0xb3b27f10] + _0xb7867221;
            if (_0xc46a673c > _0x214397be)
            {
                return 0f;
            }

            int _0xb66e1254 = Neediest(_0x31fc03d8, _0x54a59c27.TargetByColour);
            int _0xa6388484 = _0x54a59c27.Steps[_0xb3b27f10].IsGift ? _0xb66e1254 : ResolveChallenge(_0x54a59c27.Steps[_0xb3b27f10].PreferredColour, _0xb66e1254, _0x31fc03d8, _0x54a59c27.TargetByColour);
            _0xa4ba5912++;
            if (_0x31fc03d8[_0xa6388484] < _0x54a59c27.TargetByColour[_0xa6388484])
            {
                _0x31fc03d8[_0xa6388484]++;
                _0x15f1b85c++;
            }

            if (_0xa4ba5912 % _0x8b743421.FavourStreak == 0)
            {
                _0x214397be += _0x8b743421.FavourSeconds;
            }

            if (_0x15f1b85c >= _0x54a59c27._0x52e008ba)
            {
                return _0xc46a673c <= _0x214397be - DeliveryMarginSeconds ? _0xc46a673c : 0f;
            }
        }

        return 0f;
    }

    private const float IntervalJitter = 0.25f;
    /// Five awkward fruits inside the opening stretch, the last of them exactly at
    /// the proven index, then a steady cadence afterwards. The gaps in between are
    /// drawn, so no two attempts feel the same, but their sum is fixed.
    private bool[] _0xc82f6ac8(System.Random _0x10f5f3f4, int _0x1f59bb42, int _0x82a4ca97)
    {
        bool[] _0xb94a342a = new bool[_0x82a4ca97];
        int _0xf920554c = _0x1f59bb42 - FirstChallengeIndex - (MinChallengeGap * (_0x8b743421.SpillBudget - 1));
        int[] _0xc54836fb = new int[_0x8b743421.SpillBudget];
        for (int _0xd90ea261 = 0; _0xd90ea261 < _0xf920554c; _0xd90ea261++)
        {
            _0xc54836fb[_0x10f5f3f4.Next(_0x8b743421.SpillBudget)]++;
        }

        int _0x02309fa6 = FirstChallengeIndex + _0xc54836fb[0];
        for (int _0x754b2e7e = 0; _0x754b2e7e < _0x8b743421.SpillBudget; _0x754b2e7e++)
        {
            if (_0x754b2e7e > 0)
            {
                _0x02309fa6 += MinChallengeGap + _0xc54836fb[_0x754b2e7e];
            }

            if (_0x02309fa6 >= 0 && _0x02309fa6 < _0x82a4ca97)
            {
                _0xb94a342a[_0x02309fa6] = true;
            }
        }

        for (int _0x77110bef = _0x02309fa6 + LateChallengeGap; _0x77110bef < _0x82a4ca97; _0x77110bef += LateChallengeGap)
        {
            _0xb94a342a[_0x77110bef] = true;
        }

        return _0xb94a342a;
    }

    /// Index of the fifth awkward fruit that still lands past the survival floor.
    /// Every interval is at least the order's drop interval (the jitter only ever
    /// adds), so this bound holds for any jittered schedule built on top of it.
    public static int FifthChallengeIndex(int _0x26da0048)
    {
        _0x42e2125f _0x75ebb75c = _0x8b743421.Order(_0x26da0048);
        float _0x84af0e1c = _0x8b743421.SurvivalFloorSeconds + 1f - _0x8b743421.OpeningDelaySeconds - _0x8b743421.FallSeconds(_0x26da0048);
        int _0xe4c9f7fc = Mathf.CeilToInt(_0x84af0e1c / _0x75ebb75c.DropInterval);
        int _0x7597cb61 = FirstChallengeIndex + (MinChallengeGap * (_0x8b743421.SpillBudget - 1));
        return Mathf.Max(_0xe4c9f7fc, _0x7597cb61);
    }

    public _0xf49241c8 _0xa33b9e6a(int _0xa37cb5bc, int _0x12105d4b)
    {
        int _0x012f7755 = (_0xa37cb5bc * 7919) ^ (_0x12105d4b * 104729);
        System.Random _0xaf1c250f = new System.Random(_0x012f7755);
        for (int _0x3a782195 = 0; _0x3a782195 < DrawAttempts; _0x3a782195++)
        {
            _0xf49241c8 _0xb70fac25 = this._0x5b7dc687(_0xaf1c250f, _0xa37cb5bc, _0x012f7755);
            float _0x814240ce = this._0xd67a30d8(_0xb70fac25);
            float _0x7cb5d936 = this._0x47c51849(_0xb70fac25);
            if (_0x814240ce >= _0x8b743421.SurvivalFloorSeconds && _0x7cb5d936 > 0f)
            {
                _0xb70fac25.PassiveEndSeconds = _0x814240ce;
                _0xb70fac25.GreedyWinSeconds = _0x7cb5d936;
                return _0xb70fac25;
            }
        }

        _0xf49241c8 _0xcb640638 = this._0x3363dda7(_0xa37cb5bc, _0x012f7755);
        _0xcb640638.PassiveEndSeconds = this._0xd67a30d8(_0xcb640638);
        _0xcb640638.GreedyWinSeconds = this._0x47c51849(_0xcb640638);
        return _0xcb640638;
    }

    private const int DrawAttempts = 20;
    private _0xf49241c8 _0x5b7dc687(System.Random _0x33ccd919, int _0xdb326503, int _0x2acb5fe8)
    {
        _0x42e2125f _0x7cfeb947 = _0x8b743421.Order(_0xdb326503);
        _0xf49241c8 _0x9db5ced4 = new _0xf49241c8();
        _0x9db5ced4.Seed = _0x2acb5fe8;
        _0x9db5ced4.OrderIndex = _0xdb326503;
        int[] _0x287d503a =
        {
            0,
            1,
            2,
            3
        };
        Shuffle(_0x33ccd919, _0x287d503a);
        _0x9db5ced4.ColourAtRing = _0x287d503a;
        _0x9db5ced4.StartCatchIndex = _0x33ccd919.Next(_0x8b743421.CourtColours);
        int[] _0x5d6b46cd = new int[_0x7cfeb947.Targets.Length];
        for (int _0xfdfc4d7f = 0; _0xfdfc4d7f < _0x5d6b46cd.Length; _0xfdfc4d7f++)
        {
            _0x5d6b46cd[_0xfdfc4d7f] = _0x7cfeb947.Targets[_0xfdfc4d7f];
        }

        Shuffle(_0x33ccd919, _0x5d6b46cd);
        _0x9db5ced4.TargetByColour = _0x5d6b46cd;
        int _0x0522351d = FifthChallengeIndex(_0xdb326503);
        int _0x613618c1 = Mathf.CeilToInt(_0x7cfeb947.ClockSeconds / _0x7cfeb947.DropInterval) + 12;
        bool[] _0x3f27c2ec = this._0xc82f6ac8(_0x33ccd919, _0x0522351d, _0x613618c1);
        _0x9db5ced4.Steps = new _0x690d41a8[_0x613618c1];
        _0x9db5ced4.ReleaseAt = new float[_0x613618c1];
        float _0xc7f78b9d = _0x8b743421.OpeningDelaySeconds;
        for (int _0xa27a7a0a = 0; _0xa27a7a0a < _0x613618c1; _0xa27a7a0a++)
        {
            _0x690d41a8 step = new _0x690d41a8();
            step.IsGift = !_0x3f27c2ec[_0xa27a7a0a];
            step.PreferredColour = _0x33ccd919.Next(_0x8b743421.CourtColours);
            step.Interval = _0x7cfeb947.DropInterval + ((float)_0x33ccd919.NextDouble() * IntervalJitter);
            _0x9db5ced4.Steps[_0xa27a7a0a] = step;
            _0x9db5ced4.ReleaseAt[_0xa27a7a0a] = _0xc7f78b9d;
            _0xc7f78b9d += step.Interval;
        }

        return _0x9db5ced4;
    }

    private static void Shuffle(System.Random _0xb990c526, int[] _0x053f5d93)
    {
        for (int _0xcffaaab7 = _0x053f5d93.Length - 1; _0xcffaaab7 > 0; _0xcffaaab7--)
        {
            int _0xb359789e = _0xb990c526.Next(_0xcffaaab7 + 1);
            int _0xa8863bda = _0x053f5d93[_0xcffaaab7];
            _0x053f5d93[_0xcffaaab7] = _0x053f5d93[_0xb359789e];
            _0x053f5d93[_0xb359789e] = _0xa8863bda;
        }
    }

    private const int LateChallengeGap = 3;
    private const int MinChallengeGap = 3;
    public static int Neediest(int[] _0x4cf17ed4, int[] _0xc47be054)
    {
        int _0x811eb753 = 0;
        int _0x812a5321 = -1;
        for (int _0x5c042bf8 = 0; _0x5c042bf8 < _0xc47be054.Length; _0x5c042bf8++)
        {
            int _0x1ba74403 = _0xc47be054[_0x5c042bf8] - _0x4cf17ed4[_0x5c042bf8];
            if (_0x1ba74403 > _0x812a5321)
            {
                _0x812a5321 = _0x1ba74403;
                _0x811eb753 = _0x5c042bf8;
            }
        }

        return _0x811eb753;
    }

    private const float DeliveryMarginSeconds = 6f;
    /// The hard-wired pattern used when twenty draws all failed. No jitter, even
    /// gaps, colours in catalogue order - plain, but proven by the same two
    /// simulations before it is handed over.
    private _0xf49241c8 _0x3363dda7(int _0xeb9cbde7, int _0x47a8be2b)
    {
        _0x42e2125f _0xcc0cadaf = _0x8b743421.Order(_0xeb9cbde7);
        _0xf49241c8 _0xfe6f3123 = new _0xf49241c8();
        _0xfe6f3123.Seed = _0x47a8be2b;
        _0xfe6f3123.OrderIndex = _0xeb9cbde7;
        _0xfe6f3123.IsFallback = true;
        _0xfe6f3123.ColourAtRing = new[]
        {
            0,
            1,
            2,
            3
        };
        _0xfe6f3123.StartCatchIndex = 0;
        int[] _0x5680e4c2 = new int[_0xcc0cadaf.Targets.Length];
        for (int _0x3362adef = 0; _0x3362adef < _0x5680e4c2.Length; _0x3362adef++)
        {
            _0x5680e4c2[_0x3362adef] = _0xcc0cadaf.Targets[_0x3362adef];
        }

        _0xfe6f3123.TargetByColour = _0x5680e4c2;
        int _0xa51b7778 = FifthChallengeIndex(_0xeb9cbde7);
        int _0xa47718de = Mathf.CeilToInt(_0xcc0cadaf.ClockSeconds / _0xcc0cadaf.DropInterval) + 12;
        int _0xf1effc71 = Mathf.Max(MinChallengeGap, _0xa51b7778 / _0x8b743421.SpillBudget);
        _0xfe6f3123.Steps = new _0x690d41a8[_0xa47718de];
        _0xfe6f3123.ReleaseAt = new float[_0xa47718de];
        float _0xa73022fa = _0x8b743421.OpeningDelaySeconds;
        for (int _0xa1d89057 = 0; _0xa1d89057 < _0xa47718de; _0xa1d89057++)
        {
            _0x690d41a8 step = new _0x690d41a8();
            bool _0xf3e2b8a8 = _0xa1d89057 <= _0xa51b7778;
            bool _0x7ab9e002 = _0xf3e2b8a8 ? (_0xa1d89057 > 0 && _0xa1d89057 % _0xf1effc71 == 0 && _0xa1d89057 >= FirstChallengeIndex) : (_0xa1d89057 % LateChallengeGap == 0);
            if (_0xf3e2b8a8 && _0xa1d89057 < _0xa51b7778 && (_0xa1d89057 / _0xf1effc71) >= _0x8b743421.SpillBudget)
            {
                _0x7ab9e002 = false;
            }

            step.IsGift = !_0x7ab9e002;
            step.PreferredColour = _0xa1d89057 % _0x8b743421.CourtColours;
            step.Interval = _0xcc0cadaf.DropInterval;
            _0xfe6f3123.Steps[_0xa1d89057] = step;
            _0xfe6f3123.ReleaseAt[_0xa1d89057] = _0xa73022fa;
            _0xa73022fa += step.Interval;
        }

        return _0xfe6f3123;
    }

    /// When a player who never touches the screen runs out. The bowl under the
    /// chute never moves, so every gift is caught and every awkward fruit spills.
    public float _0xd67a30d8(_0xf49241c8 _0x6f0f6d36)
    {
        _0x42e2125f _0x68a9f79c = _0x8b743421.Order(_0x6f0f6d36.OrderIndex);
        float _0x00a8f532 = _0x8b743421.FallSeconds(_0x6f0f6d36.OrderIndex);
        int _0x47da1ab9 = _0x6f0f6d36._0x9c5ac2ed(_0x6f0f6d36.StartCatchIndex);
        int[] _0xdd5625b2 = new int[_0x8b743421.CourtColours];
        int _0x0deff0e0 = 0;
        int _0x753eff3a = 0;
        float _0x5759a3f5 = _0x68a9f79c.ClockSeconds;
        for (int _0x6b4abc35 = 0; _0x6b4abc35 < _0x6f0f6d36._0xce908f6b; _0x6b4abc35++)
        {
            float _0xd21a2dee = _0x6f0f6d36.ReleaseAt[_0x6b4abc35] + _0x00a8f532;
            if (_0xd21a2dee > _0x5759a3f5)
            {
                return _0x5759a3f5;
            }

            if (_0x6f0f6d36.Steps[_0x6b4abc35].IsGift)
            {
                _0x753eff3a++;
                if (_0xdd5625b2[_0x47da1ab9] < _0x6f0f6d36.TargetByColour[_0x47da1ab9])
                {
                    _0xdd5625b2[_0x47da1ab9]++;
                }

                if (_0x753eff3a % _0x8b743421.PardonStreak == 0 && _0x0deff0e0 > 0)
                {
                    _0x0deff0e0--;
                }

                if (_0x753eff3a % _0x8b743421.FavourStreak == 0)
                {
                    _0x5759a3f5 += _0x8b743421.FavourSeconds;
                }
            }
            else
            {
                _0x0deff0e0++;
                _0x753eff3a = 0;
                if (_0x0deff0e0 >= _0x8b743421.SpillBudget)
                {
                    return _0xd21a2dee;
                }
            }
        }

        return _0x5759a3f5;
    }

    private const int FirstChallengeIndex = 3;
    /// The one rule that decides what an awkward fruit carries. Used by the live
    /// round and by both simulations, so they can never disagree.
    public static int ResolveChallenge(int _0x1e72525d, int _0x03665e2d, int[] _0xfb66e529, int[] _0x0aef87a6)
    {
        int _0x837e0905 = _0x8b743421.CourtColours;
        for (int _0x8835b213 = 0; _0x8835b213 < _0x837e0905; _0x8835b213++)
        {
            int _0xc52ad9d6 = (_0x1e72525d + _0x8835b213) % _0x837e0905;
            if (_0xc52ad9d6 != _0x03665e2d && _0xfb66e529[_0xc52ad9d6] < _0x0aef87a6[_0xc52ad9d6])
            {
                return _0xc52ad9d6;
            }
        }

        for (int _0x47c5df02 = 0; _0x47c5df02 < _0x837e0905; _0x47c5df02++)
        {
            int _0x397c0d8f = (_0x1e72525d + _0x47c5df02) % _0x837e0905;
            if (_0x397c0d8f != _0x03665e2d)
            {
                return _0x397c0d8f;
            }
        }

        return (_0x03665e2d + 1) % _0x837e0905;
    }
}