using UnityEngine;

public class EnemyMovement : MonoBehaviour {
    Transform player;
     PlayerHealth playerHealth;
    public EnemyHealth enemyHealth;
    UnityEngine.AI.NavMeshAgent nav;


    void Awake() {
        //Cari game
       // object dengan tag player
        player = GameObject.FindGameObjectWithTag("Player").transform;

        //Mendapatkan Reference component
        playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
        enemyHealth = GetComponent<EnemyHealth>();
        nav = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }


    void Update() {
        //Memindahkan posisi player
        if (enemyHealth.currentHealth > 0 && playerHealth.currentHealth > 0) {
            nav.SetDestination(player.position);
        } else //Hentikan moving
          {
            nav.enabled = false;
        }
    }
}