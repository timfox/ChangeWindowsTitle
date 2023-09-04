using UnityEngine;
using System.Runtime.InteropServices;

public class WindowTitleChanger : MonoBehaviour
{
    public static WindowTitleChanger Instance { get; private set; }
    private System.IntPtr hwnd;

    #if UNITY_STANDALONE_WIN
        [System.Runtime.InteropServices.DllImport("user32.dll", EntryPoint = "FindWindow", SetLastError = true)]
        private static extern System.IntPtr FindWindow(string lpClassName, string lpWindowName);

        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = CharSet.Unicode)]
        private static extern bool SetWindowTextW(System.IntPtr hWnd, string lpString);
    #endif

    public void ChangeTitle(string title)
    {
        #if UNITY_STANDALONE_WIN
            if (hwnd == System.IntPtr.Zero)
            {
                hwnd = FindWindow(null, Application.productName);
            }
            SetWindowTextW(hwnd, title);
        #else
            Debug.LogWarning("WindowTitleChanger Disabled");
        #endif
    }

    void Awake()
    {
        if (Instance == null)
        {
            transform.parent = null;
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}