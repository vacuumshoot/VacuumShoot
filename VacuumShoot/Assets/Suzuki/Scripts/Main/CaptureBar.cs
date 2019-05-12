namespace Suzuki
{
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;
	using UnityEngine.UI;

	/// <summary>
	/// 敵の吸い取りゲージを表示するバー
	/// </summary>
	public class CaptureBar : MonoBehaviour
	{
		SuperItem enemy;
		Image captureBar;

		float maxVacuumTime;

		// Start is called before the first frame update
		void Start()
		{
			var parent = transform.parent;
			while(parent!=null)
			{
				enemy = parent.GetComponent<SuperItem>();
				if(enemy)
				{
					break;
				}
				else
				{
					parent = parent.parent;
				}
			}
			captureBar = GetComponent<Image>();

			maxVacuumTime = enemy.vacuumTime;
		}

		// Update is called once per frame
		void Update()
		{
			captureBar.fillAmount = enemy.vacuumTime / maxVacuumTime;
		}
	}
}
