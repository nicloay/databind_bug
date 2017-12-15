using System.Collections;
using System.Collections.Generic;
using Slash.Unity.DataBind.Core.Presentation;
using UnityEngine;

[RequireComponent(typeof(ContextHolder))]
public class ContextInitializer : MonoBehaviour {

	void Awake()
	{
		GetComponent<ContextHolder>().Context = TestData.Instance;
	}
}
