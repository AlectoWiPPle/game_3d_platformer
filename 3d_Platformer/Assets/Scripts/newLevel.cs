using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class newLevel : MonoBehaviour
{
    [SerializeField] AudioSource portalSound;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Portal")
        {
            MovementScript.JumpCount = 5;
            portalSound.Play();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
