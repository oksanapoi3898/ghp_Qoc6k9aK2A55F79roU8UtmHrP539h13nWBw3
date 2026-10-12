using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0xde938c21 : MonoBehaviour
{
    private Image _0x8cf86063;
    private void _0x889e02c4()
    {
        if (this._0x8cf86063.canvasRenderer.GetColor() != this._0xcd6a1034.canvasRenderer.GetColor())
            this._0xcd6a1034.canvasRenderer.SetColor(this._0x8cf86063.canvasRenderer.GetColor());
    }

    private void Update()
    {
        this._0x889e02c4();
    }

    private TMP_Text _0xcd6a1034;
}