using UnityEngine;
using UnityEngine.UI;

public class _0x6e55bb31 : MonoBehaviour
{
    public Button Button;
    public bool IsPhysicsRunOnClick;
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }

    private void Start()
    {
        this.Button.onClick.AddListener(() => _0xc4913dd8.Instance._0xb5e7cd29(this.IsPhysicsRunOnClick));
    }
}