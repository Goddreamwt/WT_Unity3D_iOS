using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button2Click : MonoBehaviour {

	public Button mButton;

	// Use this for initialization
	void Start () {
		//获取按钮二
		Button btn = mButton.GetComponent<Button> ();
		//给按钮二绑定监听器，点击时执行TaskOnclik方法
		btn.onClick.AddListener (TaskOnClick);

	}

	void TaskOnClick(){
		//加载场景二
		Application.LoadLevel (2);
	}
}
