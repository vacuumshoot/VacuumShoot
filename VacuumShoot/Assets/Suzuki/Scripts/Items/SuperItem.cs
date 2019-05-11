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
		public int attackPower;     // アイテムが与えるダメージ

		public float shootSpeed;	// 発射時のスピード

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
		protected virtual void VirtualStart() { }
		protected virtual void VirtualUpdate() { }

		public IEnumerator Shoot()
		{
			Vector3 pos = transform.position;
			while (pos.y > -50.0f)
			{
				transform.Translate(0.0f, shootSpeed * Time.deltaTime, 0.0f);

				yield return null;
			}
		}
	}

}