using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

	public float MoveSpeed;
	private Vector3 dir;

	//第一人稱視角旋轉
	private Transform camTrans;
	private Vector3 camAng;
	public float camHeight; //可以在unity測試中調整攝像機高度

	void Start () {
		
		camTrans = Camera.main.transform;
		Vector3 startPos = transform.position;
		startPos.y += camHeight;
		startPos.z += 1.3f;
		camTrans.position = startPos;
		camTrans.rotation = transform.rotation;
		camAng = camTrans.eulerAngles;

	}

	// Update is called once per frame
	void Update () {
			PlayerMove ();
			Rotate ();
			Screen.lockCursor = true;
	}

	private void PlayerMove()
	{
		float h = Input.GetAxis("Horizontal");
		float v = Input.GetAxis("Vertical");
		dir = new Vector3(h, 0, v);
		transform.Translate(dir * Time.deltaTime * MoveSpeed, Space.Self);
	}
	private void Rotate()
	{
		//相機隨鼠標旋轉
		float y = Input.GetAxis("Mouse X");
		float x = Input.GetAxis("Mouse Y");
		camAng.x -= x;
		camAng.y += y * 2.5f;
		camTrans.eulerAngles = camAng;
		//設置物體與相機的Y旋轉方向一致
		camTrans.position = new Vector3(this.transform.position.x, camTrans.position.y, this.transform.position.z);
		float camy = camAng.y;
		this.transform.eulerAngles = new Vector3(this.transform.eulerAngles.x, camy, this.transform.eulerAngles.z);
		//更新攝像機位置
		Vector3 startPos = transform.position;
		startPos.y += camHeight;
		camTrans.position = startPos;
	}
}
