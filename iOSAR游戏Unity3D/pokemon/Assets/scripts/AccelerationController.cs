using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccelerationController : MonoBehaviour {

	//位移速度是 200
	float speed = 200;

	//表示屏幕是否被点击的 static 变量
	static bool isTouched = false;

	// Use this for initialization
	void Start () {
		isTouched = false;
	}
	
	// Update is called once per frame
	void Update () {
		 
		//如果被屏幕被点击至少一次
		if (Input.touchCount >= 1) {
			isTouched = true;
		}

		if (isTouched) {
			//表示三维的随重力加速度的位移向量
			Vector3 mMovement = new Vector3 (
				Input.acceleration.x * speed * Time.deltaTime,
				Input.acceleration.y * speed * Time.deltaTime);
			//根据向量来移动游戏对象
			transform.Translate (mMovement);
		}
	}
}
