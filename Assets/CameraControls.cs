using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControls : MonoBehaviour {

	[SerializeField]
    private int orthographicSizeMin;
    [SerializeField]
    private int orthographicSizeMax;
    
    void Update () {
        if(Input.GetAxis("Mouse ScrollWheel") > 0) {
            Camera.main.orthographicSize--;
        }
        if(Input.GetAxis("Mouse ScrollWheel") < 0) {
            Camera.main.orthographicSize++;
        }
        Camera.main.orthographicSize = Mathf.Clamp(Camera.main.orthographicSize, orthographicSizeMin, orthographicSizeMax);

        Camera.main.transform.Translate(new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")));
    }
}
