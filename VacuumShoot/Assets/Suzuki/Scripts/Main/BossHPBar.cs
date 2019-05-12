namespace Suzuki
{
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;
	using UnityEngine.UI;

	/// <summary>
	/// ボスのHPを表示
	/// </summary>
	public class BossHPBar : MonoBehaviour
	{
		Boss boss;
		Image HPBar;

		int maxHP;

		// Start is called before the first frame update
		void Start()
		{
			boss = GameObject.FindGameObjectWithTag("Boss").GetComponent<Boss>();

			HPBar = GetComponent<Image>();

			maxHP = boss.HP;
		}

		// Update is called once per frame
		void Update()
		{
			HPBar.fillAmount = (float)boss.HP / maxHP;
		}
	}
}
