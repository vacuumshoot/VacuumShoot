using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vacuum : MonoBehaviour{

    private GameObject vacuumObj = null;
    private GameObject player = null;
    private GameObject stackObj = null;
    private float touchTime = 0;
    bool touch = false;
    bool vacuumItem = false;
    private float vacuumTime = 0;

    // Start is called before the first frame update
    void Start(){
        player = GameObject.FindGameObjectWithTag("Player");        //Playerを探す
        vacuumObj = GameObject.FindGameObjectWithTag("VacuumObject");        //吸い取れるオブジェクトを探す
    }

    // Update is called once per frame
    void Update(){
        if (Input.GetMouseButton(0)){
            //吸い取り時間の開始
            if (touch == true){
                vacuumTime -= Time.deltaTime;
                Debug.Log(vacuumTime);
                if (vacuumTime <= 0){
                    vacuumItem = true;
                }
            }

            //長押しの判定
            //if (touchTime >= 2){

            //}

        }

        if (Input.GetMouseButtonUp(0)){
            //touchTime = 0;
        }

        if (vacuumItem == true){
            //吸いとったアイテムを保持する処理
            player.GetComponent<ShootStack>().Stack();
            player.GetComponent<ShootStack>().VacuumObjects.Add(stackObj);
            vacuumItem = false;
            vacuumTime = 1.0f;
        }

    }

    //吸い切るまでの時間の取得
    private void OnTriggerEnter(Collider col){
        if (col.CompareTag("VacuumObject")){
            vacuumTime = col.gameObject.GetComponent<Suzuki.SuperItem>().vacuumTime;
        }
    }

    //吸い取り可能
    private void OnTriggerStay(Collider col){
        if (col.CompareTag("VacuumObject")) {
            touch = true;
            stackObj = col.gameObject;
        }
    }
    //吸い取り不可能
    private void OnTriggerExit(Collider col){
        if (col.CompareTag("VacuumObject")){
            touch = false;
            vacuumTime = 0;
            stackObj = null;
        }
    }

}
