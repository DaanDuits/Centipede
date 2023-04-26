using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackPlayer : MonoBehaviour
{
    public float speed = 1.0f;
    private GameObject Player;
    public GameObject pa;
    private Renderer r;


    AudioSource AudioSourceaudioSource;
    // Start is called before the first frame update
    void Start()
    {
        AudioSourceaudioSource = GetComponent<AudioSource>();
        
        Player = GameObject.Find("Player");

        r = Player.GetComponent<Renderer>();
        //Player= GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        var step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, Player.transform.position, step);

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "Player")
        {
            AudioSourceaudioSource.Play();
            Debug.Log(AudioSourceaudioSource + "its working");
            Instantiate(pa, transform.position, Quaternion.identity);
            //  r.enabled = false;
           // Destroy(collision.gameObject, 1f);
            Destroy(gameObject, 1f);
            Destroy(pa , 1f);
        }
        
    }

}
