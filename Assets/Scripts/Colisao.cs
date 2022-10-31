using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEditor.UIElements;
using UnityEngine;

public class Colisao : MonoBehaviour {

    public string tagRegExp = "";
    private Regex reTag;

    public void Start() {
        this.reTag = new Regex(tagRegExp);
    }

    public void OnCollisionEnter(Collision collision) {
        if (this.reTag.IsMatch(collision.gameObject.tag)) {
            print("Colidiu");
        }
    }

    public void OnCollisionExit(Collision collision) {
        if (this.reTag.IsMatch(collision.gameObject.tag)) {
            print("Saiu Colisao");
        }
    }

}
