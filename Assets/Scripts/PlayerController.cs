using UnityEngine;
using System.Collections;

[System.Serializable]
public class Boundary
{
    public float xMin, xMax, zMin, zMax;
}

public class PlayerController : MonoBehaviour
{
	//player boundary
	public Boundary boundary;

	//TANK STATS
	//speed
    public float speed;
    //rotation
    public float rotation;
    //health
    public int health;

    //TANK FIRING
    //projectile
    public GameObject shot;
    //projectile spawn location
    public Transform shotSpawn;
    //projectile firing limit
    public float nextFire;
    //projectile max firing rate
    public float fireRate;

    //Controller check
 //    void ControllerCheck()
	// {
	//     float ltaxis = Input.GetAxis("XboxLeftTrigger");
	//     float rtaxis = Input.GetAxis("XboxRightTrigger");
	//     float dhaxis = Input.GetAxis("XboxDpadHorizontal");
	//     float dvaxis = Input.GetAxis("XboxDpadVertical");
	 
	//     bool xbox_a = Input.GetButton("XboxA");
	//     bool xbox_b = Input.GetButton("XboxB");
	//     bool xbox_x = Input.GetButton("XboxX");
	//     bool xbox_y = Input.GetButton("XboxY");
	//     bool xbox_lb = Input.GetButton("XboxLB");
	//     bool xbox_rb = Input.GetButton("XboxRB");
	//     bool xbox_ls = Input.GetButton("XboxLS");
	//     bool xbox_rs = Input.GetButton("XboxRS");
	//     bool xbox_view = Input.GetButton("XboxView");
	//     bool xbox_menu = Input.GetButton("XboxMenu"); 
	// }

    void Update()
    {
		// if(Input.GetButton("TankFire") && Time.time > nextFire)
  //       {
  //       	Debug.Log("tank fire good");
  //           // nextFire = Time.time + fireRate;
  //           // Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
  //           // GetComponent<AudioSource>().Play();
  //       }
    }

    void FixedUpdate()
    {
    	Debug.Log("shit's happening");
    	
    	// ControllerCheck();
    	if(Input.GetButton("Horizontal"))
    	{
    		Debug.Log("cannon horizontal good");
    	}

    	if(Input.GetButton("Vertical"))
    	{
    		Debug.Log("cannon vertical good");
    	}

    	// if(Input.GetButton("TankVertical"))
    	// {
    	// 	Debug.Log("tank vertical good");
    	// }

    	// if(Input.GetButton("TankRotation"))
    	// {
    	// 	Debug.Log("tank horizontal good");
    	// }

    	//left joystick moves cannon left or right

    }
}