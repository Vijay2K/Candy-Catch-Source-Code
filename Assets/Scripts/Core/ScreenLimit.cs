using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenLimit : MonoBehaviour
{
    private Vector2 screenBound;
    private float playerWidth;

    private void Start() {
        screenBound = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        playerWidth = transform.GetChild(0).GetComponent<SpriteRenderer>().bounds.size.x / 2;
    }

    private void LateUpdate() {
        Vector2 viewPos = transform.position;
        viewPos.x = Mathf.Clamp(viewPos.x, screenBound.x * -1 + playerWidth, screenBound.x - playerWidth);
        transform.position = viewPos;
    }
}
