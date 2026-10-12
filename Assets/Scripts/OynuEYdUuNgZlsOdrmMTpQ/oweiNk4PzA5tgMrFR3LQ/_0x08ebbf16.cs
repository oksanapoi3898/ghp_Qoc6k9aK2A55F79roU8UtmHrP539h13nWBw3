using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;
using Touch = UnityEngine.InputSystem.EnhancedTouch.Touch;
using TouchPhase = UnityEngine.InputSystem.TouchPhase;

public class _0x08ebbf16 : MonoBehaviour
{
    private void Awake()
    {
        EnhancedTouchSupport.Enable();
        _0x1932ad4c = this.gameObject.GetComponent<_0x08ebbf16>();
    }

    private static _0x08ebbf16 _0x1932ad4c;
    private bool _0x62ad8857(Touch? _0x7038c44c)
    {
        if (!_0x7038c44c.HasValue)
            return false;
        Vector3 _0x580c574f = Camera.main.ScreenToWorldPoint(_0x7038c44c.Value.screenPosition);
        Vector3 _0x25b4a81c = _0x580c574f;
        _0x25b4a81c.z = this.CameraTouchBounds.transform.position.z;
        if (this.CameraTouchBounds.bounds.Contains(_0x25b4a81c))
            return true;
        _0x7038c44c = null;
        return false;
    }

    private Touch? _0xb471aaec()
    {
        if (!_0xc4913dd8.Instance._0xc7a506c8)
            return null;
        foreach (Touch _0x9e6d14df in Touch.activeTouches)
            if (_0x9e6d14df.ended)
                if (this._0x62ad8857(_0x9e6d14df))
                    return _0x9e6d14df;
        return null;
    }

    private Touch? _0xd9a7a5fe(Bounds _0xc59103e7, TouchPhase _0x6fa01a61)
    {
        if (!_0xc4913dd8.Instance._0xc7a506c8)
            return null;
        foreach (Touch _0x8112c667 in Touch.activeTouches)
            if (_0x8112c667.phase == _0x6fa01a61)
            {
                Vector3 _0x7a092e7f = Camera.main.ScreenToWorldPoint(_0x8112c667.screenPosition);
                Vector3 _0xf4fdb560 = new(_0x7a092e7f.x, _0x7a092e7f.y, _0xc59103e7.center.z);
                if (_0xc59103e7.Contains(_0xf4fdb560) && this._0x62ad8857(_0x8112c667))
                    return _0x8112c667;
            }

        return null;
    }

    private Touch? _0x2c4068ae()
    {
        if (!_0xc4913dd8.Instance._0xc7a506c8)
            return null;
        foreach (Touch _0x2c0583b8 in Touch.activeTouches)
            if (!_0x2c0583b8.ended)
                if (this._0x62ad8857(_0x2c0583b8))
                    return _0x2c0583b8;
        return null;
    }

    private void _0x0af03647(Touch? _0x265ae382)
    {
        if (!_0xc4913dd8.Instance._0xc7a506c8)
        {
            _0x265ae382 = null;
            return;
        }

        int _0xde719b14 = _0x265ae382.Value.touchId;
        _0x265ae382 = Touch.activeTouches.FirstOrDefault(_0xf86600c0 => _0xf86600c0.touchId == _0xde719b14);
        if (!this._0x62ad8857(_0x265ae382.Value))
            _0x265ae382 = null;
    }

    private Touch? _0xa91b478d(Bounds _0xe392d7bf)
    {
        if (!_0xc4913dd8.Instance._0xc7a506c8)
            return null;
        foreach (Touch _0x9b3fced3 in Touch.activeTouches)
            if (_0x9b3fced3.ended)
            {
                Vector3 _0x15b741fc = Camera.main.ScreenToWorldPoint(_0x9b3fced3.screenPosition);
                Vector3 _0x4b1cf4e9 = new(_0x15b741fc.x, _0x15b741fc.y, _0xe392d7bf.center.z);
                if (_0xe392d7bf.Contains(_0x4b1cf4e9) && this._0x62ad8857(_0x9b3fced3))
                    return _0x9b3fced3;
            }

        return null;
    }

    private Touch? _0xcc69dfa1(Bounds _0x29fac1d7)
    {
        if (!_0xc4913dd8.Instance._0xc7a506c8)
            return null;
        foreach (Touch _0x48496a35 in Touch.activeTouches)
            if (!_0x48496a35.ended)
            {
                Vector3 _0xe67ef9ad = Camera.main.ScreenToWorldPoint(_0x48496a35.screenPosition);
                Vector3 _0x84c91fdc = new(_0xe67ef9ad.x, _0xe67ef9ad.y, _0x29fac1d7.center.z);
                if (_0x29fac1d7.Contains(_0x84c91fdc) && this._0x62ad8857(_0x48496a35))
                    return _0x48496a35;
            }

        return null;
    }

    public BoxCollider2D CameraTouchBounds;
    private bool _0x44f5bfae(Touch? _0x74219dec, Bounds _0x3a6216b3, TouchPhase _0x9bb1ddfd)
    {
        if (!_0xc4913dd8.Instance._0xc7a506c8)
        {
            _0x74219dec = null;
            return false;
        }

        if (_0x74219dec != null)
            if (_0x74219dec.Value.phase == _0x9bb1ddfd)
            {
                Vector3 _0x32db4847 = Camera.main.ScreenToWorldPoint(_0x74219dec.Value.screenPosition);
                Vector3 _0x540503d3 = new(_0x32db4847.x, _0x32db4847.y, _0x3a6216b3.center.z);
                if (_0x3a6216b3.Contains(_0x540503d3) && this._0x62ad8857(_0x74219dec.Value))
                    return true;
            }

        return false;
    }
}