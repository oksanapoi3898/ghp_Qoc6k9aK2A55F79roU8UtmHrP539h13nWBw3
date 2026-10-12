using TMPro;
using UnityEngine;
using static _0xd21d76d7;

public class _0x7f613695 : MonoBehaviour
{
    private void Start()
    {
        if (this.MoneyCountText == null)
        {
            TMP_Text _0x428a72c6;
            if (this.gameObject.TryGetComponent(out _0x428a72c6))
                this.MoneyCountText = _0x428a72c6;
        }

        this._0x2ce7c99e();
    }

    public TMP_Text MoneyCountText;
    public void _0x2ce7c99e()
    {
        this.MoneyCountText.text = _0x80e81cfa._0xdd26d0ea.ToString();
    }
}