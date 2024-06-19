using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonQA : MonoBehaviour
{
    [SerializeField] private GameObject CannonBall;
     private bool BallValue;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   public void RotateRight()
    {
        Vector3 rotationToAdd = new Vector3(0, 15, 0);
        transform.Rotate(rotationToAdd);
    }

     public void RotateLeft()
    {
        
        Vector3 rotationToAdd = new Vector3(0, -15, 0);
        transform.Rotate(rotationToAdd);


    }

    public void FireBall()
    {
        if(BallValue !=true)
          {
          BallValue = true;
          Instantiate(CannonBall);
          StartCoroutine(WaitingTime());
          }
    }

    IEnumerator WaitingTime()
    {
    yield return new WaitForSeconds(1);
    BallValue = false;
    Destroy(GameObject.Find("Cube(Clone)"));
    }
}
