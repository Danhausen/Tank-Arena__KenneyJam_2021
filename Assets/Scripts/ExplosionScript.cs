using UnityEngine;

public class ExplosionScript : DestroyAndInstantiateObject
{
    public float timeToDestroy = 4f;
    public float explosionRadiusSize2D = 1f;
    private CircleCollider2D circleExplosionCollider2D;
    
    void Start()
    {        
        circleExplosionCollider2D = GetComponent<CircleCollider2D>();
        circleExplosionCollider2D.radius = explosionRadiusSize2D;
        DestroyGameObject(timeToDestroy);
    }
    
    private void OnTriggerEnter2D(Collider2D other) {
        //TODO Trigger para explodir o que entrar no caminho da explosão do missile
    }
}
