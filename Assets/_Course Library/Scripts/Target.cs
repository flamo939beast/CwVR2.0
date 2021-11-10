    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Target : MonoBehaviour
{
    public GameObject Dart;
    public TextMeshProUGUI scoreText;
    public int scoreValue;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Dart"))
        {
            Destroy(gameObject);


            scoreText.GetComponent<ScoreKeeper>().scoreValue += 5;
            scoreText.GetComponent<ScoreKeeper>().UpdateScore();
        }
    }
}
