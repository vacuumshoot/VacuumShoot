using UnityEngine;
using System.Collections;

public class MovingPlayer : MonoBehaviour{

    //Joystick
    //[SerializeField]
    //private Joystick _joystick = null;

    //移動速度
    [SerializeField]
     float SPEED = 0.1f;

    private void Update(){
        Vector3 pos = transform.position;
        //プレイヤーの縦移動
        //pos.x += _joystick.Position.x * SPEED;
        //プレイヤーの横移動
        //pos.y += _joystick.Position.y * SPEED;

        //transform.position = pos;
    }

}