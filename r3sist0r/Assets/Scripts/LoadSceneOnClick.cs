using UnityEngine;
using System.Collections;

public class LoadSceneOnClick : MonoBehaviour {

    public GameObject MenuPanel;
    public GameObject CharacterPanel;

    public void LoadScene(int level)
    {
    	MenuPanel.SetActive(false);
       CharacterPanel.SetActive(false);
        Application.LoadLevel(level);
    }
}