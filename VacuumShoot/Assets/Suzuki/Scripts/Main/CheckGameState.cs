namespace Suzuki
{
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;
	using UnityEngine.UI;

	/// <summary>
	/// ゲームキャラの状態を確認するクラス
	/// ここでクリア、ゲームオーバーや全体の処理を確認する
	/// </summary>
	public class CheckGameState : MonoBehaviour
	{
		PlayerStates player;
		Boss boss;

		// クリア、ゲームオーバーの画像を持つオブジェクト
		public GameObject clearObj;
		public GameObject gameoverObj;

		// Start is called before the first frame update
		void Start()
		{
			boss = GameObject.FindGameObjectWithTag("Boss").GetComponent<Boss>();
			player = GameObject.Find("Player").GetComponent<PlayerStates>();

			clearObj.SetActive(false);
			gameoverObj.SetActive(false);
		}

		// Update is called once per frame
		void Update()
		{
			if(player.HP<=0)
			{
				gameoverObj.SetActive(true);
				Time.timeScale = 0.0f;
			}
			else if(boss.HP<=0)
			{
				clearObj.SetActive(true);
				Time.timeScale = 0.0f;
			}
		}
	}

}
