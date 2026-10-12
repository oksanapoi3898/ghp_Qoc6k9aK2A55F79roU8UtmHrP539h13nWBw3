using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class _0xe4611075 : MonoBehaviour
{
    public float FirstAnimationTime = 10.0f;
    public float SecondPassSliderValue = 0.5f;
    public static _0xe4611075 Instance;
    public void _0x3818057e()
    {
        {
#if B_LOGS
            {
                Debug.Log($"[Test] Animate Force");
            }
#endif
        }

        this._0x610a434e?.Kill();
        if (AnimationSlider != null)
            this.AnimationSlider.value = 1f;
        _0x7930ba05 = false;
    }

    public GameObject Content;
    public void _0xabc06a3f()
    {
        this._0x610a434e?.Play();
    }

    private void _0x5026e57c()
    {
        this.AnimationSlider.value = 0.05f;
        _0x7930ba05 = !_0x7930ba05;
        this._0x610a434e = DOTween.Sequence().Append(DOTween.To(() => this.AnimationSlider.value, _0xb0bfeffb => this.AnimationSlider.value = _0xb0bfeffb, 1f, this.FirstAnimationTime)).SetEase(Ease.Linear).OnComplete(() =>
        {
            _0xcc3984ae._0xfae286f9?._0x8133bbab();
        });
    }

    public void _0xe41d365c()
    {
        this._0x610a434e?.Pause();
    }

    public void _0x56fb7a8f()
    {
        this._0xec33a61a();
        bool _0x94cc7b01 = _0x7930ba05;
        this._0x610a434e = DOTween.Sequence().Append(DOTween.To(() => this.AnimationSlider.value, _0xb0bfeffb => this.AnimationSlider.value = _0xb0bfeffb, _0x94cc7b01 ? 1f : this.SecondPassSliderValue, this.DefaultAnimationTime)).SetEase(Ease.Linear);
        _0x7930ba05 = !_0x7930ba05;
    }

    public GameObject Error;
    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0xe4611075>();
    }

    public float DefaultAnimationTime = 0.4f;
    public GameObject Background;
    private Sequence _0x610a434e;
    public Slider AnimationSlider;
    private static bool _0x7930ba05 = false;
    public void _0xec33a61a()
    {
        this._0x610a434e?.Kill();
        this.AnimationSlider.value = _0x7930ba05 ? this.SecondPassSliderValue : 0.05f;
    }

    private void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex == _0xd21d76d7._0x550bdfca.SCENE_0 && !_0x7930ba05)
        {
            this._0x5026e57c();
        }
        else
        {
            this._0x56fb7a8f();
        }
    }
}