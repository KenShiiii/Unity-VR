using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{


	public float near = 20.0f;
	public float far = 100.0f;

	public float sensitivetyZ = 2f;
	public float sensitivityX = 10f;
	public float sensitivityY = 10f;
	public float sensitivetyMove = 2f;
	public float sensitivetyMouseWheel = 2f;


	void Update()
	{
		// 滾輪實現鏡頭縮排和拉遠

		//滑鼠右鍵實現視角轉動，類似第一人稱視角
		if (Input.GetMouseButton(1))
		{
			float rotationX = Input.GetAxis("Mouse X") * sensitivityX;
			float rotationY = Input.GetAxis("Mouse Y") * sensitivityY;
			transform.Rotate(-rotationY, rotationX, 0);
		}

		//鍵盤按鈕←和→實現視角水平旋轉
		if (Input.GetAxis("Horizontal") != 0)
		{
			float rotationZ = Input.GetAxis("Horizontal") * sensitivetyZ;
			transform.Rotate(0, 0, rotationZ);
		}
	}
}