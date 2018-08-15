using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button1Click : MonoBehaviour {

	public Button mButton;

	// Use this for initialization
	void Start () {
		//获取按钮一
		Button btn = mButton.GetComponent<Button> ();
		//给按钮一绑定监听器，点击时执行TaskOnclik方法
		btn.onClick.AddListener (TaskOnClick);

	}
	
	void TaskOnClick(){
		//加载场景一
		Application.LoadLevel (1);
	}
}
