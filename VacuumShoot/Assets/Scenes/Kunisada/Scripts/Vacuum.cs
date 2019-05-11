using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vacuum : MonoBehaviour{

    private GameObject vacuumObj = null;
    private float touchTime = 0;
    bool on = false; 

    // Start is called before the first frame update
    void Start(){
        vacuumObj = GameObject.FindGameObjectWithTag("VacuumObject");        //吸い取れるオブジェクトを探す
    }

    // Update is called once per frame
    void Update(){
        if (Input.GetMouseButtonDown(0)){
            //吸い取り時間の開始
            if (on == true){
                touchTime += Time.deltaTime;
            }
            //長押しの判定
            //if (touchTime >= 2){

            //}
        }
        //吸い取り時間の初期化
        if (Input.GetMouseButtonUp(0)){
            touchTime = 0;
        }
    }
    //吸い取り可能
    private void OnCollisionStay(Collision collision){
        on = true;
    }
    //吸い取り不可能
    private void OnCollisionExit(Collision collision){
        on = false;
    }

}
