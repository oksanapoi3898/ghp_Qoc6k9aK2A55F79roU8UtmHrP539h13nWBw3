using UnityEngine;
using UnityEngine.UI;

public class _0xa794768c : MonoBehaviour
{
    private void Awake()
    {
        if (this._0x4e197416 == null)
            if (!this.TryGetComponent(out this._0x4e197416))
                this._0x4e197416 = this.GetComponentInChildren<Button>();
    }

    private void Start()
    {
        if (this._0xba532c5e)
            this._0x4e197416.onClick.AddListener(() => _0x3fe52430.Instance._0x1d222642());
        else
            this._0x4e197416.onClick.AddListener(() => _0x3fe52430.Instance._0xe43ad4df(this._0xfbba638b));
    }

    private bool _0xba532c5e;
    private Button _0x4e197416;
    private int _0xfbba638b;
}