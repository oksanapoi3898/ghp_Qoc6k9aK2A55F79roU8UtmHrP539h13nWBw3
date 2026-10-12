using UnityEngine;
using UnityEngine.UI;

public class _0x5c090f16 : MonoBehaviour
{
    public bool IsShowLastPop;
    public int PopToShowIndex;
    private void Start()
    {
        if (this.IsShowLastPop)
            this.Button.onClick.AddListener(() =>
            {
                _0x87a6397f.Instance._0x25da19e1();
            });
        else if (this.IsHideAllPops)
            this.Button.onClick.AddListener(() => _0x87a6397f.Instance._0x3b04cfaa());
        else
            this.Button.onClick.AddListener(() => _0x87a6397f.Instance._0x69f99dba(this.PopToShowIndex));
    }

    public bool IsHideAllPops;
    public Button Button;
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }
}