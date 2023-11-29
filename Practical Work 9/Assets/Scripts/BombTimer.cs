using UnityEngine;

public class BombTimer : MonoBehaviour
{
    [SerializeField] private float TimeToExplosion;
    [SerializeField] private float Power;
    [SerializeField] private float Radius;
    [SerializeField] private float TimeBobm;
    void Start()
    {
        TimeToExplosion = TimeBobm;
    }

    void FixedUpdate()
    {
        TimeToExplosion -= Time.deltaTime;

        if (TimeToExplosion <= 0)
        {
            Boom();
        }
    }
    private void Boom()
    {
        Rigidbody[] _Objects = FindObjectsOfType<Rigidbody>();
        foreach (Rigidbody _Object in _Objects)
        {
            float distance = Vector3.Distance(transform.position, _Object.position);
            if (distance < Radius)
            {
                Vector3 derection = _Object.transform.position - transform.position;
                _Object.AddForce(derection.normalized * Power * (Radius - distance),ForceMode.Impulse);
            }
        }

        TimeToExplosion = TimeBobm;

    }
}
