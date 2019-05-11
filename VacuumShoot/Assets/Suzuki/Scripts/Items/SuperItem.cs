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

		GameObject bossObj;// ボスの情報
		float elapsedTime = 0.0f;// 経過時間

		bool attacked = false;// ボスと接触したか

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
			bossObj = GameObject.FindGameObjectWithTag("Boss");
		}
		protected virtual void VirtualUpdate() { }

		public IEnumerator Shoot(float shootSpeed)
		{
			Vector3 pos = bossObj.transform.position - transform.position;
			Vector3 vel = pos.normalized;

			// 50秒経過したら終了
			while (elapsedTime < 50.0f && !attacked)
			{
				transform.Translate(
					vel.x * shootSpeed * Time.deltaTime,
					vel.y * shootSpeed * Time.deltaTime,
					vel.z * shootSpeed * Time.deltaTime);

				// 経過時間を加算
				elapsedTime += 1.0f * Time.deltaTime;

				yield return null;
			}
		}

		void OnCollisionEnter(Collision collision)
		{
			if(collision.transform.tag=="Boss")
			{
				collision.gameObject.GetComponent<Boss>().HP -= attackPower;
				attacked = true;
				
				Destroy(this.gameObject);
			}
		}
	}

}