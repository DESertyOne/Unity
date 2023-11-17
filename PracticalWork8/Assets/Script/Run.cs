using UnityEngine;

public class Run : MonoBehaviour
{
    public float speed;
    public Transform[] pointone;
    public bool movementDerection;
    private Vector3 target;
    public int indextarget;
    public bool back;



    void Start()
    {
        indextarget = 0;
        target = pointone[indextarget].position;

    }

    void Update()
    {

        if (movementDerection)
        {
            transform.LookAt(target);
            transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * speed);
        }
        if (!back)
        {
            if (indextarget < pointone.Length - 1)
            {
                if (transform.position == pointone[indextarget].position)
                {
                    indextarget++;
                    target = pointone[indextarget].position;
                }
            }
            if (indextarget == pointone.Length - 1)
            {
                back = true;
            }
        }
        else
        {
            if (0 < indextarget)
            {
                if (transform.position == pointone[indextarget].position)
                {
                    indextarget--;
                    target = pointone[indextarget].position;
                }
            }
            if (indextarget == 0)
            {
                back = false;
            }

        }

    }

}


