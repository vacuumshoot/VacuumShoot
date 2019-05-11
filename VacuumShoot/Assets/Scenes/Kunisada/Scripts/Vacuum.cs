using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vacuum : MonoBehaviour{

    private GameObject vacuumObj = null;
    private GameObject player = null;
    private float touchTime = 0;

    // Start is called before the first frame update
    void Start(){
        player = GameObject.FindGameObjectWithTag("Player");        //Playerを探す
        vacuumObj = GameObject.FindGameObjectWithTag("VacuumObject");        //吸い取れるオブジェクトを探す
    }

    // Update is called once per frame
    void Update(){
        if (Input.GetMouseButtonDown(0)){
            touchTime += Time.deltaTime;
            //長押しの判定
            //if (touchTime >= 2){

            //}
        }
    }
}
