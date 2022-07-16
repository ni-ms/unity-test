using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Learn : MonoBehaviour
{

    private Rigidbody myBody;
    private BoxCollider myCollider;
    private AudioSource audioSource;
    private Animator myAnimator;
 
    private Transform myTransform;
    // Start is called before the first frame update
    void Start()
    {

        myBody = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
        audioSource.Play();
        myTransform = transform;
        myTransform.position = new Vector3(10,20,30);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
