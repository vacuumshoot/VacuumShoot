namespace Suzuki
{
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;
	using UnityEngine.UI;
	using UnityEngine.SceneManagement;

	/// <summary>
	/// シーン遷移するボタンのスクリプト
	/// ボタンのオブジェクトにアタッチ
	/// 
	/// </summary>
	public class JumpSceneButton : MonoBehaviour
	{
		public void OnClick(string sceneName)
		{
			SceneManager.LoadScene(sceneName);
		}
	}
}
