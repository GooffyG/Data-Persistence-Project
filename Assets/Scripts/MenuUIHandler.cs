using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEditor;



public class MenuUIHandler : MonoBehaviour
{
    [SerializeField] Text PlayerNameInput;
    // Start is called before the first frame update
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void SetPlayerName() 
    { 
        PlayerDataHandle.Instance.PlayerName = PlayerNameInput.text; 
    }

    public void ExitGame()
    {
#if UNITY_EDITOR  
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); 
#endif
    }
}
