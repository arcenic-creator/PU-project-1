using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public Transform PointA;
    public Transform PointB;
    public float movespeed = 2f;

    private Vector3 nextposition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        nextposition = PointB.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, nextposition, movespeed = Time.deltaTime* 3);

        if(transform.position == nextposition)
        {
            nextposition = (nextposition == PointA.position) ? PointB.position : PointA.position;
        }
    }
}

