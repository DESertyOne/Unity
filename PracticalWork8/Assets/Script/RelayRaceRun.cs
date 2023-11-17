using UnityEditor;
using UnityEngine;

public class RelayRaceRun : MonoBehaviour
{
    [SerializeField] private Transform[] _athlete;
    [SerializeField] private float Speed;
    [SerializeField] private bool movement;
    [SerializeField] private GameObject Stick;
    private int indexRuner;
    private int indexTarget;
    private Transform runner;
    private Transform target;

    void Start()
    {
        indexRuner = 0;
        indexTarget = 1;
        CachedTarnsform();
    }

    void Update()
    {
        Move();
        NextAthlete();
    }
    private void CachedTarnsform()
    {
        runner = _athlete[indexRuner];
        target = _athlete[indexTarget];
    }
    private void NextAthlete()
    {
        if (runner.position == target.position)
        {
            PassingTheBaton();
            CachedTarnsform();
        }
    }
    private void Move()
    {
        float passDistance = Speed * Time.deltaTime;
        if (movement)
        {
            runner.position = Vector3.MoveTowards(runner.position, target.position, passDistance);
            runner.LookAt(target.position);
            BroadcastStick(runner);
        }
    }
    private void PassingTheBaton()
    {
        indexRuner = indexTarget;
        indexTarget++;
        if (indexTarget >= _athlete.Length)
        {
            indexTarget = 0;
        }
    }
    private void BroadcastStick(Transform newParent)
    {
       Stick.transform.SetParent(newParent, false);
    }


}
