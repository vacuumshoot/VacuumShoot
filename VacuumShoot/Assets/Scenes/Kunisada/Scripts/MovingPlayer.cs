using UnityEngine;
using System.Collections;

public class MovingPlayer : MonoBehaviour{

    //Joystick
    [SerializeField]
    private Joystick _joystick = null;

    //移動速度
    [SerializeField]
     float SPEED = 0.1f;

	public GameObject movableArea;
	Vector3 leftDown;// 左下の座標
	Vector3 rightUp;// 右上の座標

	private void Start()
	{
		leftDown = movableArea.transform.position - (movableArea.GetComponent<BoxCollider>().size / 2);
		rightUp = movableArea.transform.position + (movableArea.GetComponent<BoxCollider>().size / 2);
	}

	private void Update(){
        Vector3 pos = transform.position;
        //プレイヤーの縦移動
        pos.x += _joystick.Position.x * SPEED;
        //プレイヤーの横移動
        pos.y += _joystick.Position.y * SPEED;

		if(pos.x<leftDown.x)
		{
			pos.x = leftDown.x;
		}
		else if(pos.x>rightUp.x)
		{
			pos.x = rightUp.x;
		}
		if(pos.y<leftDown.y)
		{
			pos.y = leftDown.y;
		}
		else if(pos.y>rightUp.y)
		{
			pos.y = rightUp.y;
		}

        transform.position = pos;
    }

}