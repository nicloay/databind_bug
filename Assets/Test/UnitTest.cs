using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;
using UnityEngine.UI;

public class UnitTest : MonoBehaviour {

	[UnityTest]
	IEnumerator Start () {
		SceneManager.LoadScene("MainScene");
		yield return null;
		Assert.AreEqual("1", GetTextValue());
		MainData.Instance.CurrentProp = MainData.Instance.Collection.ElementAt(0);
		SceneManager.LoadScene("SecondScene");
		yield return null;
		MainData.Instance.CurrentProp.IntProp = 2;
		yield return null;
		SceneManager.LoadScene("MainScene");
		yield return null;
		Assert.AreEqual("2", GetTextValue());
	}

	string GetTextValue()
	{
		return GameObject.Find("Collection").transform.GetChild(0).GetComponent<Text>().text;
	}
	
}
