using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemStack : MonoBehaviour
{
	public List<Image> stackGameObjects;// スタック先オブジェクトの場所格納

	ShootStack vacuumStack;

    // Start is called before the first frame update
    void Start()
    {
		vacuumStack = GameObject.Find("Player").GetComponent<ShootStack>();
    }

	// Update is called once per frame
	void Update()
	{
		int count = vacuumStack.VacuumObjects.Count;
		for(int i= 0;i<count;++i)
		{
			stackGameObjects[i].sprite =
				vacuumStack.VacuumObjects[i].GetComponent<SpriteRenderer>().sprite;
		}

	}

	void ObjectStack()
	{

	}
}
