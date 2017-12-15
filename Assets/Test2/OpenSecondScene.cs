using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class OpenSecondScene : MonoBehaviour {
	
	void Start () {
		GetComponent<Button>().onClick.AddListener(() =>
		{			
			SceneManager.LoadScene("SecondScene");
		});
	}
	
}
