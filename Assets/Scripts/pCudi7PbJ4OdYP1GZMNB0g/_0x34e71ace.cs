using DG.Tweening;
using UnityEngine;

/// One fruit on its way down the chute. It carries its own colour and reports the
/// moment it reaches the catching slot; what happens there is the round's decision,
/// not the fruit's.
///
/// The fall is driven by a DURATION, not by a speed in world units: the distance
/// depends on the camera aspect, the duration is the balance figure the schedule
/// was proved against.
public sealed class _0x34e71ace : MonoBehaviour
{
    public void _0xc04dd02a(int _0x7cd3a281, float _0x5ff6fcaa, float _0xbf106dfb, float _0x1170e594, System.Action<_0x34e71ace> _0x0790659a)
    {
        this._0x0f2493e4 = _0x7cd3a281;
        this._0x275f0587 = _0xbf106dfb;
        this._0x0e8929f9 = _0x0790659a;
        this._0x2f3f2290 = this.GetComponent<SpriteRenderer>();
        float _0x56cc408a = Mathf.Max(0.01f, _0x5ff6fcaa - _0xbf106dfb);
        this._0x0a291b18 = _0x56cc408a / Mathf.Max(0.05f, _0x1170e594);
        Vector3 _0x04e98cd2 = this.transform.position;
        _0x04e98cd2.y = _0x5ff6fcaa;
        this.transform.position = _0x04e98cd2;
        this._0x9092fd01 = true;
    }

    private int _0x0f2493e4;
    private System.Action<_0x34e71ace> _0x0e8929f9;
    public void _0x07301e04()
    {
        this._0x9092fd01 = false;
        this.transform.DOKill();
        if (this.gameObject != null)
        {
            Destroy(this.gameObject);
        }
    }

    private bool _0xfe31eb49;
    public int _0xc7f24287
    {
        get
        {
            return this._0x0f2493e4;
        }
    }

    private SpriteRenderer _0x2f3f2290;
    private float _0x275f0587;
    /// Caught: the fruit drops into the bowl and is gone.
    public void _0x37a3296e()
    {
        this._0x9092fd01 = false;
        this.transform.DOKill();
        this.transform.DOScale(0f, 0.18f).SetEase(Ease.InBack).OnComplete(() => this._0x07301e04());
    }

    private void Update()
    {
        if (!this._0x9092fd01 || this._0xfe31eb49)
        {
            return;
        }

        Vector3 _0xf14acc1b = this.transform.position;
        _0xf14acc1b.y -= this._0x0a291b18 * Time.deltaTime;
        if (_0xf14acc1b.y <= this._0x275f0587)
        {
            _0xf14acc1b.y = this._0x275f0587;
            this.transform.position = _0xf14acc1b;
            this._0x9092fd01 = false;
            if (this._0x0e8929f9 != null)
            {
                this._0x0e8929f9.Invoke(this);
            }

            return;
        }

        this.transform.position = _0xf14acc1b;
    }

    private float _0x0a291b18;
    /// Missed: the fruit bounces off the rim and rolls away.
    public void _0x303341fe(float _0x2c599076)
    {
        this._0x9092fd01 = false;
        this.transform.DOKill();
        this.transform.DOJump(this.transform.position + new Vector3(_0x2c599076, -0.9f, 0f), 0.55f, 1, 0.45f).SetEase(Ease.OutQuad);
        if (this._0x2f3f2290 != null)
        {
            this._0x2f3f2290.DOFade(0f, 0.45f).OnComplete(() => this._0x07301e04());
        }
        else
        {
            DOVirtual.DelayedCall(0.45f, () => this._0x07301e04());
        }
    }

    private bool _0x9092fd01;
    /// Held still while the court is paused, so a pause card can never be a free
    /// extra second of falling.
    public void _0x7cb252e9(bool _0x0501c3df)
    {
        this._0xfe31eb49 = _0x0501c3df;
    }
}