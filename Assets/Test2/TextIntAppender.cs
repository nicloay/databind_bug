using System.Collections;
using System.Collections.Generic;
using Slash.Unity.DataBind.Foundation.Setters;
using UnityEngine;
using UnityEngine.UI;

public class TextIntAppender : ComponentSingleSetter<Text, int> {

	
	protected override void UpdateTargetValue(Text target, int value)
	{
		target.text += ">" + value;
	}
}
