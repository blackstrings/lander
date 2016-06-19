using UnityEngine;
using LAO.Generic.Destroy;

public class DestroyerCollisionInterface : MonoBehaviour {
    public string targetTagName;
    public bool enable = false;

    /// <summary>
    /// Triggers require the gameobject this script is on to be a convex mesh and isTrigger is checked
    /// </summary>
    /// <param name="col"></param>
    void OnTriggerEnter(Collider col) {
        if (enable) {
            if (col.gameObject.tag.Equals(targetTagName)) {
                Destroy(col.gameObject);
                //if you want to go by interface
                /*
                if (col.gameObject.GetComponent<CubePlayer>() is IKillable) {
                    Destroy(col.gameObject);
                }
                */
            } else {
                Debug.Log("tag name not set");
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
        if (col.gameObject.tag.Equals("Player")) {
            Destroy(col.gameObject);
        }
        
    }
    */

}