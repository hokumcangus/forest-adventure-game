using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestArrow : MonoBehaviour
{
    public Transform target; //Rotate towards the quest target
    public float buffer; // if there is a quest
    
    public Color farColor;
    public Color closeColor;
    public float maxDistance; // if == 10 changes colors 

    private SpriteRenderer rend;

    private void Start() {
        rend = GetComponent<SpriteRenderer>();
    }

    private void Update() 
    {
        if(target != null){
            // Difference between the arrows position and the quest position
            Vector2 difference = transform.position - target.position;
            
            //Use the tangent function on our difference Vector2 takes in y and x
            //returns angle in Radius and calculate degrees to convert
            float angle = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
           
            // Angle the arrow with rotation Rotation takes x,y,z (buffer -90/ + 20)
            transform.rotation = Quaternion.Euler(0,0, angle);// + buffer;

            // Set rend by using color.Lerp changes colors close, far, and between
            rend.color = Color.Lerp(closeColor, farColor, DistanceToQuest());
        }
    }

    float DistanceToQuest(){
        // How far we are to our quest. This is a percentage function
        return Mathf.Clamp01(Vector2.Distance(transform.position, target.position) / maxDistance);
    }
}

