using UnityEngine;

public class QuitButtonExecution : MonoBehaviour
{
    public void QuitApp()
    {
        Application.Quit();
        UnityEditor.EditorApplication.ExitPlaymode();
    }
}
