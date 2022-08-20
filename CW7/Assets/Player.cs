using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public Trigger Script;
    public Transform min;
    public Transform max;
    public float inc;
    AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    void Move()
    {
    if(Input.GetKeyDown(KeyCode.D))
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x + inc, min.position.x, max.position.x), transform.position.y, transform.position.z);

    }
    else if (Input.GetKeyDown(KeyCode.A))
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x - inc, min.position.x, max.position.x), transform.position.y, transform.position.z);   
    }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            Script.GameGOing = false;
            playAudio();
            StartCoroutine(Delay());
        }
    }
    void Restart()
    {
        SceneManager.LoadScene(1);
    }
    void playAudio()
    {
        audio.Play();
    }
    IEnumerator Delay()
    {
           yield return new WaitForSeconds(3f);
        Restart();
    }
}
