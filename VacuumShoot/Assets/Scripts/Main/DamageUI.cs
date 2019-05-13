using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamageUI : MonoBehaviour
{
	public Text damageText;
	public Text comboText;
	float alpha = 1.0f;
	float fadeSpeed = 1.0f;

	public int damageInt = 0;
	public int comboInt = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
		alpha -= fadeSpeed * Time.deltaTime;
		damageText.color = new Color(1.0f, 0.0f, 0.0f, alpha);
		damageText.text = damageInt.ToString() + " Damage";

		comboText.color = new Color(1.0f, 0.0f, 0.0f, alpha);
		comboText.text = comboInt.ToString() + " Combo";

		if (alpha<0.0f)
		{
			Destroy(gameObject);
		}
    }
}
