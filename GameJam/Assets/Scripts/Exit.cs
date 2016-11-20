using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Exit : MonoBehaviour {

  public Text exitText;
  public string nextSceneName;

	// Use this for initialization
	void Start () {
    exitText.text = "";
	}
	
	// Update is called once per frame
	void OnTriggerEnter(Collider other)
  {
    exitText.text = "You sprang it!";
    other.gameObject.SetActive(false);
    if(!String.IsNullOrEmpty(nextSceneName))
      Invoke("LoadNextLevel", 3);
  }

  void LoadNextLevel()
  {
    SceneManager.LoadScene(nextSceneName);
  }
}
