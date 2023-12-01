using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinkPower : MonoBehaviour
{




    public GameObject SharkPink;
    public GameObject SwordPink;
    public GameObject TurtPink;

    private TurtleBehabiour scrTurtleBehabiour;


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


                    pinkstop();
                }
            }
            catch
            {
                if (scrTurtleBehabiour.isitoncorrector == false)
                {

                    pinkstop();
                }
            }


        }
        void pinkstop()
        {


            Vector3 posiotioncollision = collision.transform.position;

            if (collision.gameObject.name == "SharkEraser(Clone)")
                Instantiate(SharkPink, new Vector3(posiotioncollision.x, posiotioncollision.y, posiotioncollision.z), Quaternion.identity);

            if (collision.gameObject.name == "SwordFishErraser(Clone)")
                Instantiate(SwordPink, new Vector3(posiotioncollision.x, posiotioncollision.y, posiotioncollision.z), Quaternion.identity);

            if (collision.gameObject.name == "TurtleCorrector(Clone)")

                Instantiate(TurtPink, new Vector3(posiotioncollision.x, posiotioncollision.y, posiotioncollision.z), Quaternion.identity);
        }
    }


}
