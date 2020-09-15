using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Bird : MonoBehaviour
{
    Vector3 _initialPosition;
    private bool _birdWasLaunched;
    [SerializeField] private float _launchPower = 500;
    private float _timeSittingAround;

    private void Awake() 
    {
        _initialPosition = transform.position;
    }
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if(_birdWasLaunched &&
            GetComponent<Rigidbody2D>().velocity.magnitude <= 0.1)
            {
                _timeSittingAround += Time.deltaTime;
            }
       if (transform.position.y >  15 || 
           transform.position.y < -15 ||
           transform.position.x >  15 ||
           transform.position.x < -15 ||
           _timeSittingAround > 3)
       {    
           string currentScenceName = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(currentScenceName);
       }

    }

    private void OnMouseDown() 
    {
        
    }
    private void OnMouseUp()
    {
     Vector2 directionToInitalPosition = _initialPosition - transform.position;   
     GetComponent<Rigidbody2D>().AddForce(directionToInitalPosition * _launchPower);  
     GetComponent<Rigidbody2D>().gravityScale = 1; 
     _birdWasLaunched = true;
    }
    
    private void OnMouseDrag() 
    {   
        Vector3 newPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(newPosition.x,newPosition.y);
    }
}
