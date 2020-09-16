using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private GameObject _cloudParticlePrefab;
   private void OnCollisionEnter2D(Collision2D coll) 
   {
    
       if (coll.gameObject.name == "bird")
       {
           
           Destroy(gameObject);
           Instantiate(_cloudParticlePrefab,transform.position,Quaternion.identity);
       }

        if (coll.gameObject.name == "box")
       {
           
           Destroy(gameObject);
           Instantiate(_cloudParticlePrefab,transform.position,Quaternion.identity);
       }
       
   }
}
