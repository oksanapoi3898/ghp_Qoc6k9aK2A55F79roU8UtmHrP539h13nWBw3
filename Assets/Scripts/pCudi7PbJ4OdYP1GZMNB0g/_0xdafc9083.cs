using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// The HOW TO PLAY sheet. It is this game's own overlay rather than the template's
/// tutorial pages, because those pages only open once per install and a capture run
/// has to behave the same every time.
///
/// The dimmed surround is itself a close control, and the card above it swallows
/// its own presses - so a tap that misses the corner glyph by a few pixels still
/// closes the sheet instead of leaving it parked over the PLAY button.
public sealed class _0xdafc9083 : MonoBehaviour
{
    public void _0xed1566f1()
    {
        if (this._0x598de712 != null)
        {
            this._0x598de712.SetActive(false);
        }
    }

    private bool _0xea197a36;
    private GameObject _0x598de712;
    public void _0x71ef9690(Transform _0x524143fd, TMP_FontAsset _0x90186b97, Sprite _0x613be34c, Sprite _0xa7b50c69, Sprite _0x7c25eac5, Sprite _0x5bc28a75, Sprite _0x1f22e7cc, Sprite _0x71161376, Sprite _0x42a33d46)
    {
        if (this._0xea197a36 || _0x524143fd == null)
        {
            return;
        }

        this._0xea197a36 = true;
        RectTransform _0xd70c0cea = _0x1685b31d.Stretch(_0x524143fd, _0x10253c61._0xb9d81a97(new byte[10] { 73, 110, 118, 85, 110, 82, 105, 100, 100, 117 }, 1));
        this._0x598de712 = _0xd70c0cea.gameObject;
        Image _0xa0db4d5a = _0xd70c0cea.gameObject.AddComponent<Image>();
        _0xa0db4d5a.color = _0xa8c1dd53.WithAlpha(_0xa8c1dd53.Ink, 0.86f);
        _0xa0db4d5a.raycastTarget = true;
        _0xa0db4d5a.canvasRenderer.cullTransparentMesh = false;
        Button _0xaf7530eb = _0xd70c0cea.gameObject.AddComponent<Button>();
        _0xaf7530eb.transition = Selectable.Transition.None;
        _0xaf7530eb.onClick.AddListener(() => this._0xed1566f1());
        Image _0xef80adbc = _0x1685b31d.Plate(_0xd70c0cea, _0x10253c61._0xb9d81a97(new byte[9] { 84, 115, 107, 72, 115, 95, 125, 110, 120 }, 28), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(1020f, 1520f), _0x613be34c, _0xa8c1dd53.Gold);
        _0xef80adbc.raycastTarget = true;
        Image _0x46d00a55 = _0x1685b31d.Plate(_0xef80adbc.transform, _0x10253c61._0xb9d81a97(new byte[9] { 37, 2, 26, 57, 2, 47, 2, 9, 20 }, 109), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(984f, 1484f), _0x613be34c, _0xa8c1dd53.Surface);
        _0x1685b31d.Plate(_0x46d00a55.transform, _0x10253c61._0xb9d81a97(new byte[9] { 76, 107, 115, 80, 107, 83, 97, 104, 104 }, 4), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(952f, 1452f), _0x613be34c, _0xa8c1dd53.WithAlpha(_0xa8c1dd53.Night, 0.96f));
        _0x1685b31d.Caption(_0xef80adbc.transform, _0x10253c61._0xb9d81a97(new byte[10] { 97, 70, 94, 125, 70, 125, 64, 93, 69, 76 }, 41), new Vector2(0.5f, 1f), new Vector2(0f, -140f), new Vector2(860f, 120f), _0x10253c61._0xb9d81a97(new byte[11] { 26, 29, 5, 114, 6, 29, 114, 2, 30, 19, 11 }, 82), 60f, _0xa8c1dd53.Gold, TextAlignmentOptions.Center, _0x90186b97);
        this.Step(_0xef80adbc.transform, _0x10253c61._0xb9d81a97(new byte[8] { 204, 235, 250, 239, 203, 234, 237, 241 }, 159), -400f, _0x90186b97, _0x613be34c, _0x10253c61._0xb9d81a97(new byte[35] { 132, 145, 128, 240, 156, 149, 150, 132, 240, 159, 130, 240, 130, 153, 151, 152, 132, 240, 132, 159, 240, 132, 133, 130, 158, 240, 132, 152, 149, 240, 146, 159, 135, 156, 131 }, 208), _0x7c25eac5, _0x5bc28a75, _0xa8c1dd53.Gold);
        this.Step(_0xef80adbc.transform, _0x10253c61._0xb9d81a97(new byte[9] { 54, 17, 0, 21, 38, 4, 17, 6, 13 }, 101), -740f, _0x90186b97, _0x613be34c, _0x10253c61._0xb9d81a97(new byte[34] { 89, 91, 78, 89, 82, 58, 95, 91, 89, 82, 58, 92, 72, 79, 83, 78, 58, 83, 84, 58, 83, 78, 73, 58, 85, 77, 84, 58, 89, 85, 86, 85, 79, 72 }, 26), _0x1f22e7cc, _0x71161376, _0xa8c1dd53.Cream);
        this.Step(_0xef80adbc.transform, _0x10253c61._0xb9d81a97(new byte[9] { 187, 156, 141, 152, 187, 152, 129, 132, 132 }, 232), -1080f, _0x90186b97, _0x613be34c, _0x10253c61._0xb9d81a97(new byte[46] { 53, 58, 37, 54, 83, 32, 35, 58, 63, 63, 32, 83, 54, 61, 55, 83, 39, 59, 54, 83, 33, 60, 38, 61, 55, 121, 53, 58, 63, 63, 83, 50, 63, 63, 83, 53, 60, 38, 33, 83, 60, 33, 55, 54, 33, 32 }, 115), _0x42a33d46, _0x42a33d46, _0xa8c1dd53.Crimson);
        Button _0xd06bf5cf = _0x1685b31d.Action(_0xef80adbc.transform, _0x10253c61._0xb9d81a97(new byte[9] { 165, 130, 154, 185, 130, 169, 130, 131, 136 }, 237), new Vector2(0.5f, 0f), new Vector2(0f, 150f), new Vector2(460f, 150f), _0x613be34c, _0xa8c1dd53.Gold, _0x10253c61._0xb9d81a97(new byte[6] { 187, 179, 168, 220, 181, 168 }, 252), 42f, _0xa8c1dd53.Night, _0x90186b97);
        _0xd06bf5cf.onClick.AddListener(() => this._0xed1566f1());
        Button _0x692e09c7 = _0x1685b31d.IconAction(_0xef80adbc.transform, _0x10253c61._0xb9d81a97(new byte[10] { 220, 251, 227, 192, 251, 215, 248, 251, 231, 241 }, 148), new Vector2(1f, 1f), new Vector2(-84f, -84f), 100f, _0x613be34c, _0xa8c1dd53.WithAlpha(_0xa8c1dd53.SurfaceEdge, 0.98f), _0xa7b50c69, _0xa8c1dd53.Gold);
        _0x692e09c7.onClick.AddListener(() => this._0xed1566f1());
        this._0x598de712.SetActive(false);
    }

