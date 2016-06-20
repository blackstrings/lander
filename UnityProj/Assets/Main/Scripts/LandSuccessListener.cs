using UnityEngine;
using System.Collections;

/// <summary>
/// This script helps the main GO listen to another GO collision for a set amount of time.
/// </summary>
public class LandSuccessListener : MonoBehaviour {

    float timerCounter = 0f;
    public float duration = 2f;
    bool isLanded = false;

    public string targetTagName;

    /// <summary>
    /// On collision detect, counter starts
    /// </summary>
    /// <param name="col"></param>
    void OnCollisionEnter(Collision col) {

        if (col.gameObject.tag.Equals(targetTagName)) {
            isLanded = true;
            StartCoroutine(prepareToGiveScore());
        }

    }
    
    void OnCollisionStay(Collision col) {
        /*
        if (isLanded) {
            timerCounter += Time.deltaTime;
        }

        if (timerCounter > duration && isLanded) {
            TempSingleton.Instance.score++;
            Debug.Log("point added");
            isLanded = false;
            timerCounter = 0f;
        }

        Debug.Log(timerCounter + " : score : " + TempSingleton.Instance.score);
        */

    }

    void OnCollisionExit(Collision col) {
        if (col.gameObject.tag.Equals(targetTagName)) {
            isLanded = false;
        }
    }

    IEnumerator prepareToGiveScore() {
        timerCounter = 0f;
        while (timerCounter <= duration && isLanded) {
            timerCounter += Time.deltaTime;

            yield return null;
        }

        isLanded = false;
        if (timerCounter >= duration) {
            TempSingleton.Instance.score++;
            TempSingleton.Instance.updateScoreDisplay();

            Color newColor = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
            this.gameObject.GetComponent<Renderer>().material.SetColor("_Color", newColor);

            TempSingleton.Instance.resetPlayer();

            // Debug.Log("point added");
        }
        //Debug.Log("exiting loop");

    }
}
