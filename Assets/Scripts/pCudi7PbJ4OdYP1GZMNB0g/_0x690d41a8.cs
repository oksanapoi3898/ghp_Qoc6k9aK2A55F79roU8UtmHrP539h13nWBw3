/// One scheduled fruit. A GIFT carries whatever colour sits under the chute at the
/// moment it is released - the kitchen serves the bowl you offered it. A challenge
/// deliberately carries a different colour, and the ring has to be turned for it.
public sealed class _0x690d41a8
{
    public bool IsGift;
    public float Interval;
    public int PreferredColour;
}

/// Everything one attempt at an order is made of. Built by DropScheduleGenerator
/// from a seed, so two neighbouring attempts differ in where the colours sit on
/// the ring, which bowl starts under the chute, which colour each gauge asks for
/// and when the awkward fruits arrive - not in a single number on the HUD
/// (rule C.11).
public sealed class _0xf49241c8
{
    public _0x690d41a8[] Steps = new _0x690d41a8[0];
    public int Seed;
    public float GreedyWinSeconds;
    public int _0x52e008ba
    {
        get
        {
            int _0x8547341f = 0;
            for (int _0x549ec61f = 0; _0x549ec61f < this.TargetByColour.Length; _0x549ec61f++)
            {
                _0x8547341f += this.TargetByColour[_0x549ec61f];
            }

            return _0x8547341f;
        }
    }

    /// Measured on the plan itself: when a player who never touches the screen
    /// loses, and how long a player who catches everything needs.
    public float PassiveEndSeconds;
    /// Ring position that starts under the chute.
    public int StartCatchIndex;
    /// Ring position carrying a colour, so the menu preview and the hint can point
    /// at the right bowl without searching by name.
    public int _0x1a2a2653(int _0xe3315b60)
    {
        for (int _0x20a8104b = 0; _0x20a8104b < this.ColourAtRing.Length; _0x20a8104b++)
        {
            if (this.ColourAtRing[_0x20a8104b] == _0xe3315b60)
            {
                return _0x20a8104b;
            }
        }

        return 0;
    }

    /// How many fruits each COLOUR is asked for.
    public int[] TargetByColour = new int[_0x8b743421.CourtColours];
    /// True when the generator had to fall back to its hard-wired safety pattern.
    public bool IsFallback;
    public int OrderIndex;
    /// Seconds from the start of the run to the moment step i is released.
    public float[] ReleaseAt = new float[0];
    /// Colour carried by the bowl at each of the four ring positions.
    public int[] ColourAtRing = new int[_0x8b743421.CourtColours];
    /// Colour of the bowl standing under the chute for a given ring position.
    public int _0x9c5ac2ed(int _0x75cb54e6)
    {
        int _0xed8965cc = ((_0x75cb54e6 % _0x8b743421.CourtColours) + _0x8b743421.CourtColours) % _0x8b743421.CourtColours;
        return this.ColourAtRing[_0xed8965cc];
    }

    public int _0xce908f6b
    {
        get
        {
            return this.Steps.Length;
        }
    }
}