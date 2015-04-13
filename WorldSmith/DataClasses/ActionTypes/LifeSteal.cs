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
	[EditorGrammar("Steal %LifeStealPercent percent of damage done to %Target")]
	public partial class LifeSteal : TargetedAction
	{
		public LifeSteal(KeyValue kv)
			: base(kv)
		{
		}
		public LifeSteal(string className)
			: base(className)
		{
		}
		[Category("Misc")]
		[Description("float")]
		[DefaultValue(typeof(NumberValue), "")]
		public NumberValue LifeStealPercent
		{
			get
			{
				KeyValue kv = GetSubkey("LifeStealPercent");
				return (kv == null ? new NumberValue("LifeStealPercent") : kv.GetNumberValue());
			}
			set
			{
				KeyValue kv = GetSubkey("LifeStealPercent");
				if(kv == null)
				{
					kv = new KeyValue("LifeStealPercent");
					KeyValue.AddChild(kv);
				}
				kv.Set(value);
			}
		}

	}
}
