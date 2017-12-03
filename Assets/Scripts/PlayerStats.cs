using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour {

    public int health = 5;
    public int stateOfMutation = 0;
    public int lifes = 3;

    public float SpeedMutation = 0.5f;
    public float JumpMutation = 0.5f;
    public int lifeEnnemyMutation = 2;
    public int damagesEnnemyMutation = 2;
    public bool canKillOnJump = false;
    public Sprite[] characterSprites;
    private float timer = 1f;
    private bool canTakeDamages = true;
    private bool theGameisFinished = false;

	// Use this for initialization
	void Start () {
    }

    // Update is called once per frame
    void Update()
    {
        if (lifes <= 0)
        {
            if (!theGameisFinished)
            {
                theGameisFinished = true;
                SceneManager.LoadScene("Game Over");
            }
        }

        if (health <= 0)
        {
            if (GameObject.FindGameObjectWithTag("Save"))
            {
                GameObject[] gameObjects = GameObject.FindGameObjectsWithTag("Save");
                Destroy(gameObjects[0]);
                Debug.Log("Instantiate save");
                Instantiate(GameObject.FindGameObjectWithTag("Save"));
                transform.position = GameObject.FindGameObjectWithTag("Door").GetComponent<LoadLevel>().posOfChar;
            }
            else
            {
                Vector2 pos = new Vector2(-10f, -2.5f);
                transform.position = pos;
            }
            lifes -= 1;
            health = 5;
        }
        GetComponentInChildren<HUD>().Life = health;
        GetComponentInChildren<HUD>().LifeRespawn = lifes.ToString();
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            timer = 1f;
            canTakeDamages = true;
        }
    }

        public void PlayerHit()
        {
            if (canTakeDamages)
            {
                this.health -= 1;
                canTakeDamages = false;
            }
        }

    public void Mutate()
    {
        stateOfMutation += 1;
        switch (stateOfMutation)
        {
            case 1:
                LevelOneMutation();
                break;
            case 2:
                LevelTwoMutation();
                break;
            case 3:
                LevelThreeMutation();
                break;
            case 4:
                LevelFourMutation();
                break;
            case 5:
                LevelFiveMutation();
                break;
            case 6:
                LevelSixMutation();
                break;
        }
    }

    public void LevelOneMutation()
    {
        Debug.Log("Mutation lvl 1");
        GetComponent<SpriteRenderer>().sprite = characterSprites[1];
    }

    public void LevelTwoMutation()
    {
        GetComponent<UnityStandardAssets._2D.PlatformerCharacter2D>().m_MaxSpeed *= SpeedMutation;
        Debug.Log("Mutation lvl 2");
    }

    public void LevelThreeMutation()
    {
        GetComponent<UnityStandardAssets._2D.PlatformerCharacter2D>().m_JumpForce *= JumpMutation;
        GetComponent<SpriteRenderer>().sprite = characterSprites[2];
        Debug.Log("Mutation lvl 3");
    }

    public void LevelFourMutation()
    {
        foreach (GameObject ennemy in GameObject.FindGameObjectsWithTag("Ennemy"))
        {
            ennemy.GetComponent<Ennemy>().lifePoint *= lifeEnnemyMutation;
        }
        GetComponent<SpriteRenderer>().sprite = characterSprites[3];
        Debug.Log("Mutation lvl 4");
    }

    public void LevelFiveMutation()
    {
        foreach (GameObject ennemy in GameObject.FindGameObjectsWithTag("Ennemy"))
        {
            ennemy.GetComponent<Ennemy>().damages *= damagesEnnemyMutation;
        }
        GetComponent<SpriteRenderer>().sprite = characterSprites[4];
        Debug.Log("Mutation lvl 5");
    }

    public void LevelSixMutation()
    {
        if (GameObject.FindGameObjectWithTag("Save"))
        {
            GameObject[] gameObjects = GameObject.FindGameObjectsWithTag("Save");
            Destroy(gameObjects[0]);
            Debug.Log("Instantiate save");
            Instantiate(GameObject.FindGameObjectWithTag("Save"));
        }
        else
        {
            Vector2 pos = new Vector2(-10f, -2.5f);
            transform.position = pos;
        }
        lifes -= 1;
        health = 5;
    }
}
