using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using static _0xd21d76d7;

public class _0x3fe52430 : MonoBehaviour
{
    public void _0x3597aab7(int _0x40a34df1)
    {
        if (_0x40a34df1 == _0xc4101fb1.SPLASH && _0xc4913dd8.Instance._0x5870edf8 != _0x550bdfca.SCENE_0)
            _0xe4611075.Instance._0x56fb7a8f();
        if (_0xc4913dd8.Instance._0x5870edf8 != _0x550bdfca.SCENE_0)
        {
            if (_0x40a34df1 == _0xc4101fb1.SPLASH || _0x40a34df1 == _0xc4101fb1.TUTORIAL0)
                _0xc4913dd8.Instance._0xb5e7cd29(false);
            else if (_0x40a34df1 == _0xc4101fb1.DEFAULT)
                _0xc4913dd8.Instance._0xb5e7cd29(true);
        }
    }

    private _0xfb6d93a0 _0x34531efb(int _0x7e2a0ceb)
    {
        return this.Panels[_0x7e2a0ceb];
    }

    public void _0xe43ad4df(int _0x99c9d846)
    {
        this._0xda55eb79(_0x99c9d846);
        this._0xb2158ebc(_0x99c9d846);
        this.CurrentPanelIndex = _0x99c9d846;
        this.Panels[_0x99c9d846].Show();
    }

    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x3fe52430>();
    }

    public float ScaleDuration = 0.4f;
    private void _0xd3a19948(int _0x755e7b79)
    {
        this.LastPanelIndexes.Add(_0x755e7b79);
        this.CurrentPanelIndex = _0x755e7b79;
        for (int _0x91d7084b = 0; _0x91d7084b < this.Panels.Count; _0x91d7084b++)
            if (_0x91d7084b != _0x755e7b79 && this.Panels[_0x91d7084b] != null)
                this.Panels[_0x91d7084b]._0x6886db7e();
    }

    private void _0xb2158ebc(int _0x01189a40)
    {
        if (_0x01189a40 == _0xc4101fb1.SPLASH)
            _0xe4611075.Instance._0xec33a61a();
        if (_0xc4913dd8.Instance._0x5870edf8 == _0x550bdfca.SCENE_0)
        {
        }
    }

    public void _0x1d222642()
    {
        this.LastPanelIndexes.RemoveAll(_0xaa177cd5 => _0xaa177cd5 == this.CurrentPanelIndex);
        int _0x4b8cda46 = this.LastPanelIndexes.Last();
        this._0xb2158ebc(_0x4b8cda46);
        this._0xd3a19948(_0x4b8cda46);
        this.CurrentPanelIndex = _0x4b8cda46;
        this.Panels[_0x4b8cda46].Show();
    }

    public int CurrentPanelIndex;
    private void SwitchSplash()
    {
        if (_0x80c747d0.Instance.IsTutorialEnabled && !_0xc4913dd8._0x8519e350._0xa535c4cb)
            this._0xe43ad4df(_0xc4101fb1.TUTORIAL0);
        else
            this._0xe43ad4df(_0xc4101fb1.DEFAULT);
    }

    public List<_0xfb6d93a0> Panels;
    private void Start()
    {
        this._0x1a322325();
    }

    private void _0x86a150b9(int _0xd4cba7c9)
    {
        this._0xda55eb79(_0xd4cba7c9);
        this._0xb2158ebc(_0xd4cba7c9);
        this.CurrentPanelIndex = _0xd4cba7c9;
        this.Panels[_0xd4cba7c9]._0xdaf59fec();
    }

    [HideInInspector]
    public List<int> LastPanelIndexes = new()
    {
        1
    };
    private void _0xda55eb79(int _0xcf007ac3)
    {
        this.LastPanelIndexes.Add(_0xcf007ac3);
        this.CurrentPanelIndex = _0xcf007ac3;
        for (int _0x4f768f20 = 0; _0x4f768f20 < this.Panels.Count; _0x4f768f20++)
            if (_0x4f768f20 != _0xcf007ac3 && this.Panels[_0x4f768f20] != null)
                this.Panels[_0x4f768f20]._0x6886db7e();
    }

    public bool IsShowSplashOnStart = true;
    public static _0x3fe52430 Instance;
    public float StaticBlurMaterialInitialValue;
    private void _0x1a322325()
    {
        this._0x86a150b9(_0xc4101fb1.SPLASH);
        if (_0xc4913dd8.Instance._0x5870edf8 == _0x550bdfca.SCENE_0)
        {
        }
        else
        {
            this.Invoke(nameof(this.SwitchSplash), _0xe4611075.Instance.DefaultAnimationTime);
        }
    }
}