using UnityEngine;
using Cinemachine;

public class PlayerSize : MonoBehaviour
{
    [SerializeField] private float scaleincreaseThreshold;
    [SerializeField] private float scaledecreaseThreshold = 0.00f;
    [SerializeField] private float scalestep;
    private float scaleValue;
    private float points = 0;
    public CinemachineVirtualCamera Mycamera;
    [SerializeField] score score;
    [SerializeField] GameObject endgamePanel;
    [SerializeField] int max_points;

    private void Update()
    {
        if (points >= max_points)
        {
            Time.timeScale = 0f;
            endgamePanel.SetActive(true);

        }
    }


    public void increaseScale()
    {
       
        transform.localScale += new Vector3(.3f, 0f, .3f);
       
        Mycamera.m_Lens.FieldOfView += 1;
    }
    public void decreaseScale()
    {
        transform.localScale -= new Vector3(.3f, 0f, .3f);
    }


    
    public void CollectableCollected(Collectable foodItem)
    {
        scaleValue += foodItem.GetSize();
        Mathf.Round(scaleValue);
        
        points += foodItem.GetPoints();
        score.updatePoints(points);


        if (scaleValue >= scaleincreaseThreshold)
        {
            increaseScale();
            scaleValue %= scaleincreaseThreshold;
        }

        if (scaleValue <= scaledecreaseThreshold)
        {
           decreaseScale();
            scaleValue = 0;
            
        }

    }

}
