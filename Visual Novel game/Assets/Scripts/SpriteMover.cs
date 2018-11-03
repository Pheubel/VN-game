using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteMover : MonoBehaviour {

    [SerializeField] private float _speedX;
    [SerializeField] private float _speedY;

    // Update is called once per frame
    void Update () {
        transform.position += new Vector3(_speedX,_speedY);
	}
}
