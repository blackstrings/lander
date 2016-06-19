using UnityEngine;
using System.Collections;

public class MovementController : MonoBehaviour {

    public GameObject activeGO;

    void Start() {
        setActiveGO();
    }

    //not needed with singleton
    private void setActiveGO() {
        //if not set in the GUI dynamically set it
        if (!activeGO) {
            activeGO = TempSingleton.Instance.activeGO = GameObject.Find("pf_cube");
        }
    }

    // Use this for initialization
    public void move() {
        activeGO.GetComponent<Rigidbody>().AddForce(Vector3.forward * 500f);
    }

    public void reset() {
        if (activeGO) {
            activeGO.GetComponent<ResetPosition>().init();
        }
    }
}
