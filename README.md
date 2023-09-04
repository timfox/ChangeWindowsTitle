# WindowTitleChanger
This Unity Asset provides an easy and efficient way to dynamically change the window title of your Unity game when running on Windows. Whether you need to provide additional context to your players when the game window is minimized, indicate new in-game messages, or update resource spawn information, this asset has you covered.

```C#
using UnityEngine;

public class ExampleUsage : MonoBehaviour
{
    void Start()
    {
        WindowTitleChanger.Instance.ChangeTitle("New Game Title");
    }
}
```

![WindowTitleChanger](https://github.com/timfox/WindowTitleChanger/assets/459247/c73b83a5-7a93-4c8f-a550-cc51387d44f6)
