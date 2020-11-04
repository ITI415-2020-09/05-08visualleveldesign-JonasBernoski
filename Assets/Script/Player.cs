using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
 
    public TextMeshProUGUI countText;
    public GameObject winTextObject;

    private Rigidbody rb;
    private int count;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        winTextObject.SetActive(false);
    }


    void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.CompareTag("Ball"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }
    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();

        if (count >= 20)
        {
            winTextObject.SetActive(true);
        }
    }
}
