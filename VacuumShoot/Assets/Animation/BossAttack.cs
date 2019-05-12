using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAttack : MonoBehaviour {
    float gameTime;
    [SerializeField] float attackTime = 5f;
    [SerializeField] GameObject AttackObj01;
    Animator _animator;
	GameObject player;

    // Use this for initialization
    void Start () {
        gameTime = 0f;
        _animator = GetComponent<Animator>();
		player = GameObject.Find("Player");
    }
	
	// Update is called once per frame
	void Update () {
        gameTime += Time.deltaTime * 1.0f;
        if (gameTime > attackTime) {
            Attack();
        } else {
            _animator.SetInteger("AttackState", 0);
        }
    }

    void Attack() {
        _animator.SetInteger("AttackState", 1);
        //プレイヤーのポジション取得して、その周囲に上からAttackObj01を落とす


        gameTime = 0f;
    }
}
