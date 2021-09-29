using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
   
    public string playerName;
  
    void OnGUI()
    {
        playerName = GUI.TextArea(new Rect(500, 200, 100, 20), playerName, 10);
        
    }
   

    // Update is called once per frame
    void Update()
    {
        
        
    }

    void SelectName()
    {
        if(playerName != null)
        Player.instance.name = playerName;

    }

    public void StartGame()
    {
        SelectName();
        SceneManager.LoadScene(1);

    }
}
