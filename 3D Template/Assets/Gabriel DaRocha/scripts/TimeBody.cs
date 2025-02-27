using UnityEngine;

public class TimeBody : MonoBehaviour
{
    public bool isRewinding = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return)) { 
        isRewinding =true;
        }
    }
}
