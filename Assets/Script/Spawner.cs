using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
	public GameObject[] WallPattern;

	private float timeBtwSpawn;
	public float StarttimeBtwSpawn;
	public float decreaseTime;
	public float minTime = 0.65f;

    void Start()
    {
        
    }

    void Update()
    {
    	if (timeBtwSpawn <= 0)
    	{
    		int rand= Random.Range(0, WallPattern.Length);
    		Instantiate(WallPattern[rand], transform.position, Quaternion.identity);
    		timeBtwSpawn = StarttimeBtwSpawn;
    		if(StarttimeBtwSpawn > minTime)
    		{
    			StarttimeBtwSpawn -=decreaseTime;
    		}
    	}
        else
        {
        	timeBtwSpawn -= Time.deltaTime;
        }
    }
}
