using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpwaner : MonoBehaviour
{
    public GameObject[] eneimesTypes;

    [SerializeField] Vector3 spawnValues;
    [SerializeField] private float waitTospawn;
    [SerializeField] private float spwanMostWait;
    [SerializeField] private float spwanLeastWait;
    [SerializeField] private int startWait;
    [SerializeField] private bool stop;
    [SerializeField] ParticleSystem particlee;
    AudioSource dyingEnemyAudio;
    int randEnmy;
    void Start()
    {
        particlee = GetComponent<ParticleSystem>();
        dyingEnemyAudio= GetComponent<AudioSource>();
        StartCoroutine(spawnenemy());
    }


    void Update()
    {

        waitTospawn = Random.Range(spwanLeastWait, spwanMostWait);

    }



    IEnumerator spawnenemy()
    {
        yield return new WaitForSeconds(startWait);
        while (!stop)
        {
            randEnmy = Random.Range(0, 1);
            Vector3 spwanPos = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), 1, Random.Range(-spawnValues.z, spawnValues.z));
            Instantiate(eneimesTypes[randEnmy], spwanPos + transform.TransformPoint(0, 0, 0), gameObject.transform.rotation);
            yield return new WaitForSeconds(waitTospawn);
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "Player")
        {
            dyingEnemyAudio.Play();
            particlee.Play();
            Destroy(gameObject, 1f);
        }
    }

}
