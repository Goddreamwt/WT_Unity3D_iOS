using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonBack1 : MonoBehaviour {

	public Button mButton;

	// Use this for initialization
	void Start () {
		//获取返回按钮
		Button btn = mButton.GetComponent<Button> ();
		//给返回按钮绑定监听器，点击时执行TaskOnclik方法
		btn.onClick.AddListener (TaskOnClick);

	}

	void TaskOnClick(){
		//加载菜单
		Application.LoadLevel (0);
	}
}
