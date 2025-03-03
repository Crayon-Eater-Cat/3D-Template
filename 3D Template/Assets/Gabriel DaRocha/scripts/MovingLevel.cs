using UnityEngine;
using UnityEngine.SceneManagement;

public class MovingLevel : MonoBehaviour
{
    void OnTriggerEnter(Collider Player)
    {
        Debug.Log("A collider has entered the DoorObject trigger");
        SceneManager.LoadScene("GabrielLevel");
    }
}
