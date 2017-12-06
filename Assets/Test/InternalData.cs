using System.Collections;
using System.Collections.Generic;
using Slash.Unity.DataBind.Core.Data;
using UnityEngine;

public class InternalData : Context {

	public InternalData(int value)
	{
		IntProp = value;
	}
	
	readonly Property<int> _intPropProperty = new Property<int>(); 
	public int IntProp {
	    get { return this._intPropProperty.Value; }
	    set { this._intPropProperty.Value = value; }
	}
}
