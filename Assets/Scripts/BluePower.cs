using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BluePower : MonoBehaviour
{

   
  
    public GameObject lilbullet;
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
       

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {

            collision.gameObject.TryGetComponent<EnemyBehaibiour>(out EnemyBehaibiour scrEnemyBehaibiour);
            collision.gameObject.TryGetComponent<TurtleBehabiour>(out TurtleBehabiour scrTurtleBehabiour);


            try
            {
                if (scrEnemyBehaibiour.isitoncorrector == false)
                {


                    bluebullet();
                }
            }
            catch
            {
                if (scrTurtleBehabiour.isitoncorrector == false)
                {
                    bluebullet();

                }
            }
            
        }
    }
   

    public void bluebullet()
    {
        Instantiate(lilbullet, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
        Instantiate(lilbullet, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
        Instantiate(lilbullet, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
       

    }
}
