using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestArrow : MonoBehaviour
{
    public Transform target; //Rotate towards the quest target
    public float buffer; // if there is a quest

    private void Update() {
        // Difference between the arrows position and the quest position
        Vector2 difference = transform.position - target.position;
        //
        //Use the tangent function on our difference Vector2 takes in y and x
        //returns angle in Radius and calculate degrees to convert
        float angle = Mathf.Atan2(difference.y, difference.x) * Matf.Rad2Deg;
        // Angle the arrow with rotation Rotation takes x,y,z (buffer -90/ + 20)
        transform.rotation = Quaternion.Euler(0,0, angle) + buffer;
    }
}

