using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube : MonoBehaviour {
	// 生成したいPrefab
	static public GameObject Prefab;
	// クリックした位置座標
	private Vector3 clickPosition;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		// マウス入力で左クリックをした瞬間
		if (Input.GetMouseButtonDown(0)) {
			clickPosition = Input.mousePosition;
			clickPosition.z = 10f;
			GameObject cube = (GameObject)Resources.Load ("Prefab/Cube");
			// ScreenToWorldPoint(位置(Vector3))：スクリーン座標をワールド座標に変換する
			Instantiate(cube, Camera.main.ScreenToWorldPoint(clickPosition), cube.transform.rotation);
		}
	}
}
