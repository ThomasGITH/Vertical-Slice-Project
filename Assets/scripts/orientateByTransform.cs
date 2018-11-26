using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orientateByTransform : MonoBehaviour {
    public Transform objectTransform;
	void Update () {
        transform.rotation = objectTransform.rotation;
	}
}
