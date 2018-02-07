using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreationBox : MonoBehaviour {

    private bool isSelecting = false;
    private Vector2 selectionStart;
    private Vector2 selectionEnd;
    [SerializeField]
    private Texture selectTexture;

	void Update () {
		if(!isSelecting && Input.GetMouseButtonDown(0)) {
            isSelecting = true;
            selectionStart = Input.mousePosition;
        }

        if(isSelecting && Input.GetMouseButtonUp(0)) {
            isSelecting = false;
            selectionEnd = Input.mousePosition;
        }
	}

    void OnGUI() {
        if(isSelecting) {
            Rect selectRect = new Rect();
            selectRect.x = selectionStart.x;
            selectRect.y = Screen.height - selectionStart.y;
            selectRect.width = Input.mousePosition.x - selectionStart.x;
            selectRect.height = -1 * ((Screen.height - selectionStart.y) - (Screen.height - Input.mousePosition.y));
            Debug.Log(selectRect);
            GUI.DrawTexture(selectRect, selectTexture);
        }
    }
}
