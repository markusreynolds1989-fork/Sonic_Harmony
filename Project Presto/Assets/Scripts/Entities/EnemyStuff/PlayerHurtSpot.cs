using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHurtSpot : MonoBehaviour
{
    private BaseEnemy myBaseEnemy;
    // Start is called before the first frame update
    void Start()
    {
        myBaseEnemy = gameObject.transform.parent.gameObject.GetComponent<BaseEnemy>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.attachedRigidbody.gameObject.name != "Player_sonic") return;
        var mycontrol = other.GetComponent<CharControlMotor>();
        //mycontrol.GotHurt(false);
        myBaseEnemy.TauntPlayer();
    }
}
