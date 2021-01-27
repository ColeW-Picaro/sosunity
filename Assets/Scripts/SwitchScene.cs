using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SwitchScene : MonoBehaviour
{
    public Text portalText;
    public string destination;

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.tag == "Player") {
            portalText.text = "Enter: " + destination;
            if (Input.GetAxisRaw("Interact") == 1) {
                SceneManager.LoadScene(destination);
            }
        }
    }

    private void OnTriggerStay2D(Collider2D collision) {
        if (collision.gameObject.tag == "Player") {
            if (Input.GetAxisRaw("Interact") == 1) {
                SceneManager.LoadScene(destination);
            }

        }
    }

    private void OnTriggerExit2D(Collider2D collision) {
        if (collision.gameObject.tag == "Player") {
            portalText.text = "";
        }
    }
}
