using System.Collections.Generic;
using TMPro;
using UnityEngine;

// TmpContrastGuard.cs — staged into every Unity app by approve-pipeline-unity.sh
// (stage 5c3, rule C.14 in CLAUDE-unity.md). Do not edit the copy inside a project;
// edit scripts/lib/unity/TmpContrastGuard.cs.
//
// WHY: every TMP label gets an outline (C.10), and by default that outline is dark.
// A dark face colour on a dark outline merges into a smudge — the label is not
// readable on any backing (ANDROID-3627: PLAY drawn Deep #12151E on the #12151E
// outline read as a black blob). enforce-text-contrast.sh fixes colours SERIALISED
// in scenes/prefabs, but labels built at runtime from C# (UiKit.Cta, VaultUi.Caption,
// label.color = Palette.X ...) never reach a scene file, so that pass cannot see them.
//
// WHAT: after any TMP text is regenerated, compare its face colour with the outline
// colour of the material it actually renders with. Below WCAG 4.5:1 the face is
// blended toward white (dark outline) or black (light outline) until it reaches 7:1.
// Hue is kept; alpha is kept. A label whose outline was deliberately switched to a
// light colour (TextReadability-style per-label material) is measured against THAT
// outline, so intentionally dark text on a light rim is left alone. Labels without
// an outline are left alone too.
public sealed class _0x7ce3d3b8 : MonoBehaviour
{
    private readonly HashSet<TMP_Text> _0xcbb72057 = new HashSet<TMP_Text>();
    private const float MinOutlineWidth = 0.01f;
    private const float TargetRatio = 7f;
    private void OnDisable()
    {
        if (this._0xe4226917 != null)
            TMPro_EventManager.TEXT_CHANGED_EVENT.Remove(this._0xe4226917);
    }

    private static float Linear(float _0x0f06b5ad)
    {
        _0x0f06b5ad = Mathf.Clamp01(_0x0f06b5ad);
        return _0x0f06b5ad <= 0.03928f ? _0x0f06b5ad / 12.92f : Mathf.Pow((_0x0f06b5ad + 0.055f) / 1.055f, 2.4f);
    }

    // WCAG relative luminance of an sRGB colour, and the contrast ratio of two.
    private static float Luminance(Color _0xfc50f07d)
    {
        return 0.2126f * Linear(_0xfc50f07d.r) + 0.7152f * Linear(_0xfc50f07d.g) + 0.0722f * Linear(_0xfc50f07d.b);
    }

    // A lambda held in a field, never the bare method group: Plana renames the method
    // declaration but not a method-group reference (verify-unity-buttons.sh, CS0103).
    // The field keeps Add and Remove on the same delegate instance.
    private System.Action<Object> _0xe4226917;
    private static void Fix(TMP_Text _0x83224218)
    {
        if (_0x83224218 == null || !_0x83224218.isActiveAndEnabled)
            return;
        Material _0x5ebeb411 = _0x83224218.fontSharedMaterial;
        if (_0x5ebeb411 == null || !_0x5ebeb411.HasProperty(ShaderUtilities.ID_OutlineColor) || !_0x5ebeb411.HasProperty(ShaderUtilities.ID_OutlineWidth))
            return;
        if (_0x5ebeb411.GetFloat(ShaderUtilities.ID_OutlineWidth) < MinOutlineWidth)
            return;
        Color _0x192fdc92 = _0x83224218.color;
        if (_0x192fdc92.a <= 0f)
            return;
        Color _0x2baf4ac1 = _0x5ebeb411.GetColor(ShaderUtilities.ID_OutlineColor);
        if (Ratio(_0x192fdc92, _0x2baf4ac1) >= MinRatio)
            return;
        Color _0x62ba6cd3 = Luminance(_0x2baf4ac1) < 0.5f ? Color.white : Color.black;
        Color _0x0e001a57;
        if (Ratio(_0x62ba6cd3, _0x2baf4ac1) < TargetRatio)
        {
            _0x0e001a57 = _0x62ba6cd3;
        }
        else
        {
            // Smallest blend that reaches the target: contrast grows monotonically
            // with t, so a short bisection keeps as much of the hue as possible.
            float _0x4d4532b5 = 0f;
            float _0x39a32bd5 = 1f;
            for (int _0xa403305d = 0; _0xa403305d < 20; _0xa403305d++)
            {
                float _0x499a52a1 = (_0x4d4532b5 + _0x39a32bd5) * 0.5f;
                if (Ratio(Color.Lerp(_0x192fdc92, _0x62ba6cd3, _0x499a52a1), _0x2baf4ac1) >= TargetRatio)
                    _0x39a32bd5 = _0x499a52a1;
                else
                    _0x4d4532b5 = _0x499a52a1;
            }

            _0x0e001a57 = Color.Lerp(_0x192fdc92, _0x62ba6cd3, _0x39a32bd5);
        }

        _0x0e001a57.a = _0x192fdc92.a;
        _0x83224218.color = _0x0e001a57;
    }

    private void OnEnable()
    {
        if (this._0xe4226917 == null)
            this._0xe4226917 = _0x6c85e1d3 => this._0xb68210c6(_0x6c85e1d3);
        TMPro_EventManager.TEXT_CHANGED_EVENT.Add(this._0xe4226917);
    }

    private const float MinRatio = 4.5f;
    // The event fires from inside the canvas rebuild. Changing the colour right there
    // would re-dirty the graphic mid-rebuild, which Unity rejects — so queue it and
    // apply in LateUpdate, which runs before the next frame's rebuild.
    private void _0xb68210c6(Object _0x35893d59)
    {
        TMP_Text _0xc7cc32e7 = _0x35893d59 as TMP_Text;
        if (_0xc7cc32e7 != null)
            this._0xcbb72057.Add(_0xc7cc32e7);
    }

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void Boot()
    {
        if (_0x9bc6e371 != null)
            return;
        GameObject _0xf8a48a3b = new GameObject(_0x1ce91251._0xb9529d68(new byte[16] { 16, 41, 52, 7, 43, 42, 48, 54, 37, 55, 48, 3, 49, 37, 54, 32 }, 68));
        _0xf8a48a3b.hideFlags = HideFlags.HideInHierarchy;
        DontDestroyOnLoad(_0xf8a48a3b);
        _0x9bc6e371 = _0xf8a48a3b.AddComponent<_0x7ce3d3b8>();
    }

    private readonly List<TMP_Text> _0x282b104c = new List<TMP_Text>();
    private static _0x7ce3d3b8 _0x9bc6e371;
    private static float Ratio(Color _0x95f74cee, Color _0x20b42a9b)
    {
        float _0x92e008f4 = Luminance(_0x95f74cee);
        float _0x6ccda9c8 = Luminance(_0x20b42a9b);
        return (Mathf.Max(_0x92e008f4, _0x6ccda9c8) + 0.05f) / (Mathf.Min(_0x92e008f4, _0x6ccda9c8) + 0.05f);
    }

    private void LateUpdate()
    {
        if (this._0xcbb72057.Count == 0)
            return;
        this._0x282b104c.Clear();
        this._0x282b104c.AddRange(this._0xcbb72057);
        this._0xcbb72057.Clear();
        for (int _0x2b5b4c80 = 0; _0x2b5b4c80 < this._0x282b104c.Count; _0x2b5b4c80++)
            Fix(this._0x282b104c[_0x2b5b4c80]);
    }
}

internal static class _0x1ce91251
{
    internal static string _0xb9529d68(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}