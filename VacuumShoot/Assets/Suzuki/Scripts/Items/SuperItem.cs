namespace Suzuki
{
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	/// <summary>
	/// ステージ上に配置する配置物をアイテムとする
	/// アイテムの親クラス
	/// アイテムごとに何らかの処理があることを考え継承を行えるようにする
	/// </summary>
	public class SuperItem : MonoBehaviour
	{
		public float vacuumTime;	// 吸い込み時間
		public int attackPower;		// アイテムが与えるダメージ

		// Start is called before the first frame update
		void Start()
		{
			VirtualStart();
		}

		// Update is called once per frame
		void Update()
		{
			VirtualUpdate();
		}

		// 仮想関数 子クラスはこれを継承する
		public virtual void VirtualStart() { }
		public virtual void VirtualUpdate() { }
	}

}