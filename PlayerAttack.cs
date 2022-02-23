using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{

    public GameObject gun;
    //public GameObject shootPoint;
    public GameObject shoot;


    public SoundManager soundManager;



    public bool isGunActive;  // bool to check gun is there in hand or not

    void Start()
    {
       
        gun.SetActive(true);
        isGunActive = true;
    }

    // Update is called once per frame
    void Update()
    {
       

        if (Input.GetKeyDown(KeyCode.E) && isGunActive == false)
        {
           
            gun.SetActive(true);
            isGunActive = true;
          
          
        }

        else if (Input.GetKeyDown(KeyCode.E) && isGunActive == true)
        {
         
            gun.SetActive(false);
            isGunActive = false;
        }

        if (Input.GetButtonDown("Fire1"))
        {
            playerAttack();
           
        }
    }

    public void playerAttack()
    {
        
        Rigidbody bullet;
        if (isGunActive)
        {
            soundManager.Shoot();
            bullet =Instantiate(shoot, gun.transform.position,gun.transform.rotation).AddComponent<Rigidbody>();
            bullet.AddForce(gun.transform.up * 100);
            bullet.AddForce(gun.transform.forward * 3000);
            Destroy(bullet.gameObject, 10f);
            StartCoroutine(Timer());


        }
    }

    

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(3.0f);
    }
   

}
