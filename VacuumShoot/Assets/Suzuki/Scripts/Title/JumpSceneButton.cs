namespace Suzuki
{
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;
	using UnityEngine.UI;
	using UnityEngine.SceneManagement;
	using UnityEngine.Scripting;

	/// <summary>
	/// シーン遷移するボタンのスクリプト
	/// ボタンのオブジェクトにアタッチ
	/// 
	/// </summary>
	public class JumpSceneButton : MonoBehaviour
	{
		void Start()
		{
			// ガベージコレクション有効化
			GarbageCollector.GCMode = GarbageCollector.Mode.Enabled;
		}

		/// <summary>
		/// シーン遷移
		/// </summary>
		/// <param name="sceneName">移動先のシーン名</param>
		public void OnClick(string sceneName)
		{
			// ガベージコレクション無効化
			GarbageCollector.GCMode = GarbageCollector.Mode.Disabled;
			// シーン遷移
			SceneManager.LoadScene(sceneName);
		}
	}
}
