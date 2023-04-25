using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CentipedeBodySection : MonoBehaviour
{
    public bool isHead;
    public CentipedeBodySection leader;
    public CentipedeBodySection follower;

    public void UpdateSection()
    {
        if (isHead)
        {
            follower.UpdateSection();
            return;
        }
            

        Debug.Log(gameObject.name);
        transform.position = Vector3.Slerp(transform.position, leader.transform.position - leader.transform.forward, Time.deltaTime * 40);
        transform.rotation = Quaternion.Slerp(transform.rotation, leader.transform.rotation, Time.deltaTime * 5);

        if (follower != null)
            follower.UpdateSection();
    }
}
