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
	[EditorGrammar("Create %ItemName within a %SpawnRadius unit radius around %Target with %ItemChargeCount charges and belongs to caster %BelongsToCaster")]
	public partial class CreateItem : TargetedAction
	{
		public CreateItem(KeyValue kv)
			: base(kv)
		{
		}
		public CreateItem(string className)
			: base(className)
		{
		}
		[Category("Misc")]
		[Description("No Description Set")]
		[DefaultValue("")]
		public string ItemName
		{
			get
			{
				KeyValue kv = GetSubkey("ItemName");
				return (kv == null ? "" : kv.GetString());
			}
			set
			{
				KeyValue kv = GetSubkey("ItemName");
				if(kv == null)
				{
					kv = new KeyValue("ItemName");
					KeyValue.AddChild(kv);
				}
				kv.Set(value);
			}
		}

		[Category("Misc")]
		[Description("No Description Set")]
		[DefaultValue(typeof(NumberValue), "")]
		public NumberValue SpawnRadius
		{
			get
			{
				KeyValue kv = GetSubkey("SpawnRadius");
				return (kv == null ? new NumberValue("SpawnRadius") : kv.GetNumberValue());
			}
			set
			{
				KeyValue kv = GetSubkey("SpawnRadius");
				if(kv == null)
				{
					kv = new KeyValue("SpawnRadius");
					KeyValue.AddChild(kv);
				}
				kv.Set(value);
			}
		}

		[Category("Misc")]
		[Description("No Description Set")]
		[DefaultValue(typeof(NumberValue), "")]
		public NumberValue ItemChargeCount
		{
			get
			{
				KeyValue kv = GetSubkey("ItemChargeCount");
				return (kv == null ? new NumberValue("ItemChargeCount") : kv.GetNumberValue());
			}
			set
			{
				KeyValue kv = GetSubkey("ItemChargeCount");
				if(kv == null)
				{
					kv = new KeyValue("ItemChargeCount");
					KeyValue.AddChild(kv);
				}
				kv.Set(value);
			}
		}

		[Category("Misc")]
		[Description("No Description Set")]
		[DefaultValue("")]
		public string BelongsToCaster
		{
			get
			{
				KeyValue kv = GetSubkey("BelongsToCaster");
				return (kv == null ? "" : kv.GetString());
			}
			set
			{
				KeyValue kv = GetSubkey("BelongsToCaster");
				if(kv == null)
				{
					kv = new KeyValue("BelongsToCaster");
					KeyValue.AddChild(kv);
				}
				kv.Set(value);
			}
		}

	}
}
