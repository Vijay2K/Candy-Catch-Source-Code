using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenBounds : MonoBehaviour
{
    [SerializeField] private float maxPos = 1f;//For Test
    private void Update() {
        float playerMaxPos = Mathf.Clamp(transform.position.x, -maxPos, maxPos);
        transform.position = new Vector3(playerMaxPos, transform.position.y, transform.position.z);
    }

}
