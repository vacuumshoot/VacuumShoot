using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemStack : MonoBehaviour
{
	public List<Image> stackGameObjects;// スタック先オブジェクトの場所格納
	public Sprite nonSprite;// 何も格納されていない場合に入れる画像

	ShootStack vacuumStack;

    // Start is called before the first frame update
    void Start()
    {
		vacuumStack = GameObject.Find("Player").GetComponent<ShootStack>();
    }

	// Update is called once per frame
	void Update()
	{
		if (vacuumStack.VacuumObjects.Count == 0)
		{
			foreach (var obj in stackGameObjects)
			{
				obj.sprite = nonSprite;
			}
		}
		else
		{
			int count = vacuumStack.VacuumObjects.Count;
			for (int i = 0; i < count; ++i)
			{
				stackGameObjects[i].sprite =
					vacuumStack.VacuumObjects[i].GetComponent<SpriteRenderer>().sprite;
			}
		}
	}

	void ObjectStack()
	{

	}
}
