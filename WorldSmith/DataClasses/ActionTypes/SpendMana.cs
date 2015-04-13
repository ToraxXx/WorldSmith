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
	[EditorGrammar("Spend %Mana mana points")]
	public partial class SpendMana : BaseAction
	{
		public SpendMana(KeyValue kv)
			: base(kv)
		{
		}
		public SpendMana(string className)
			: base(className)
		{
		}
		[Category("Misc")]
		[Description("int")]
		[DefaultValue(typeof(NumberValue), "")]
		public NumberValue Mana
		{
			get
			{
				KeyValue kv = GetSubkey("Mana");
				return (kv == null ? new NumberValue("Mana") : kv.GetNumberValue());
			}
			set
			{
				KeyValue kv = GetSubkey("Mana");
				if(kv == null)
				{
					kv = new KeyValue("Mana");
					KeyValue.AddChild(kv);
				}
				kv.Set(value);
			}
		}

	}
}
