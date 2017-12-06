using System.Collections;
using System.Collections.Generic;
using Slash.Unity.DataBind.Core.Data;
using UnityEngine;

public class MainData : Context
{

	private static MainData _instance;

	public static MainData Instance
	{
		get
		{
			if (_instance == null)
			{
				_instance = new MainData();
				_instance.Collection.Add(new InternalData(1));
			}
			return _instance;
		}
	}	
	
	readonly Property<Collection<InternalData>> _collectionProperty = new Property<Collection<InternalData>>(new Collection<InternalData>());
	public Collection<InternalData> Collection {
	    get { return this._collectionProperty.Value; }
	    set { this._collectionProperty.Value = value; }
	}
	
	readonly Property<InternalData> _currentPropProperty = new Property<InternalData>(); 
	public InternalData CurrentProp {
	    get { return this._currentPropProperty.Value; }
	    set { this._currentPropProperty.Value = value; }
	}
}