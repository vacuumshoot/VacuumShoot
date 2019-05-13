namespace Suzuki
{
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public class Enemy : SuperItem
	{
		public float attackInterval;// 攻撃の間隔
		float interval;

		protected override void VirtualStart()
		{
			interval = attackInterval;
			base.VirtualStart();
		}

		// Update is called once per frame
		protected override void VirtualUpdate()
		{
			interval -= 1.0f * Time.deltaTime;
			AttackCheck();
			base.VirtualUpdate();
		}

		// 攻撃の確認
		void AttackCheck()
		{
			if(interval<=0.0f)
			{
				// 攻撃
				Debug.Log("Attack");

				interval = attackInterval;
			}
		}
	}
}
