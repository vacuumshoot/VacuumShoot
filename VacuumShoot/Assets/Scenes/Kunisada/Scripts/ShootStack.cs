using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootStack : MonoBehaviour{
    public List<GameObject> VacuumObjects = new List<GameObject>();
    private int length;
    [SerializeField]
    float force = 3.0f;
    int shootStack = 0;

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
        shootStack++;
    }
    //球を自分の位置に移動させ発射するスクリプト
    public IEnumerator Shoot(){
        length = VacuumObjects.Count;
        for (int i = 0; i < length; i++){
            VacuumObjects[i].transform.position = this.transform.position;
            VacuumObjects[i].SetActive(true);
            StartCoroutine(VacuumObjects[i].GetComponent<Suzuki.SuperItem>().Shoot(force));
            Rigidbody rb = VacuumObjects[i].GetComponent<Rigidbody>();  // rigidbodyを取得
            yield return new WaitForSeconds(0.5f);
        }

        Clear();

    }

}
