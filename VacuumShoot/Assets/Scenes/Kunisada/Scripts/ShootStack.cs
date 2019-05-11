using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootStack : MonoBehaviour{
    public List<GameObject> VacuumObjects = new List<GameObject>();
    private int length;
    int shootStack = 0;

    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        
    }

    public void Shoot(){
        length = VacuumObjects.Count;
        for (int i = 0; i < length; i++) {
            Rigidbody rb = VacuumObjects[i].GetComponent<Rigidbody>();  // rigidbodyを取得
            Vector3 force = new Vector3(0.0f, 0.0f, 1.0f);    // 力を設定
            rb.AddForce(force);  // 力を加える
        }
    }
    public void Stack(){
        shootStack++;
    }

}
