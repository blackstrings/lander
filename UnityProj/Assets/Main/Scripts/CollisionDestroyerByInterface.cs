using UnityEngine;
using System.Collections;
using LAO.Generic.Destroy;

public class CollisionDestroyerByInterface : MonoBehaviour {

    /// <summary>
    /// Triggers require the object to be a convex mesh and isTrigger is checked
    /// </summary>
    /// <param name="col"></param>
    void OnTriggerEnter(Collider col) {
        if (col.gameObject.tag.Equals("Player")) {
            if (col.gameObject.GetComponent<CubePlayer>() is IKillable) {
                Destroy(col.gameObject);
            }
        }
    }

    /// <summary>
    /// Collisions required colliders but uses Collision as parameter
    /// Also Collision is more about impact so it is more CPU intensive
    /// </summary>
    /// <param name="col"></param>
    /*
    void OnCollisionEnter(Collision col) {
        Destroy(col.gameObject);
    }
    */
	
}
