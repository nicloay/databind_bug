using System.Collections;
using System.Collections.Generic;
using Slash.Unity.DataBind.Core.Data;
using UnityEditorInternal;
using UnityEngine;


public enum TestEnum : int
{
	Option1,
	Option2,
	Option3	
}


public class TestData : Context
{
	private static TestData _instance;

	public static TestData Instance
	{
		get
		{
			if (_instance == null)
			{
				_instance = new TestData();
			}
			return _instance;
		}
	}
	private TestData()
	{		
		Debug.Log("Constructor call");
		TestEnum = TestEnum.Option3;
	}
	
	readonly Property<int> _testEnumProperty = new Property<int>(); 
	public TestEnum TestEnum {
		get { return (TestEnum)this._testEnumProperty.Value; }
		set { this._testEnumProperty.Value = (int)value; }
	}
	
//	
//	readonly Property<int> testEnumProperty = new Property<int>(); 
//	public TestEnum TestEnum {
//	    get { return (TestEnum)this.testEnumProperty.Value; }
//	    set { this.testEnumProperty.Value = (int)value; }
//	}
}
