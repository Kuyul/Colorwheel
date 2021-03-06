﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPath : MonoBehaviour
{

    // The target marker.
    public Transform LeaderSphere;
    public Transform[] FollowerSpheres;
    public Transform[] target;
    public float speed;
    public PathTypes PathType;

    private float step;
    private int Pathindex;
    private List<List<Vector3>> ListOfStoredPositions;

    #region Enums
    public enum PathTypes //Types of movement paths
    {
        linear,
        loop
    }
    #endregion //Enums

    // Use this for initialization
    void Start()
    {
        step = Time.deltaTime * speed;
        Pathindex = 0;
        //Populate path storage
        ListOfStoredPositions = new List<List<Vector3>>();
        for (int i = 0; i < FollowerSpheres.Length; i++)
        {
            ListOfStoredPositions.Add(new List<Vector3>());
        }
    }

    void Update()
    {
        //if the number of follower spheres have not been set, return

        //Follow the leader sphere
        ListOfStoredPositions[0].Add(LeaderSphere.localPosition);
        LeaderSphere.localPosition = Vector3.MoveTowards(LeaderSphere.localPosition, target[Pathindex].localPosition, step);

        //Loop through each follower spheres and add its position to the List of Stored Positions
        for (int i = 0; i < FollowerSpheres.Length; i++)
        {
            //This if statement sets the distance between the spheres
            if (ListOfStoredPositions[i].Count > 20 / speed)
            {
                //We don't need to include the tail sphere to the list
                if (i != FollowerSpheres.Length - 1)
                {
                    //Add the position of the current follower sphere for the one behind to trace
                    ListOfStoredPositions[i + 1].Add(FollowerSpheres[i].localPosition);
                }
                FollowerSpheres[i].localPosition = ListOfStoredPositions[i][0];
                ListOfStoredPositions[i].RemoveAt(0);
            }
        }

        if (LeaderSphere.localPosition == target[Pathindex].localPosition)
        {
            Pathindex++;
        }

        if (Pathindex >= target.Length)
        {
            if (PathType == PathTypes.loop)
            {
                Pathindex = 0;
            }
            else
            {
                Pathindex--;//Dummy
            }
        }
    }
}