    private void Step(Transform _0x3f8be695, string _0xdb079f4a, float _0x4c0c4c51, TMP_FontAsset _0xe23a5755, Sprite _0x406ab411, string _0x1a7eddf1, Sprite _0xf23e29c1, Sprite _0x3075c9a0, Color _0xf5e3338a)
    {
        RectTransform _0x5854f1c8 = _0x1685b31d.Node(_0x3f8be695, _0xdb079f4a, new Vector2(0.5f, 1f), new Vector2(0f, _0x4c0c4c51), new Vector2(880f, 290f));
        _0x1685b31d.Plate(_0x5854f1c8, _0xdb079f4a + _0x10253c61._0xb9d81a97(new byte[6] { 221, 242, 238, 227, 246, 231 }, 130), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(880f, 290f), _0x406ab411, _0xa8c1dd53.WithAlpha(_0xa8c1dd53.Surface, 0.9f));
        _0x1685b31d.Picture(_0x5854f1c8, _0xdb079f4a + _0x10253c61._0xb9d81a97(new byte[5] { 236, 223, 214, 213, 199 }, 179), new Vector2(0.5f, 1f), new Vector2(-130f, -110f), new Vector2(130f, 130f), _0xf23e29c1, Color.white);
        _0x1685b31d.Picture(_0x5854f1c8, _0xdb079f4a + _0x10253c61._0xb9d81a97(new byte[6] { 224, 205, 214, 216, 215, 203 }, 191), new Vector2(0.5f, 1f), new Vector2(130f, -110f), new Vector2(130f, 130f), _0x3075c9a0, Color.white);
        _0x1685b31d.Caption(_0x5854f1c8, _0xdb079f4a + _0x10253c61._0xb9d81a97(new byte[5] { 254, 213, 196, 217, 213 }, 161), new Vector2(0.5f, 0f), new Vector2(0f, 56f), new Vector2(830f, 96f), _0x1a7eddf1, 34f, _0xf5e3338a, TextAlignmentOptions.Center, _0xe23a5755);
    }

    public void _0xcc4cd1e4()
    {
        if (this._0x598de712 != null)
        {
            this._0x598de712.SetActive(true);
            this._0x598de712.transform.SetAsLastSibling();
        }
    }
}

internal static class _0x10253c61
{
    internal static string _0xb9d81a97(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}