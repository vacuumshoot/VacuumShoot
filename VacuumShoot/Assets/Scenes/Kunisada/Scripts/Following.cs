using UnityEngine;
using System.Collections;
//カメラにアタッチされている
//カメラの移動
public class Following : MonoBehaviour {

	private GameObject player = null;
	private Vector3 offset = Vector3.zero;  //offsetの初期化

	void Start () {
		player = GameObject.FindGameObjectWithTag("Player");		//Playerを探す
		offset = transform.position - player.transform.position;	//自分の位置からPlayerの位置を引く
		
	}

	void LateUpdate () {
		if(player != null){
					Vector3 newPosition = transform.position;					//Playerを追従する
					newPosition.x = player.transform.position.x + offset.x;											//カメラのx軸の位置
					newPosition.y = player.transform.position.y + offset.y;									    //カメラのy軸の位置//1.64
					newPosition.z = player.transform.position.z + offset.z;		//カメラのz軸の位置
					transform.position = newPosition;
			
		}
	}
}
