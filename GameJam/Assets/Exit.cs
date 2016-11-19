using UnityEngine;
using UnityEngine.UI;

public class Exit : MonoBehaviour {

  public Text exitText;

	// Use this for initialization
	void Start () {
    exitText.text = "";
	}
	
	// Update is called once per frame
	void OnTriggerEnter()
  {
    exitText.text = "You sprang it!";
  }
}
