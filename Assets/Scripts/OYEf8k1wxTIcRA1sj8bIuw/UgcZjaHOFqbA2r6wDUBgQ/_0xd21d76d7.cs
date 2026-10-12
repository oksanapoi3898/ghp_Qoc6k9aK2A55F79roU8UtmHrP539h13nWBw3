using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public static class _0xd21d76d7
{
    public static class _0x80e81cfa
    {
        public static int _0xdd26d0ea
        {
            get
            {
                if (!PlayerPrefs.HasKey(_0x86b9d5b5._0xa4c62628(new byte[5] { 123, 87, 81, 86, 75 }, 56)))
                    PlayerPrefs.SetInt(_0x86b9d5b5._0xa4c62628(new byte[5] { 222, 242, 244, 243, 238 }, 157), 0);
                return PlayerPrefs.GetInt(_0x86b9d5b5._0xa4c62628(new byte[5] { 250, 214, 208, 215, 202 }, 185));
            }

            set
            {
                PlayerPrefs.SetInt(_0x86b9d5b5._0xa4c62628(new byte[5] { 124, 80, 86, 81, 76 }, 63), value);
                _0xc4913dd8.Instance._0xcc72031c();
            }
        }
    }

    public static class _0xc4101fb1
    {
        public static readonly int SPLASH = 0;
        public static readonly int DEFAULT = 1;
        public static readonly int EMPTY = 2;
        public static readonly int TUTORIAL0 = 13;
        public static readonly int TUTORIAL1 = 14;
        public static readonly int TUTORIAL2 = 15;
        public static readonly int TUTORIAL3 = 16;
        public static readonly int TUTORIAL4 = 17;
        public static readonly int TUTORIAL5 = 18;
        public static readonly int TUTORIAL6 = 19;
    }

    public static class _0xdc6ccd34
    {
        public static readonly int PAUSE = 6;
        public static readonly int WIN = 7;
        public static readonly int LOSE = 8;
    }

    public class _0xc6c47b7b
    {
        private static readonly _0xc6c47b7b _0xa03adc31 = new();
        public static readonly _0xc6c47b7b[] ALL_SCENES_SETTING_SINGLETONS =
        {
            _0xa03adc31,
            _0xa03adc31,
            _0xa03adc31,
        };
        private int _0x89daebb5 => 0;
        private int _0xfe0a5e6b => 10;
        private string _0x525b3393 => _0x86b9d5b5._0xa4c62628(new byte[4] { 167, 143, 132, 159 }, 234);
        private string _0x01912e22 => _0x86b9d5b5._0xa4c62628(new byte[8] { 175, 166, 181, 166, 175, 152, 211, 158 }, 227);

        private int _0xefa157f8
        {
            get
            {
                if (!PlayerPrefs.HasKey(_0x86b9d5b5._0xa4c62628(new byte[25] { 235, 221, 218, 218, 205, 198, 220, 239, 196, 199, 202, 201, 196, 235, 192, 201, 216, 220, 205, 218, 225, 198, 204, 205, 208 }, 168)))
                    PlayerPrefs.SetInt(_0x86b9d5b5._0xa4c62628(new byte[25] { 185, 143, 136, 136, 159, 148, 142, 189, 150, 149, 152, 155, 150, 185, 146, 155, 138, 142, 159, 136, 179, 148, 158, 159, 130 }, 250), 0);
                return PlayerPrefs.GetInt(_0x86b9d5b5._0xa4c62628(new byte[25] { 99, 85, 82, 82, 69, 78, 84, 103, 76, 79, 66, 65, 76, 99, 72, 65, 80, 84, 69, 82, 105, 78, 68, 69, 88 }, 32));
            }

            set => PlayerPrefs.SetInt(_0x86b9d5b5._0xa4c62628(new byte[25] { 62, 8, 15, 15, 24, 19, 9, 58, 17, 18, 31, 28, 17, 62, 21, 28, 13, 9, 24, 15, 52, 19, 25, 24, 5 }, 125), value);
        }

        public int _0xb7ec016a
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0x525b3393}CurrentLevelIndex"))
                    PlayerPrefs.SetInt($"{this._0x525b3393}CurrentLevelIndex", 0);
                return PlayerPrefs.GetInt($"{this._0x525b3393}CurrentLevelIndex");
            }

            set => PlayerPrefs.SetInt($"{this._0x525b3393}CurrentLevelIndex", value);
        }

        public int _0x21a65b0d
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0x525b3393}BestScore"))
                    this._0x21a65b0d = 0;
                return PlayerPrefs.GetInt($"{this._0x525b3393}BestScore");
            }

            set => PlayerPrefs.SetInt($"{this._0x525b3393}BestScore", value);
        }

        public bool _0xa535c4cb
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0x525b3393}IsGameTutorPassed"))
                    PlayerPrefs.SetInt($"{this._0x525b3393}IsGameTutorPassed", Convert.ToInt32(false));
                return PlayerPrefs.GetInt($"{this._0x525b3393}IsGameTutorPassed") == 1;
            }

            set => PlayerPrefs.SetInt($"{this._0x525b3393}IsGameTutorPassed", Convert.ToInt32(value));
        }
    }

    public static class _0x550bdfca
    {
        public static readonly int SCENE_0 = 0;
        public static readonly int SCENE_1 = 1;
    }
}

internal static class _0x86b9d5b5
{
    internal static string _0xa4c62628(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}