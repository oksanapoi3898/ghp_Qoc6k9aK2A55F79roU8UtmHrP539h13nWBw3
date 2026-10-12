using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class _0xea444ea0 : MonoBehaviour
{
    private void _0x6c1c3884()
    {
        float _0x9fe4e3cd, _0x2136397c, _0x5777210b, _0xd72a1d4c;
        if (this._0x5fdde701 == _0x118c3bfe.Landscape)
            this._0xf178e5ce.orthographicSize = 1f / this._0xf178e5ce.aspect * this._0x2dc7ab4f / 2f;
        else
            this._0xf178e5ce.orthographicSize = this._0x2dc7ab4f / 2f;
        this._0x7c023253 = 2f * this._0xf178e5ce.orthographicSize;
        this._0xc59cc8ac = this._0x7c023253 * this._0xf178e5ce.aspect;
        float _0x88bdba75 = this._0xf178e5ce.transform.position.x;
        float _0x4dffe1e7 = this._0xf178e5ce.transform.position.y;
        _0x9fe4e3cd = _0x88bdba75 - this._0xc59cc8ac / 2;
        _0x2136397c = _0x88bdba75 + this._0xc59cc8ac / 2;
        _0x5777210b = _0x4dffe1e7 + this._0x7c023253 / 2;
        _0xd72a1d4c = _0x4dffe1e7 - this._0x7c023253 / 2;
        this._0xd3196d06 = new Vector3(_0x9fe4e3cd, _0xd72a1d4c, 0);
        this._0xfb6253a9 = new Vector3(_0x88bdba75, _0xd72a1d4c, 0);
        this._0x04a9c46c = new Vector3(_0x2136397c, _0xd72a1d4c, 0);
        this._0x50559e92 = new Vector3(_0x9fe4e3cd, _0x4dffe1e7, 0);
        this._0x70a5cf28 = new Vector3(_0x88bdba75, _0x4dffe1e7, 0);
        this._0xfc6bb11e = new Vector3(_0x2136397c, _0x4dffe1e7, 0);
        this._0xc0b81613 = new Vector3(_0x9fe4e3cd, _0x5777210b, 0);
        this._0x7dd0246c = new Vector3(_0x88bdba75, _0x5777210b, 0);
        this._0xbe4d3f7b = new Vector3(_0x2136397c, _0x5777210b, 0);
    }

    private new Camera _0xf178e5ce;
    private Vector3 _0xfc6bb11e { get; set; }

    private void OnDrawGizmos()
    {
        Gizmos.color = this._0xb21a3b32;
        Matrix4x4 _0x835fc81e = Gizmos.matrix;
        Gizmos.matrix = Matrix4x4.TRS(this.transform.position, this.transform.rotation, Vector3.one);
        if (this._0xf178e5ce.orthographic)
        {
            float _0xa73a3d5b = this._0xf178e5ce.farClipPlane - this._0xf178e5ce.nearClipPlane;
            float _0xd62777d7 = (this._0xf178e5ce.farClipPlane + this._0xf178e5ce.nearClipPlane) * 0.5f;
            Gizmos.DrawWireCube(new Vector3(0, 0, _0xd62777d7), new Vector3(this._0xf178e5ce.orthographicSize * 2 * this._0xf178e5ce.aspect, this._0xf178e5ce.orthographicSize * 2, _0xa73a3d5b));
        }
        else
        {
            Gizmos.DrawFrustum(Vector3.zero, this._0xf178e5ce.fieldOfView, this._0xf178e5ce.farClipPlane, this._0xf178e5ce.nearClipPlane, this._0xf178e5ce.aspect);
        }

        Gizmos.matrix = _0x835fc81e;
    }

    private _0x118c3bfe _0x5fdde701 = _0x118c3bfe.Portrait;
    private Color _0xb21a3b32 = Color.white;
    private Vector3 _0x04a9c46c { get; set; }
    private Vector3 _0xd3196d06 { get; set; }

    public enum _0x118c3bfe
    {
        Landscape,
        Portrait
    }

    //public bool executeInUpdate;
    private float _0xc59cc8ac { get; set; }
    private float _0x7c023253 { get; set; }
    private Vector3 _0xc0b81613 { get; set; }
    private Vector3 _0x70a5cf28 { get; set; }

    private void Awake()
    {
        this._0xf178e5ce = this.GetComponent<Camera>();
        _0x548aa467 = this;
        this._0x6c1c3884();
    }

    private Vector3 _0x50559e92 { get; set; }
    private Vector3 _0xfb6253a9 { get; set; }

    private float _0x2dc7ab4f = 1;
    private Vector3 _0xbe4d3f7b { get; set; }

    private static _0xea444ea0 _0x548aa467;
    private Vector3 _0x7dd0246c { get; set; }
}