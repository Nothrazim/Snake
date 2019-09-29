using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFood : MonoBehaviour
{

    public GameObject food;


    public void Spawn()
    {
        float x = (int)Random.Range(-10, 10) + 0.5f; //+0.5 to offset positioning
        float y = (int)Random.Range(-5, 5) + 0.5f;
        Instantiate(food, new Vector2(x, y), Quaternion.identity);
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Repeating autospawn is active.");
        InvokeRepeating("Spawn", 3, 2);
        //Invoke("Spawn", 0);
    }

    // Update is called once per frame
    void Update()
    {

    }

    /*
     * if (can eat food)
            Send a virtual snake to eat,
                If (after eating can follow the tail) really snake to eat
                If (can not follow the tail after eating) True snake followed the tail
        else
            True snake followed the tail
        if (can not eat food can not follow the tail) Random stroll,
     * 
     * 
     * 
     * *//*
     // Will start node into the open table while (open table is not empty) {
        0. Find the largest F value in the open table(Description from the target farthest), if we have the same choice in the back of the row is the latest   addition of.
	    1. Remove the current node from the open list and add it to the closed list.
	    2. Traverse the neighboring nodes in all four directions
                (0). If the neighboring node is not accessible or the neighboring node is already in the closed list, what actions
                        (1) If the neighbor node is not in the open list, add the node to the open list and set the parent node of the neighbor node as the current node,  and save the phase G and H values of neighboring nodes[0] When the destination node is added to the open list as the node to be checked, the path is found, and the loop is terminated and the direction is returned.
                        (2) If the neighboring node is in an open list, It is determined whether the G value of the neighboring node arriving at the neighboring node via the current node is greater than or less than the G value originally stored in the neighboring node, and if the G value is greater than or smaller than the G value of the neighboring node, the parent node of the adjacent node is set as the current node , And reset the G and H values of the neighboring nodes
} 
     
       // When the open list is empty, indicating that no new node can be added, and there is no end node in the tested node, the path can not be found, at this time End -1 ring;
*/
}
