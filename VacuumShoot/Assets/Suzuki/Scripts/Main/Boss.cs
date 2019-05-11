namespace Suzuki
{
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	/// <summary>
	/// ボスキャラのスクリプト
	/// </summary>
	public class Boss : MonoBehaviour
	{
		public int HP;// 体力
		GameObject player;// プレイヤー情報

		// Start is called before the first frame update
		void Start()
		{
			player = GameObject.Find("Player");
		}

		// Update is called once per frame
		void Update()
		{
			CheckHP();
		}

		void CheckHP()
		{
			if(HP<=0)
			{
				Destroy(this.gameObject);
			}
		}
	}
}
