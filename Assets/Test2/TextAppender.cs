using Slash.Unity.DataBind.Foundation.Setters;
using UnityEngine;
using UnityEngine.UI;

public class TextAppender : ComponentSingleSetter<Text, TestEnum>
{
	protected override void UpdateTargetValue(Text target, TestEnum value)
	{
		target.text += ">"+value;
	}
}
