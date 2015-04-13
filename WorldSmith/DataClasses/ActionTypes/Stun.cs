/*****************************  NOTICE  ********************************************
* This file was autogenerated.  Do not edit.                                       *
* Instead, modify the schema in DataSchema related to this class and regenerate it *
***********************************************************************************/
using System;
using System.ComponentModel;
using WorldSmith.Panels;
using WorldSmith.Dialogs;
using KVLib;

namespace WorldSmith.DataClasses
{
	[DotaAction]
	[EditorGrammar("Stun %Target for %Duration seconds")]
	public partial class Stun : TargetedAction
	{
		public Stun(KeyValue kv)
			: base(kv)
		{
		}
		public Stun(string className)
			: base(className)
		{
		}
		[Category("Misc")]
		[Description("float")]
		[DefaultValue(typeof(NumberValue), "")]
		public NumberValue Duration
		{
			get
			{
				KeyValue kv = GetSubkey("Duration");
				return (kv == null ? new NumberValue("Duration") : kv.GetNumberValue());
			}
			set
			{
				KeyValue kv = GetSubkey("Duration");
				if(kv == null)
				{
					kv = new KeyValue("Duration");
					KeyValue.AddChild(kv);
				}
				kv.Set(value);
			}
		}

	}
}
