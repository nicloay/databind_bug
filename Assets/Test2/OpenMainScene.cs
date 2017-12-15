﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class OpenMainScene : MonoBehaviour {
	
	void Start ()
	{
		GetComponent<Button>().onClick.AddListener(() => SceneManager.LoadScene("MainScene"));
	}

}
