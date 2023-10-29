using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlGeneral : MonoBehaviour
{
    public void CambioEscena(string Escena)
    {
        SceneManager.LoadScene(Escena);
    }

    public void StopScene()
    {
      Time.timeScale=0f;
    }

      public void PlayScene(){
      Time.timeScale=1f;
    }
      public void quitGame()
    {
      #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
      #endif
      Application.Quit();
    }
}
