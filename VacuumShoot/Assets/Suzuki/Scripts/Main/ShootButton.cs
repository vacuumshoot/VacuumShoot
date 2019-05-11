namespace Suzuki
{
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;
	using UnityEngine.UI;

	/// <summary>
	/// アイテム発射スクリプト
	/// 発射ボタンに配置し、クリックした時に発射される処理を呼び出す
	/// </summary>
	public class ShootButton : MonoBehaviour
	{
		ShootStack player;
		void Start()
		{
			//player = GameObject.Find("Player").GetComponent<ShootStack>();
		}

		// 発射
		public void OnClick()
		{
			//player.Shoot();
			Debug.Log("Shoot");
		}
	}
}
