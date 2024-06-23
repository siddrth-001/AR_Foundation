using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CrashBall : MonoBehaviour
{
    [SerializeField] private Rigidbody GameObjectBall;
    private 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BallShoot()
    {
        Instantiate(GameObjectBall);
        GameObjectBall.AddForce(Vector3.forward * 20f);
    }
}
