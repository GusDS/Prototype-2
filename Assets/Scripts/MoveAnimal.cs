using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAnimal : MonoBehaviour
{
    public float speed = 40;
    private float randomSpeed;
    private GameObject player;
    private PlayerController playerControllerScript;
    private GameObject projectile;

    void Start()
    {
        randomSpeed = Random.Range(5f, 20f);
        player = GameObject.Find("Explorer");
        playerControllerScript = player.GetComponent<PlayerController>();
    }

    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * randomSpeed); // speed
    }

    private void OnMouseDown()
    {
        projectile = Instantiate(playerControllerScript.projectilePrefab, player.transform.position + playerControllerScript.projectileOffset, playerControllerScript.projectilePrefab.transform.rotation);
        projectile.transform.LookAt(transform.position);
    }
}
