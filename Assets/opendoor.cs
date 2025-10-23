using UnityEngine;

public class opendoor : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    void OnTriggerEnter (Collider other)
       {
     GameObject parent = transform.parent.gameObject;       
     Animation animation = parent.GetComponent<Animation>();       
     animation.Play("OpenDoor");
       }


    // Update is called once per frame
    void Update()
    {
        
    }
}

  
