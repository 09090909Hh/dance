using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class datetime : MonoBehaviour
{
    public Animator animator; // Animator component reference

    // Start is called before the first frame update
    void Start()
    {
        // Assuming the Animator component is on the same GameObject
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // Get current time
        System.DateTime currentTime = System.DateTime.Now;

        // Check if current time is between 11:45 PM and 11:50 PM
        if (currentTime.Hour == 23 && currentTime.Minute >= 45 && currentTime.Minute <= 50)
        {
            // Enable the Animator component
            animator.enabled = true;
        }
        else
        {
            // Disable the Animator component
            animator.enabled = false;
        }
    }
}