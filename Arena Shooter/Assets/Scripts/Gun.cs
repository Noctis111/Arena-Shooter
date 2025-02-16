using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Transform spawnpoint;
    public float distance = 15f;

    //The audiosource that plays the shooting sound
    public AudioSource audioSource;
    //The sound played when the gun is shot
    public AudioClip shootingSound;

    void Start()
    {

    }
    
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();

            audioSource.PlayOneShot(shootingSound);

            
        }
            

        

    }
    private void Shoot()
    {
        RaycastHit Hit;
        if (Physics.Raycast(spawnpoint.position, spawnpoint.forward, out Hit, distance))
        {
            Debug.Log("Hit");
            if (Hit.transform.tag == "Target")
            {
                Destroy(Hit.transform.gameObject);
            }

        }
        else
            Debug.Log("not hit");
    }
}