using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class _0x1bd8640e : MonoBehaviour
{
    private AspectRatioFitter _0x56522044;
    private float _0xad4836b1;
    private TMP_Text _0xb8cd3cd8;
    private float _0x5ee844e5 = 0.6f;
    private float _0xe25f1ba9 = 1.5f;
    private List<string> _0x249443e5 = new();
    private void Update()
    {
        int _0x0bf5549b = 1;
        if (this._0x249443e5.Count > 0)
        {
            string _0x804b86b2 = this._0xb8cd3cd8.text;
            foreach (string _0x4b0645f5 in this._0x249443e5)
                while (_0x804b86b2.Contains(_0x4b0645f5))
                    _0x804b86b2 = _0x804b86b2.Replace(_0x4b0645f5, "");
            _0x0bf5549b = _0x804b86b2.Length;
        }
        else
        {
            _0x0bf5549b = this._0xb8cd3cd8.text.Length;
        }

        float _0x4f789205 = Mathf.Clamp(this._0xad4836b1 + this._0x5ee844e5 * _0x0bf5549b, this._0xe25f1ba9, this._0xc4e7b0f2);
        if (!Mathf.Approximately(this._0x56522044.aspectRatio, _0x4f789205))
            this._0x56522044.aspectRatio = _0x4f789205;
    }

    private float _0xc4e7b0f2 = 4;
}