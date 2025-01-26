using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
	public void OnPlayButton() 
	{ 
		SceneManager.LoadScene("Levels");
	}
	public void OnOptionsButton() 
	{ 
		SceneManager.LoadScene("Options");
	}
	public void OnQuitButton() 
	{
		Application.Quit();
	}
}
