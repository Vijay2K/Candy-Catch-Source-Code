using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    private Mover mover;
    private Health health;

    private void Start() {
        mover = GetComponent<Mover>();
        health = GetComponent<Health>();
    }

    private void Update() {
        if (health.GameOver()) { return; }
        TouchInputs();
    }

    private void TouchInputs() {
        if (Input.touchCount > 0) {
            Touch touch = Input.GetTouch(0);

            //Converting screen pos to world pos
            Vector3 touch_Pos = Camera.main.ScreenToWorldPoint(touch.position);
            if (touch_Pos.x > 0) {
                mover.moveRight();
            } else if (touch_Pos.x < 0) {
                mover.moveLeft();
            }
        } else {
            mover.StopMove();
        }
    }
}
