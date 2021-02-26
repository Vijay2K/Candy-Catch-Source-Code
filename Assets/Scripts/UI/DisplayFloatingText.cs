using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayFloatingText : MonoBehaviour
{
    [SerializeField] private GameObject floatingText = null;

    public void DisplayText() {
        Instantiate(floatingText, transform.position, Quaternion.identity);
    }
}
