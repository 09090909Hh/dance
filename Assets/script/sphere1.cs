using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class datetime : MonoBehaviour
{

    public Animator animator; // Animator component reference
    public int startHour; // Start hour
    public int startMinute; // Start minute
    public int endHour; // End hour
    public int endMinute; // End minute

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

        // Get the values from the input fields
        

        // Check if current time is between the start and end times
        if ((currentTime.Hour > startHour || (currentTime.Hour == startHour && currentTime.Minute >= startMinute)) &&
            (currentTime.Hour < endHour || (currentTime.Hour == endHour && currentTime.Minute <= endMinute)))
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