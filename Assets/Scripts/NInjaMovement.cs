using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NInjaMovement : MonoBehaviour
{
    Start is called before the first frame update
    public Vector2 jump = new Vector2(0, 300);
    Vector3 startPoint;
    int varjump, score, scrollLengkap;
    float speed, speedmelayang;
    private Animator animation;
    TrapMelayang trapMelayang;
    TrapSpikeJatuh trapSpikeJatuh;
    TrapSpike trapSpike;
    [SerializeField] AudioClip ScrollSound;



    // [SerializeField] AudioClip breaksound ;
    void Start()
    {
        startPoint = new Vector3(-7.1f, -3.75f, 0);
        animation = GetComponent<Animator>();
        varjump = 0;
        animation.SetBool("berlari", true);
        speed = 0.1f;
        scrollLengkap = 4;
        score = 0;
        speedmelayang = 0;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x + speed, transform.position.y + speedmelayang);
        if (varjump < 2)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                GetComponent<Rigidbody2D>().velocity = Vector2.zero;
                GetComponent<Rigidbody2D>().AddForce(jump);
                animation.SetBool("terbang", true);
                animation.SetBool("berlari", false);
                varjump += 1;
            }
        }
        Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
        if (screenPosition.y > Screen.height || screenPosition.y < 0)
        {
            Die();
        }
    }

    void Die()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
        HeartBar.SaveHealth(1);
        PlayerPrefs.SetInt("scroll", 0);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "ground")
        {
            animation.SetBool("diam", false);
            animation.SetBool("terbang", false);
            animation.SetBool("berlari", true);
            varjump = 0;
            GetComponent<Rigidbody2D>().gravityScale = 1.5f;
        }
        if (other.gameObject.tag == "dietrap")
        {
            Die();
        }
        if (other.gameObject.tag == "coliderlangir")
        {
            GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionY;
            speedmelayang = 0;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "speedItem")
        {
            Destroy(other.gameObject);
            speed += 0.15f;
        }
        if (other.gameObject.tag == "finish")
        {
            if (ScrollBar.scroll == scrollLengkap)
            {
                SituasiAwal.Normal();
                SceneManager.LoadScene("MenuAwal");
            }
            else
            {
                Debug.Log("Gagal");
                SceneManager.LoadScene("GameOver");
            }
        }
        if (other.gameObject.tag == "scroll")
        {
            AudioSource.PlayClipAtPoint(ScrollSound, Camera.main.transform.position);
            other.gameObject.SetActive(false);
            int i = 1;
            ScrollBar.SaveScroll(i);
        }

        if (other.gameObject.tag == "errground")
        {
            Destroy(other.gameObject);
            varjump = 1;
        }

        if (other.gameObject.tag == "colmelayang")
        {
            trapMelayang = GameObject.Find("SpikeMelayang").GetComponent<TrapMelayang>();
            trapMelayang.a = true;

        }
        if (other.gameObject.tag == "colspiketanah")
        {
            trapSpike = GameObject.Find("Spike").GetComponent<TrapSpike>();
            trapSpike.a = true;
        }
        if (other.gameObject.tag == "colspikelangit")
        {
            trapSpikeJatuh = GameObject.Find("SpikeJatuh").GetComponent<TrapSpikeJatuh>();
            trapSpikeJatuh.a = true;
        }
        if (other.gameObject.tag == "zerograf")
        {
            Destroy(other.gameObject);
            GetComponent<Rigidbody2D>().gravityScale = 0;
            varjump = 2;
            speedmelayang = 0.12f;
            animation.SetBool("terbang", true);
            animation.SetBool("berlari", false);

        }
        if (other.gameObject.tag == "btslangit")
        {
            GetComponent<Rigidbody2D>().gravityScale = 1.5f;
            GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeRotation;
            varjump = 1;
        }
    }


}
