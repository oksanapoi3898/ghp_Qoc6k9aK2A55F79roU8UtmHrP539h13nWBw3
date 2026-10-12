using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0xe8a9b7ea : MonoBehaviour
{
    private IEnumerator _0xcde912d8()
    {
        this._0xfdd6efb3();
        while (!this.IsGameEnd && this.TimeLeft > 0 && _0xc4913dd8.Instance._0x5870edf8 == this.CurrentGameIndex)
        {
            yield return new WaitForSeconds(1f);
            if (_0xc4913dd8.Instance._0xc7a506c8)
            {
                if (this.IsGameEnd)
                    break;
                this.TimeLeft--;
                this._0xfdd6efb3();
            }
        }

        if (!this.IsGameEnd)
            this._0x7d2b14bb();
    }

    public List<Button> HomeButtons = new();
    [HideInInspector]
    public int CurrentGameIndex;
    private static _0xe8a9b7ea _0x7e0dbc53;
    public void _0x7d2b14bb()
    {
        if (_0x80c747d0.Instance.IsOnlyWinGameEndEnabled)
            this._0x9efec450();
        if (!this.IsGameEnd)
        {
            this._0x4a933bce();
            _0xc4913dd8.IsAfterLevelComplete = false;
            _0xc4913dd8.IsAfterLevelFailed = true;
            _0xaeb67229 _0x2e6a4827 = _0x87a6397f.Instance._0x42f91743(_0xd21d76d7._0xdc6ccd34.LOSE).GetComponent<_0xaeb67229>();
            if (_0x80c747d0.Instance.IsCheckScoreEnabled)
                _0x2e6a4827.ContentMainText.text = $"{this.ScoreCurrent}/{this._0xbb38b58d}";
            else
                _0x2e6a4827.ContentMainText.text = $"{this.ScoreCurrent}";
            _0x2e6a4827.ContentAdditionalText.text = $"{0}";
            _0xd21d76d7._0x80e81cfa._0xdd26d0ea += 0;
            _0x87a6397f.Instance._0x69f99dba(_0xd21d76d7._0xdc6ccd34.LOSE);
        }
    }

    private void Start()
    {
        this.IsGameEnd = false;
        this.TimeLeft = this._0x5b124f6e;
        this.CurrentGameIndex = _0xc4913dd8.Instance._0x5870edf8;
        foreach (Button _0xdc8a5686 in this.HomeButtons)
            _0xdc8a5686.onClick.AddListener(() =>
            {
                this._0x62a6d80b();
            });
        foreach (Button _0xd2e5aa9c in this.PauseButtons)
            _0xd2e5aa9c.onClick.AddListener(() =>
            {
                _0xc4913dd8.Instance._0xb5e7cd29(false);
                _0x87a6397f.Instance._0x69f99dba(_0xd21d76d7._0xdc6ccd34.PAUSE);
            });
        this._0xb79a0a4e();
        this.LevelNumberText.ForEach(_0xa8cb3d86 => _0xa8cb3d86.text = $"LVL {_0xc4913dd8._0x8519e350._0xb7ec016a + 1}");
        if (_0x80c747d0.Instance.IsTimerEnabled)
        {
            this._0xfdd6efb3();
            this.StartCoroutine(this._0xcde912d8());
        }
    }

    public List<TMP_Text> ScoreText = new();
    public List<Button> PauseButtons = new();
    private void _0xfdd6efb3()
    {
        this.TimerText.ForEach(_0xa8cb3d86 => _0xa8cb3d86.text = TimeSpan.FromSeconds(this.TimeLeft).ToString(_0xc57ce703._0x6c9dabb7(new byte[6] { 162, 162, 147, 245, 188, 188 }, 207)));
    }

    public int CustomTimeInitial = 30;
    public int CustomTargetScore = 10;
    [HideInInspector]
    public int ScoreCurrent;
    private void _0xcc8136dc()
    {
        if (this.ScoreCurrent >= this._0xbb38b58d)
            this._0x9efec450();
        else
            this._0x7d2b14bb();
    }

    private void _0xeff55c85()
    {
        if (this.ScoreCurrent > _0xc4913dd8._0x8519e350._0x21a65b0d)
            _0xc4913dd8._0x8519e350._0x21a65b0d = this.ScoreCurrent;
        if (_0x80c747d0.Instance.IsCheckScoreEnabled)
            if (this.ScoreCurrent >= this._0xbb38b58d)
                this._0x9efec450();
    }

    private int _0x5b124f6e => this.CustomTimeInitial + _0xc4913dd8._0x8519e350._0xb7ec016a * 10;

    public List<TMP_Text> LevelNumberText = new();
    public List<TMP_Text> TimerText = new();
    private int _0xbb38b58d => this.CustomTargetScore + _0xc4913dd8._0x8519e350._0xb7ec016a * 10;

    public void _0x62a6d80b()
    {
        _0xc4913dd8.Instance._0xb5e7cd29(true);
        _0xc4913dd8.Instance.LoadSceneByIndex(_0xd21d76d7._0x550bdfca.SCENE_0);
    }

    public void _0x988c5c0a(int scoreToAdd)
    {
        if (!this.IsGameEnd)
        {
            this.ScoreCurrent += scoreToAdd;
            this._0xb79a0a4e();
            this._0xeff55c85();
        }
    }

    private void _0x4a933bce()
    {
        this.IsGameEnd = true;
        _0xc4913dd8.IsAfterLevelComplete = true;
    }

    public List<TMP_Text> SubtitleText = new();
    private void _0xb79a0a4e()
    {
        if (_0x80c747d0.Instance.IsCheckScoreEnabled)
            this.ScoreText.ForEach(_0xa8cb3d86 => _0xa8cb3d86.text = $"{this.ScoreCurrent}/{this._0xbb38b58d}");
        else
            this.ScoreText.ForEach(_0xa8cb3d86 => _0xa8cb3d86.text = $"{this.ScoreCurrent}");
    }

    private int _0x34ae5b78 => this.ScoreCurrent;

    public void _0x9efec450()
    {
        if (!this.IsGameEnd)
        {
            this._0x4a933bce();
            _0xc4913dd8.IsAfterLevelComplete = true;
            _0xc4913dd8.IsAfterLevelFailed = false;
            _0xaeb67229 _0x5552a4cb = _0x87a6397f.Instance._0x42f91743(_0xd21d76d7._0xdc6ccd34.WIN).GetComponent<_0xaeb67229>();
            if (_0x80c747d0.Instance.IsCheckScoreEnabled)
                _0x5552a4cb.ContentMainText.text = $"{this.ScoreCurrent}/{this._0xbb38b58d}";
            else
                _0x5552a4cb.ContentMainText.text = $"{this.ScoreCurrent}";
            if (_0x80c747d0.Instance.IsBestScoreEnabled)
            {
                if (this.ScoreCurrent > _0xd21d76d7._0x80e81cfa._0xdd26d0ea)
                    _0xd21d76d7._0x80e81cfa._0xdd26d0ea = this.ScoreCurrent;
                _0x5552a4cb.ContentAdditionalText.text = $"{_0xd21d76d7._0x80e81cfa._0xdd26d0ea}";
            }
            else
            {
                _0x5552a4cb.ContentAdditionalText.text = $"{this._0x34ae5b78}";
                _0xd21d76d7._0x80e81cfa._0xdd26d0ea += this._0x34ae5b78;
            }

            if (_0x80c747d0.Instance.IsLevelIncrementOnWin)
                ++_0xc4913dd8._0x8519e350._0xb7ec016a;
            _0x87a6397f.Instance._0x69f99dba(_0xd21d76d7._0xdc6ccd34.WIN);
        }
    }

    [HideInInspector]
    public int TimeLeft;
    private void Awake()
    {
        _0x7e0dbc53 = this.gameObject.GetComponent<_0xe8a9b7ea>();
    }

    [HideInInspector]
    public bool IsGameEnd;
}

internal static class _0xc57ce703
{
    internal static string _0x6c9dabb7(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}