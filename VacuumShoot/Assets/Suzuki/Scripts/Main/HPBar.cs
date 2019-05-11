namespace Suzuki
{
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;
	using UnityEngine.UI;

	/// <summary>
	/// HPバーを管理するスクリプト
	/// プレイヤーのHPを見てバーのサイズを変更する
	/// </summary>
	public class HPBar : MonoBehaviour
	{
		PlayerStates states;
		Image HPBarImage;

		// Start is called before the first frame update
		void Start()
		{
			states = GameObject.Find("Player").GetComponent<PlayerStates>();
			HPBarImage = gameObject.GetComponent<Image>();
		}

		// Update is called once per frame
		void Update()
		{
			HPBarImage.fillAmount = (float)states.HP / states.MaxHP;
		}
	}
}
