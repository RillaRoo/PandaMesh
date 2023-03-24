using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    public Camera camera;

	public static PlayerController Instance;

	void Awake()
	{
		Instance = this;
	}

	public NavMeshAgent agent;
    void Update()
    {
		if (Input.GetMouseButtonDown(0))
		{
            Ray ray = camera.ScreenPointToRay(Input.mousePosition); //criamos um caminho (ray) até ao local onde clicamos
            RaycastHit hit;

			if (Physics.Raycast(ray, out hit))
			{
				agent.SetDestination(hit.point);
			}
		}
		if (agent.isOnOffMeshLink) //faz o salto instantâneo
		{
			agent.CompleteOffMeshLink();
		}
    }
}
