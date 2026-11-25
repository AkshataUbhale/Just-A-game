using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    bool dead = false;
    [SerializeField] AudioSource dieSound;

    private void Update()
    {
        if (transform.position.y < -1f && !dead)
        {
            Die();
        }   
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Enemy Body"))
        {
            GetComponent<MeshRenderer>().enabled = false;
            GetComponent<Rigidbody>().isKinematic = true;
            GetComponent<PlayerMovement>().enabled = false;
            Die();
        }
    }

    void Die()
    {
        
        Invoke(nameof(ReloadLive),1.3f);
        dead = true;
        dieSound.Play();
    }

    void ReloadLive()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
