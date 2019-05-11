using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEditor;

[InitializeOnLoad]
public class GarbageCollectorSetting
{
	class GarbageSetClass
	{
		~GarbageSetClass()
		{
			Debug.Log("Garbage Enabled");
			// エディタ終了時のガベージコレクションを有効化
			GarbageCollector.GCMode = GarbageCollector.Mode.Enabled;
		}
	}

	static GarbageSetClass cls;

	static GarbageCollectorSetting()
	{
		cls = new GarbageSetClass();
	}
}
