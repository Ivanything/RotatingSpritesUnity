using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookScript : MonoBehaviour
{
    public Transform target;
    public Texture[] textures;
    void Update()
    {
        transform.forward = target.position - transform.position;
        float angle = Vector3.Angle(transform.root.forward, transform.forward);
        bool leftRight = Vector3.Angle(transform.root.right, transform.forward) < 90;
        if (angle < 36)
        {
            transform.GetChild(0).GetComponent<MeshRenderer>().material.mainTexture = textures[0];
        }
        else if (angle < 72)
        {
            if (leftRight)
                transform.localScale = new Vector3(1, 1, 1);
            else
                transform.localScale = new Vector3(-1, 1, 1);
            transform.GetChild(0).GetComponent<MeshRenderer>().material.mainTexture = textures[3];
        }
        else if (angle < 108)
        {
            if (leftRight)
                transform.localScale = new Vector3(-1, 1, 1);
            else
                transform.localScale = new Vector3(1, 1, 1);
            transform.GetChild(0).GetComponent<MeshRenderer>().material.mainTexture = textures[1];
        }
        else if (angle < 142)
        {
            if (leftRight)
                transform.localScale = new Vector3(-1, 1, 1);
            else
                transform.localScale = new Vector3(1, 1, 1);
            transform.GetChild(0).GetComponent<MeshRenderer>().material.mainTexture = textures[4];
        }
        else
        {
            transform.GetChild(0).GetComponent<MeshRenderer>().material.mainTexture = textures[2];
        }
    }
}