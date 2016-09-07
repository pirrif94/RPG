using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour {
    private Vector3 pos;
    public Camera[] cam;
    public GameObject hero2;
    // Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.W))
        {
            pos = this.transform.position;
            gameObject.transform.position += Vector3.up;
            Action();
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            pos = this.transform.position;
            gameObject.transform.position += Vector3.down;
            Action();
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            pos = this.transform.position;
            gameObject.transform.position += Vector3.left;
            Action();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            pos = this.transform.position;
            gameObject.transform.position += Vector3.right;
            Action();
        }
    }

    void Action()
    {
        if(Random.Range(0,10) == 5)
        {
            cam[1].enabled = !cam[1].enabled;
            cam[0].enabled = !cam[0].enabled;
            hero2.SetActive(true);
            gameObject.SetActive(false);
            //Debug.Log("Filya soset hui!");
        }
    }


    void OnCollisionEnter2D(Collision2D col)
    {
        gameObject.transform.position = pos;
    }
}
