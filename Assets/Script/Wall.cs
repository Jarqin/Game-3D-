using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
	public float speed;
	public int damage = 1;

    void Update()
    {
        transform.Translate(Vector3.back * speed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
    	if (other.CompareTag("Player"))
    	{
    		other.GetComponent<Player>().Health -= damage;
    		Debug.Log(other.GetComponent<Player>().Health);
    		Destroy(gameObject);
    	}
    }
}
