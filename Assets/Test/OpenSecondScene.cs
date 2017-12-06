﻿using System.Collections;
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
			MainData.Instance.CurrentProp = MainData.Instance.Collection.ElementAt(0);
			SceneManager.LoadScene("SecondScene");
		});
	}
	
}
