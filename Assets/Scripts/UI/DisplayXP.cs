using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayXP : MonoBehaviour
{
    [SerializeField] private GameObject yummyText = null;

    public void XPDisplay() {
        GameObject dislpayInstance = Instantiate(yummyText, transform.position, Quaternion.identity);
        Destroy(dislpayInstance, 1f);
    }
}
