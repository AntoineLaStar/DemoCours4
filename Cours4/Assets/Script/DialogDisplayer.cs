using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogDisplayer : MonoBehaviour {
    private Text textcomponent;

	// Use this for initialization
	void Start () {
        textcomponent = gameObject.GetComponentInChildren<Text>();
	}

    public void SetDialogtext(string newDialogtext)
    {
        textcomponent.text = newDialogtext;
    }

    public void CloseDialog()
    {
        Destroy(gameObject);
    }

}
