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

		public float shootSpeed;    // 発射時のスピード

		GameObject bossObj;// ボスの情報

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
		protected virtual void VirtualStart()
		{
			bossObj = GameObject.Find("Boss");
			StartCoroutine(Shoot());
		}
		protected virtual void VirtualUpdate() { }

		public IEnumerator Shoot()
		{
			Vector3 pos = bossObj.transform.position - transform.position;
			Vector3 vel = pos.normalized;
			while (transform.position.y > -50.0f)
			{
				transform.Translate(
					vel.x * shootSpeed * Time.deltaTime,
					vel.y * shootSpeed * Time.deltaTime,
					vel.z * shootSpeed * Time.deltaTime);

				yield return null;
			}

			Destroy(this);
		}
	}

}