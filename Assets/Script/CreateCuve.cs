using UnityEngine;
using System.Collections;

public class CreateCuve : MonoBehaviour
{
    // 生成したいPrefab            
    // クリックした位置座標
    private Vector3 clickPosition;
	[SerializeField]private GameObject cube;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update() { 
        if (Input.GetMouseButtonDown( 0 ) )
        {
            clickPosition = Input.mousePosition;
            // Z軸修正
            clickPosition.z = 10f;
            // オブジェクト生成 : オブジェクト(GameObject), 位置(Vector3), 角度(Quaternion)
            // ScreenToWorldPoint(位置(Vector3))：スクリーン座標をワールド座標に変換する
            cube = (GameObject)Resources.Load("Prefab/BelconTest");
            Instantiate(cube, Camera.main.ScreenToWorldPoint(clickPosition), cube.transform.rotation);
        }
    }
}




