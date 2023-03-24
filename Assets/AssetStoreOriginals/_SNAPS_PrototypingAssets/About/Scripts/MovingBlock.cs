using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
/*
public class MovingBlock : MonoBehaviour
{
    [SerializeField] private Vector3[] positions;
    [SerializeField] private float stopTime = 2f;
    [SerializeField] private float movSpeed = 0.1f;

    //private List <NavMeshAgent>
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(MovePlatform());  
    }

    private IEnumerator MovePlatform() 
    {
        transform.position = positions[0];
        int positionIndex = 0;
        int lastPositionIndex;

        WaitForSeconds Wait = new WaitForSeconds(stopTime);

		while (true)
		{
            lastPositionIndex = positionIndex;
            positionIndex++;

			if (positionIndex>=positions.Length)
			{
                positionIndex = 0;
			}
            Vector3 platformMoveDirection = (positions[positionIndex]-positions[lastPositionIndex]).normalized;
            float distance = Vector3.Distance(transform.position, positions[positionIndex]);
            float distanceTraveled = 0;

			while (distanceTraveled<distance)
			{
                transform.position += platformMoveDirection * movSpeed;
                distance += platformMoveDirection.magnitude * movSpeed;
			}
            yield return null;
		}

        yield return Wait;
    }
}*/
public class MovingBlock : MonoBehaviour
{

    public float speed = .2f;
    public float strength = 9f;

    private float randomOffset;

    // Use this for initialization
    void Start()
    {
        randomOffset = Random.Range(0f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x = Mathf.Sin(Time.time * speed + randomOffset) * strength;
        transform.position = pos;
    }
}
