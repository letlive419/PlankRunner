using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
   
   [SerializeField] TextMeshProUGUI score;
    [SerializeField] TextMeshProUGUI lives;
    public int scorePoints;
    public int lifePoints;
    // Start is called before the first frame update
    void Start()
    {
        
       
       
        lifePoints = 3;
        lives.text = lifePoints.ToString();



    }

    // Update is called once per frame
    void Update()
    {
        scorePoints = Mathf.RoundToInt(105 * Time.time);
        score.text = scorePoints.ToString();
    }
}
