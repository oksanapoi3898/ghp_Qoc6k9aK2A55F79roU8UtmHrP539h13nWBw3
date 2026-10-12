using UnityEngine;

public class _0x80c747d0 : MonoBehaviour
{
    public bool IsSkipSplashEnabled;
    public bool IsOnlyWinGameEndEnabled;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this.gameObject.GetComponent<_0x80c747d0>();
            DontDestroyOnLoad(this.gameObject);
            this._0xce95d3ed();
        }
        else
        {
            this._0x7b4e4b36();
            Destroy(this.gameObject);
        }
    }

    public bool IsStoryEnabled;
    public static _0x80c747d0 Instance;
    private void _0x7b4e4b36()
    {
    }

    public bool IsLevelIncrementOnWin;
    private void _0xce95d3ed()
    {
        {
#if !B_LOGS
        {
            Debug.unityLogger.logEnabled = false;
            Application.SetStackTraceLogType(LogType.Assert, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Exception, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Warning, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Error, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Log, StackTraceLogType.None);
        }
#endif
        }

        QualitySettings.vSyncCount = 1;
        Application.runInBackground = true;
    //Application.targetFrameRate = 60;
    // Time.fixedDeltaTime = 0.03f; // USE CUSTOM PHYSICS TIME FOR OPTIMIZATION IF NEEDED
    // Add this once at startup to silence the specific assertion
    }

    public bool IsCheckScoreEnabled;
    public bool IsTimerEnabled;
    public bool IsLevelSelectorEnabled;
    public bool IsTutorialEnabled;
    public bool IsBestScoreEnabled;
}