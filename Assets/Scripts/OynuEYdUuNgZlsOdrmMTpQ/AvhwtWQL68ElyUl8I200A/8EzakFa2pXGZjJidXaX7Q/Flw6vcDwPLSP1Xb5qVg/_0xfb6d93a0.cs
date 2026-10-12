using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0xfb6d93a0 : MonoBehaviour
{
    public void _0xdaf59fec()
    {
        this._0x03c2a55a();
        this.Content.SetActive(true);
        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.localScale = Vector3.one;
        _0x3fe52430.Instance._0x3597aab7(_0x3fe52430.Instance.CurrentPanelIndex);
    }

    private void _0x8e9f77fe()
    {
        if (this.OuterBackground != null)
        {
            Image _0xa40ec447 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0xa40ec447, true);
            _0xa40ec447.DOFade(1f, this.ScaleDuration / 2f);
        }
    }

    public Ease Ease = Ease.OutSine;
    private void Awake()
    {
        this.Content.SetActive(true);
        if (this.OuterBackground != null)
            this.OuterBackground.gameObject.SetActive(true);
        if (this.IsScaledDownOnAwake)
            this._0x286f2033();
    }

    public bool IsScaledDownOnAwake = true;
    public void _0x6886db7e()
    {
        this._0xf988a4f1();
        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.DOScale(0f, this.ScaleDuration).SetEase(this.Ease).OnComplete(() =>
        {
            this.Content.SetActive(false);
        });
    }

    public void Show()
    {
        this._0x8e9f77fe();
        if (this.Content != null)
        {
            DOTween.Kill(this.Content.transform, true);
            this.Content.SetActive(true);
            this.Content.transform.DOScale(1f, this.ScaleDuration).SetEase(this.Ease).OnComplete(() =>
            {
                _0x3fe52430.Instance._0x3597aab7(_0x3fe52430.Instance.CurrentPanelIndex);
            });
        }
    }

    private void _0xf988a4f1()
    {
        if (this.OuterBackground != null)
        {
            Image _0x62dfc6dc = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x62dfc6dc, true);
            _0x62dfc6dc.DOFade(0f, this.ScaleDuration);
        }
    }

    private void _0x286f2033()
    {
        if (this.OuterBackground != null)
        {
            Image _0xca8e5675 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0xca8e5675, true);
            _0xca8e5675.DOFade(0f, 0.01f);
        }

        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.DOScale(0f, 0.01f);
    }

    public TMP_Text MainText;
    public GameObject Content;
    private void _0x03c2a55a()
    {
        if (this.OuterBackground != null)
        {
            Image _0x21d84010 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x21d84010, true);
            _0x21d84010.DOFade(1f, 0f);
        }
    }

    public GameObject OuterBackground;
    public float ScaleDuration = 0.4f;
    public TMP_Text HeaderText;
    private bool _0xb5227f52 => this.Content.transform.localScale.x > 0.5f && this.Content.transform.localScale.y > 0.5f;
}