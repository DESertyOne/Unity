using UnityEngine;

public class RelayRaceRun : MonoBehaviour
{
    public Transform[] athlete;
    public float Speed;
    private float passDistance = 0.1f;
    private int indexTarget;
    private int indexRuner;
    private Vector3 target;
    private Vector3 runer;
    public bool movement;

    void Start()
    {
        indexRuner = 0;
        indexTarget = 1;
        target = athlete[indexTarget].position;
        runer = athlete[indexRuner].position;
    }

    void Update()
    {
        if (movement)
        {
            transform.position = Vector3.MoveTowards(runer, target, Speed * Time.deltaTime);
        }
        NextAthlete();
    }
    public void NextAthlete()
    {
        if(runer == target)
        {
            indexRuner++;
            indexRuner++;
            if(indexTarget > athlete.Length-1)
            {
                indexRuner--;
                indexTarget--;
                if(indexTarget < 0)
                {
                    indexRuner++;
                    indexRuner++;
                }
            }
        }
    }

}
