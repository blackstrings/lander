using UnityEngine;
using System.Collections;

public class CollisionDestroyerByInterface : MonoBehaviour {

    void OnTriggerEnter(Collider col) {
        if (col.gameObject.GetComponent<MonoBehaviour>() is IKillable) {
            Destroy(col.gameObject);
        }
    }
	
}
