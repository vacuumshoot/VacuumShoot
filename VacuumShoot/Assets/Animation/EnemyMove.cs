using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour {
	Suzuki.Enemy enemy;

	bool destroyed = false;
	Vector3 pos;

	Vector3 targetPosition;

    [SerializeField]
    private float _duration = 1f;

    private float _time = 0;
    //private int _dirFactor = 1;
    private bool _inverse = false;

    private void Update() {
		if (enemy.vacuumTime <= 0.0f)
		{
			destroyed = true;
		}

		if (destroyed)
			return;

        _time += Time.deltaTime;

        // 指定時間を過ぎたら向きを逆に
        if (_time >= _duration) {
            _time = 0;
            _inverse = !_inverse;
        }

        // 時間を媒介変数として計算（0 - 1）
        float t = _time / _duration;

        if (_inverse) {
            transform.position = Vector3.Lerp(pos, targetPosition, 1f - t);
        } else {
            transform.position = Vector3.Lerp(pos, targetPosition, t);
        }

    }
    // Use this for initialization
    void Start () {
		enemy = GetComponent<Suzuki.Enemy>();

		pos = transform.position;

		Vector3 distance = new Vector3(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f), 0.0f);
		targetPosition = pos + distance;
	}
	
}
