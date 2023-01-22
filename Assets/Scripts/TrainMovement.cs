using UnityEngine;

public class TrainMovement : MonoBehaviour
{
   [SerializeField] public Transform[] points;
    public float speed = 1;
    private int currentPoint = 0;
    public unlock vu;



    void Update()
    {
        if (vu.trainUnlocked)
        {
            if (transform.position != points[currentPoint].position)
            {
                Vector3 target = points[currentPoint].position;
                transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);

            }
            else
            {
                currentPoint++;
                if (currentPoint >= points.Length)
                {
                    currentPoint = 0;
                    vu.totalMetalCollected += 20;
                }
            }
        }
    }
}