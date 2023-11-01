using UnityEngine;

public class Run : MonoBehaviour
{
    public float speed;
    public Transform[] pointone;
    public bool movementDerection;
    private Vector3 target;

    void Start()
    {
        target = pointone[0].position;
    }

    void Update()
    {
        transform.LookAt(target);
        transform.Rotate(0, 0, 0.2f);

        if (movementDerection)
        {
            transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * speed);
        }
        if (transform.position == target)
        {
            if (target == pointone[0].position)
            {
                target = pointone[pointone.Length - 1].position;
            }
        }
    }
}
