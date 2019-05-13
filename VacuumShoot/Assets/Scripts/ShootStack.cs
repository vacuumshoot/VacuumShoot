using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootStack : MonoBehaviour{
	double[] damageUp = { 1, 1.1, 1.2, 1.2, 1.5, 1.6, 1.6, 1.8, 1.9, 2.5 };

    public List<GameObject> VacuumObjects = new List<GameObject>();
    private int length;
    [SerializeField]
    float force = 3.0f;

    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        
    }
    //リストの初期化
    public void Clear(){

        VacuumObjects.Clear();

    }
    public void Stack(){
    }
    //球を自分の位置に移動させ発射するスクリプト
    public IEnumerator Shoot(){
        length = VacuumObjects.Count;
        for (int i = 0; i < length; i++){
            VacuumObjects[i].SetActive(true);
            VacuumObjects[i].transform.position = this.transform.position;

			// 自身のコンボ数(順番を格納)
			VacuumObjects[i].GetComponent<Suzuki.SuperItem>().thisCombo += i;
			// コンボが上がるごとに与えるダメージが上昇する
			int attack = VacuumObjects[i].GetComponent<Suzuki.SuperItem>().attackPower;
			double up = damageUp[i] * attack;
			VacuumObjects[i].GetComponent<Suzuki.SuperItem>().attackPower = (int)up;

			StartCoroutine(VacuumObjects[i].GetComponent<Suzuki.SuperItem>().Shoot(force));
            yield return new WaitForSeconds(0.5f);
        }

        Clear();

    }

}
