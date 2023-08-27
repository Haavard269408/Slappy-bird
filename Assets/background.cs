using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class background : MonoBehaviour
{
    [SerializeField] private Transform spawnPos;
    [SerializeField] private Transform endPoint;
    
    [SerializeField] private float speed;
    public GameObject mountain;
    public SpriteRenderer spriteRender;


    // Start is called before the first frame update
    void Start()
    {
        Sprite sprite = GetComponent<SpriteRenderer>().sprite;   
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * speed* Time.deltaTime);

        


    }
}
