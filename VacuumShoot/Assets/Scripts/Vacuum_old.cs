﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vacuum_old : MonoBehaviour{

    private GameObject vacuumObj = null;
    private GameObject player = null;
    private float vacuumTime = 0;

    // Start is called before the first frame update
    void Start(){
        player = GameObject.FindGameObjectWithTag("Player");        //Playerを探す
        vacuumObj = GameObject.FindGameObjectWithTag("VacuumObject");        //吸い取れるオブジェクトを探す
    }

    // Update is called once per frame
    void Update(){

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
			// 10個以上吸い取らないようにする
			if (player.GetComponent<ShootStack>().VacuumObjects.Count >= 10)
				return;
			
			float vacuumT = col.GetComponent<Suzuki.SuperItem>().vacuumTime -= Time.deltaTime;

			if (vacuumT <= 0.0f)
			{
				//吸いとったアイテムを保持する処理
				//player.GetComponent<ShootStack>().Stack();
				player.GetComponent<ShootStack>().VacuumObjects.Add(col.gameObject);
				col.gameObject.SetActive(false);
			}
        }
    }

}
