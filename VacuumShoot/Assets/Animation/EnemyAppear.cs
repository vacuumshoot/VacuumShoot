using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAppear : MonoBehaviour {

    // 召喚したい敵や、出現して欲しいオブジェクトを入れる
    [SerializeField] GameObject Enemy01;
    [SerializeField] GameObject Obj01;
    [SerializeField] GameObject Obj02;

	[SerializeField]
	GameObject movableArea;
	Vector3 leftDown;// 左下の座標
	Vector3 rightUp;// 右上の座標

	float gameTime = 0f;
    float decimalPoint = 0f;
    // 出現するために必要な時間
    [SerializeField]float summonsTime;
    int choiceNumber;
    Vector3 position;

    // Use this for initialization
    void Start () {
        choiceNumber = 0;

		leftDown = movableArea.transform.position - (movableArea.GetComponent<BoxCollider>().size / 2);
		rightUp = movableArea.transform.position + (movableArea.GetComponent<BoxCollider>().size / 2);
	}
	
	// Update is called once per frame
	void Update () {
        gameTime += Time.deltaTime * 1.0f;
        if (gameTime > summonsTime) {
            GetPosition();
        }

    }

    // 召喚位置をランダムで選ぶ
    void GetPosition() {
		position = new Vector3(Random.Range(leftDown.x, rightUp.x), Random.Range(leftDown.y, rightUp.y), 0.0f);
        Choice();
    }

    // どれを召喚するか選ぶ関数
    void Choice() {
        decimalPoint = Random.Range(-0f, 4f);
        choiceNumber = (int)decimalPoint;
        Summons();
    }

    // 選ばれたものを召喚
    void Summons() {
        if (choiceNumber == 0) {
            Instantiate(Enemy01, position, Quaternion.identity);
        } else if (choiceNumber == 1 || choiceNumber == 2) {
            Instantiate(Obj01, position, Quaternion.identity);
        } else {
            Instantiate(Obj02, position, Quaternion.identity);
        }
        gameTime = 0f;
    }


}
