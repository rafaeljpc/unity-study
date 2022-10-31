using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;

public class Trigger : MonoBehaviour {
    public string tagRegExp = "";
    private Regex reTag;

    public void Start() {
        this.reTag = new Regex(tagRegExp);
    }

    public void OnTriggerEnter(Collider collider) {
        if (this.reTag.IsMatch(collider.gameObject.tag)) {
            print("Fire Start");
        }
    }

    public void OnTriggerExit(Collider collider) {
        if (this.reTag.IsMatch(collider.gameObject.tag)) {
            print("Fire End");
        }
    }



}
