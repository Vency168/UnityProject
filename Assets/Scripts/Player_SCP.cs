using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    public Rigidbody rd;

    public int score = 0;

    public TextMeshProUGUI textComponent;

    public GameObject winText;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Game Start");//print logs output
    }

    // Update is called once per frame
    void Update()
    {
        //rd.AddForce( Vector3.right );
        //rd.AddForce(new Vector3(1,0,0)*1);//create vectors by self
        //x y z position direction force(size is 根号下x,y,z的平方和乘一个数字)
        //right left forward back up down

        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        //Debug.Log(h);
        Vector3 dir = new Vector3(h, 0, v);
        rd.AddForce(dir*3);//force is 3N now.

    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //    Debug.Log("Enter" + collision.gameObject.name);

    //    if (collision.gameObject.tag=="Food")
    //    {
    //        Destroy(collision.gameObject);
    //    }        

    //}

    //触发检测 Enter Stay Exit
    private void OnTriggerEnter(Collider other)//boxcollider meshcollider
    {
        //Debug.Log("OnTriggerEnter:" + other.gameObject.name);
        //Debug.Log("OnTriggerEnter:" + other.name);
        if (other.gameObject.tag == "Food")
        {
            score++;
            textComponent.text = score.ToString();
            Destroy(other.gameObject);

            if (score == 8)
            {
                winText.SetActive(true);
            }
        }

    }

    private void OnTriggerStay(Collider other)
    {
        //Debug.Log("OnTriggrStay:" + other.name);
    }
    private void OnTriggerExit(Collider other)
    {
        //Debug.Log("OnTriggrExit:" + other.name);
    }


}
