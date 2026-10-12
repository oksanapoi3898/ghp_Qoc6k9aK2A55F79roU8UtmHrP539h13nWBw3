using UnityEngine;
using UnityEngine.EventSystems;

/// The second way to turn the platter: a tap on the left or the right half of the
/// play area, for players who do not want to reach for the two buttons.
///
/// It is one full-surface UI graphic rather than two colliders, because the pointer
/// arrives in screen pixels and a fraction of the screen width is exact however the
/// canvas is letterboxed on a given device. It sits as the FIRST child of the HUD,
/// so every button built after it wins the raycast over it.
public sealed class _0x85bace7c : MonoBehaviour, IPointerClickHandler
{
    private System.Action<int> _0xf22a0531;
    public void _0x8279fe50(System.Action<int> _0xff73147a)
    {
        this._0xf22a0531 = _0xff73147a;
    }

    public void OnPointerClick(PointerEventData _0x05a1a9c3)
    {
        if (this._0xf22a0531 == null || _0x05a1a9c3 == null)
        {
            return;
        }

        float width = Mathf.Max(1f, Screen.width);
        int _0x5b28afd3 = _0x05a1a9c3.position.x < (width * 0.5f) ? -1 : 1;
        this._0xf22a0531.Invoke(_0x5b28afd3);
    }
}