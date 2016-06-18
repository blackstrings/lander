using UnityEngine;
using System.Collections;

namespace LAO.Generic {

    public class DestroyMeBelowGround : MonoBehaviour {
        public float yAxis = -10f;
        // Update is called once per frame
        void Update() {
            if (this.gameObject.transform.position.y <= yAxis) {
                Destroy(this.gameObject);
            }
        }
    }

}