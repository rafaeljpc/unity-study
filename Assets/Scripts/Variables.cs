using System.Linq;
using UnityEngine;

public class Variables : MonoBehaviour {


    // Start is called before the first frame update
    void Start() {
        var range = Enumerable.Range(1, 10);

        range.ToList().ForEach((i) => print($"count {i}"));
    }

    // Update is called once per frame
    void Update() {

    }
}
