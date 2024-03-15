using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class ShootingStars : MonoBehaviour
{
    public Transform egglay; //attach shooting_stars object

    public GameObject egg; //attach stars prefab object
    // Start is called before the first frame update

    public void Shoot() //define fxn to allow character to shoot
    {
        Quaternion spawnrotation = Quaternion.Euler(0, 0, 0);
        Instantiate(egg, egglay.position, spawnrotation); //this will spawn objects from rocket position
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) // button options to use- Input.GetKeyDown(KeyCode.Space)  or Input.GetMouseButtonDown(0)
        {
            Shoot();
        }
    }


}
