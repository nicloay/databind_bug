using Slash.Unity.DataBind.Foundation.Setters;
using UnityEngine;
using UnityEngine.UI;

[AddComponentMenu("Data Bind/UnityUI/Setters/[DB] Text Text Setter (Unity)")]
public class TextAppender : ComponentSingleSetter<Text, TestEnum>
{
	protected override void UpdateTargetValue(Text target, TestEnum value)
	{
		target.text += ">"+value;
	}
}
