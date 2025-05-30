using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour
{
    public Transform trans;
    public GameObject player;
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
       // Debug.Log(trans.position);
         offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset;
    }
}
