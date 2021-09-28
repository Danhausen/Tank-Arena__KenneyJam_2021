using System.Net.Mime;
using System.Linq.Expressions;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public int ammoAmount = 3;
    public Text ammoCounter;
    
    [SerializeField] private GameObject bullet_Spawn_Point;
    [SerializeField] private GameObject bullet;
    
    
    //TODO Criar mecanica para spawnar inimigos neste script e tambem evoluir na dificuldade
    //TODO Aqui tambem vai o temporizador e leaderboard
    
    //TODO seria bacana adicionar power ups
    void Start()
    {
        
    }
    
    void Update()
    {
        AmmoCounter();
    }
    
    public bool FiredBullet(){
        if (ammoAmount > 0){
            GameObject temporary_Rigidbody2D;
            temporary_Rigidbody2D = Instantiate(bullet, bullet_Spawn_Point.transform.position, bullet_Spawn_Point.transform.rotation);
            ammoAmount--;
        }
            return true ? ammoAmount > 0 : false;        
    }
    
    private void AmmoCounter(){
        ammoCounter.text = ammoAmount.ToString();
    }
}
