using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using static _0xd21d76d7;

public class _0x87a6397f : MonoBehaviour
{
    public GameObject BlurBackground;
    private void _0xfddb771c()
    {
        this.BlurBackground.gameObject.SetActive(true);
    }

    public List<_0xaeb67229> Pops;
    private void _0x590eab2c()
    {
        this.Invoke(nameof(this.BackgroundHidden), this.ScaleDuration);
    }

    public int CurrentPopIndex;
    public List<int> LastPopIndexes = new();
    public float ScaleDuration = 0.4f;
    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x87a6397f>();
    }

    public _0xaeb67229 _0x42f91743(int _0x2ff4cd8e)
    {
        return this.Pops[_0x2ff4cd8e];
    }

    private void BackgroundHidden()
    {
        this.BlurBackground.gameObject.SetActive(false);
    }

    public void _0x69f99dba(int _0xbc86fa75)
    {
        this.CurrentPopIndex = _0xbc86fa75;
        this.LastPopIndexes.Add(this.CurrentPopIndex);
        this._0xb9ab9773(true);
        this._0xfddb771c();
        this.Pops[_0xbc86fa75].Show();
        foreach (GameObject _0xd662a3e0 in this.GameObjectsToHide)
            _0xd662a3e0.SetActive(false);
    }

    private void _0xb9ab9773(bool _0x84f16abd = false)
    {
        for (int _0xeea284f2 = 0; _0xeea284f2 < this.Pops.Count; ++_0xeea284f2)
            if (this.Pops[_0xeea284f2] != null && !(_0xeea284f2 == this.CurrentPopIndex && _0x84f16abd))
                this.Pops[_0xeea284f2]._0xb72941b2();
    }

    private void Start()
    {
        this.BackgroundHidden();
        foreach (_0xaeb67229 _0x23ea60c7 in this.Pops)
            if (_0x23ea60c7 != null)
                _0x23ea60c7.gameObject.SetActive(true);
    }

    public void _0x25da19e1()
    {
        this.LastPopIndexes.RemoveAll(_0xaa177cd5 => _0xaa177cd5 == this.CurrentPopIndex);
        if (this.LastPopIndexes.Count <= 0)
            this._0x3b04cfaa();
        else
            this._0x69f99dba(this.LastPopIndexes.Last());
    }

    public List<GameObject> GameObjectsToHide;
    public void _0x3b04cfaa()
    {
        this.LastPopIndexes.Clear();
        this._0xb9ab9773();
        foreach (GameObject _0x13a2e22b in this.GameObjectsToHide)
            if (_0x13a2e22b != null)
                _0x13a2e22b.SetActive(true);
        this._0x590eab2c();
    }

    public static _0x87a6397f Instance;
}