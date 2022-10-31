using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjeto : MonoBehaviour {
    public Vector3 translateVelocity = new Vector3(0, 0, 0);
    public Vector3 rotationVelocity = new Vector3(0, 0, 0);
    public GameObject obj;

    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        obj.transform.Translate(translateVelocity, Space.Self);
        obj.transform.Rotate(rotationVelocity, Space.Self);
    }
}
