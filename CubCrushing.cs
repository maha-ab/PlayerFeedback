using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubCrushing : MonoBehaviour
{
    public GameObject cubePaceis;
    private GameObject temb_cube;

    public SoundManager soundManager;

 

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "bullet")
        {
            soundManager.GlassSmatch();
            temb_cube = Instantiate(cubePaceis, transform.position, cubePaceis.transform.rotation);
            Destroy(gameObject);
            Destroy(temb_cube, 20.0f);
        }
    }
}
