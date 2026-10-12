using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0xaeb67229 : MonoBehaviour
{
    public Ease ease = Ease.OutSine;
    public GameObject Content;
    private bool _0xb3add3df => this.Content.transform.localScale.x > 0.5f && this.Content.transform.localScale.y > 0.5f;

    private void Start()
    {
    // Content.SetActive(false);
    }

    public TMP_Text ContentMainText;
    public bool IsScaledDownOnAwake = true;
    public bool IsOnlyYScale;
    public Image ContentImage;
    public void Show()
    {
        this.Content.SetActive(true);
        if ((DOTween.TweensByTarget(this.Content.transform)?.Count ?? 0) > 0)
            DOTween.Kill(this.Content.transform, true);
        if (this.IsOnlyYScale)
            this.Content.transform.DOScaleY(1f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
            {
            });
        else
            this.Content.transform.DOScale(1f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
            {
            });
    }

    public TMP_Text ContentAdditionalText;
    public TMP_Text ContentHeaderText;
    public float scaleDuration = 0.4f;
    private void Awake()
    {
        this.Content.SetActive(true);
        if (this.IsScaledDownOnAwake)
            this._0x6d2cd99d();
    }

    private void _0x6d2cd99d()
    {
        DOTween.Kill(this.Content.transform, true);
        if (this.IsOnlyYScale)
            this.Content.transform.DOScaleY(0f, 0.01f);
        else
            this.Content.transform.DOScale(0f, 0.01f);
        this.Content.SetActive(false);
    }

    public static void HideAllPops()
    {
        _0x87a6397f.Instance._0x3b04cfaa();
    }

    public void _0xb72941b2()
    {
        if (this.Content.gameObject.activeSelf)
        {
            DOTween.Kill(this.Content.transform, true);
            if (this.IsOnlyYScale)
                this.Content.transform.DOScaleY(0f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
                {
                    this.Content.SetActive(false);
                });
            else
                this.Content.transform.DOScale(0f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
                {
                    this.Content.SetActive(false);
                });
        }
    }
}