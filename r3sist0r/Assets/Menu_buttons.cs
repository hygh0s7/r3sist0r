using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_buttons : MonoBehaviour {
public GameObject MenuPanel;
public GameObject CharacterPanel;
	// Use this for initialization
	void Start () {
		 MenuPanel.SetActive(true);
         CharacterPanel.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void ShowCharacterPanel()
     {
         MenuPanel.SetActive(false);
         CharacterPanel.SetActive(true);
     }
 
 public void ShowMenuPanel()
     {
         MenuPanel.SetActive(true);
         CharacterPanel.SetActive(false);
     }
}
