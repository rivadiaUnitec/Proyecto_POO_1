
using UnityEngine;

public class Animacion : MonoBehaviour
{
    public float amplitud = 0.5f;
    public float velocidad = 1f;

    private Vector3 startPosition;


    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float y = Mathf.Sin(Time.time *velocidad)*amplitud;

        transform.position= startPosition + new Vector3(0,y,0);
    }
}
